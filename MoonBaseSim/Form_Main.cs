using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using People;
using Resources;


namespace MoonBaseSim
{
    public partial class Form_Main : Form
    {
        // Gobal Values for Applications for Resources and Level
        MoonBase MoonBase = new MoonBase();
        Resources.Resources Sources = new Resources.Resources();
        bool MiningOre = false;
        bool ProcessOre = false;
        bool SolarProduction = true;
        //Setup A logger to log to file
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();




        public Form_Main()
        {
            InitializeComponent();
            //Sets the Intial Values
            RefreshBaseValues();
            RefreshResouceValues();
            Logger.Info("StartMoonBaseSim");
        }

        // Updates/Sets the Base Values in Main Form 
        private void RefreshBaseValues()
        {
            try
            {
                LB_Base_Level_Value.Text = MoonBase.Level.ToString();
                LB_Base_Workers_Value.Text = Sources.Total_Workers.ToString();
                LB_Base_ActiveWorkers.Text = Sources.ActiveWorkers().ToString();
                UpdateExp();
            }
            catch (Exception ex) { Logger.Error(ex); }
        }
        // Updates/Sets the Resources in the Main Form
        private void RefreshResouceValues()
        {
            try
            {
                LB_Resource_Oxygen_Value.Text = Sources.Oxygen.ToString();
                LB_Resouce_Water_Value.Text = Sources.Water.ToString();
                LB_Resource_Food_Value.Text = Sources.Food.ToString();
                LB_Resource_Ore_Value.Text = Sources.Ore.ToString();
                LB_BasePower_Value.Text = Sources.Power().ToString();
                LB_LevelSolar_Value.Text = Sources.Solar.level.ToString();
                LB_SolarProduction_Value.Text = Sources.Solar.Production.ToString();
                BTN_SolarUpgrade.Text = $"Upgrade - {Sources.Solar.NextUpgradeLevl}";
                UpdateExp();
            }
            catch (Exception ex) { Logger.Error(ex); }

        }
        //Updates the EXP Values and tracks the Levels updates.
        private void UpdateExp()
        {
            try {
                //Checks if the EXP at next level or above for Level up
                if (MoonBase.EXP >= MoonBase.Next_Level_EXP)
                {
                    progressBar_EXP.Minimum = 0;
                    MoonBase.Level += 1;
                    Sources.Total_Workers += 5;
                    MoonBase.EXP = MoonBase.EXP - MoonBase.Next_Level_EXP;
                    MoonBase.Next_Level_EXP = MoonBase.Next_Level_EXP + 200;
                    RefreshBaseValues();
                    CheckforSolarUpgrade();
                    Logger.Info($"Moon Base Level Up: {MoonBase.Level}");
                }
                //Resets the EXP progress Bar on the form
                LB_EXP_Value.Text = MoonBase.EXP.ToString();
                progressBar_EXP.Value = MoonBase.EXP;
                progressBar_EXP.Maximum = MoonBase.Next_Level_EXP;

            }
            catch (Exception ex) { Logger.Error(ex); }

        }


        private void CheckforSolarUpgrade() 
        {
            try
            {
                if (MoonBase.Level == Sources.Solar.NextUpgradeLevl)
                {
                    //Enables the upgrade button for solar
                    BTN_SolarUpgrade.Enabled = true;
                    Logger.Info("Solar Power System Upgradable");
                }
                //Disable the button for solar uprade if not ready
                else { BTN_SolarUpgrade.Enabled = false; }
            }
            catch (Exception ex) { Logger.Error(ex); }

        }

        // Background Worker for Mining do work while active
        private void backgroundWorker_MineOre_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Logger.Info("Mining Ore Started");
                while (MiningOre)
                {
                    if (Sources.CurrentWorkers.Minners > 0)
                    {
                        Sources.Ore += (int)(1 * Sources.CurrentWorkers.Minners);
                        MoonBase.EXP += 1 * Sources.CurrentWorkers.Minners;
                    }
                    backgroundWorker_MineOre.ReportProgress(1);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex) { Logger.Error(ex); }
        }

        // Activate the Mining of Ore background process
        private void btn_Mine_Click(object sender, EventArgs e)
        {
            try
            {
                // Turns of the Mining Ore
                if (MiningOre)
                {
                    btn_Mine.Text = "Mine Ore";
                    MiningOre = false;
                    Sources.PowerUsed -= 10;



                }
                // Turns on Mining Ore
                else
                {
                    btn_Mine.Text = "Minning Ore";
                    MiningOre = true;
                    Sources.PowerUsed += 10;
                    backgroundWorker_MineOre.RunWorkerAsync();
                }
                // Reloads the Base Values for Works value
                RefreshBaseValues();
            }
            catch (Exception ex) { Logger.Error(ex); }

        }

        private void backgroundWorker_MineOre_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Refreshes the Resources after Mining has Completed
            RefreshResouceValues();
            Logger.Info("Minning Ore Stopped");
        }

        private void backgroundWorker_MineOre_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Live Updates the Resource Values while Mining.
            RefreshResouceValues();

        }
        //Remove Resouces for Game play
        private void timer_GamePlay_Tick(object sender, EventArgs e)
        {
            try
            {
                Sources.Oxygen = Sources.Oxygen - 2;
                //MoonBase.Resources.Food = MoonBase.Resources.Food - 1;
                RefreshResouceValues();

            }
            catch (Exception ex) { Logger.Error(ex); }
        }
        //Background Process for running Ore Process to convert Ore to Oxygen
        private void backgroundWorker_ProcessOre_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Logger.Info("Processing Ore Started");
                while (ProcessOre && Sources.Ore > 0 && Sources.CurrentWorkers.ProcessingWorkers > 0)
                {
                    Sources.Oxygen += 1*Sources.CurrentWorkers.ProcessingWorkers;
                    Sources.Ore -= 4*Sources.CurrentWorkers.ProcessingWorkers;
                    MoonBase.EXP += 10 * Sources.CurrentWorkers.ProcessingWorkers;
                    backgroundWorker_ProcessOre.ReportProgress(1);
                    Thread.Sleep(3000);
                }
            }
            catch(Exception ex) { Logger.Error(ex); }
        }

        private void backgroundWorker_ProcessOre_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Live Updates the Resource Values while Processing Ore.
            RefreshResouceValues();
        }
        //Starts the Processing Ore to Generate Oxygen
        private void BTN_ProcessOre_Click(object sender, EventArgs e)
        {
            //If Running 
            try
            {
                if (ProcessOre)
                {
                    ProcessOre = false;
                    BTN_ProcessOre.Text = "Process Ore";
                    Sources.PowerUsed -= 10;

                }
                //Start if not Running
                else
                {
                    ProcessOre = true;
                    BTN_ProcessOre.Text = "Processing Ore";
                    Sources.PowerUsed += 10;
                    backgroundWorker_ProcessOre.RunWorkerAsync();
                }
            }
            catch (Exception ex) { Logger.Error(ex); }
        }
        //Updates the Total Number of Minners
        private void ActiveMiners_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ActiveMiners.Value == 0)
                {
                    btn_Mine.Enabled = false;
                }
                else
                {
                    btn_Mine.Enabled = true;
                }
                Sources.CurrentWorkers.Minners = (int)ActiveMiners.Value;
                RefreshBaseValues();
            }
            catch (Exception ex) { Logger.Error(ex); }
        }
        //Updates the Total Number of Processing Workers
        private void ProcessingWorkers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ProcessingWorkers.Value == 0)
                { BTN_ProcessOre.Enabled = false; }
                else
                {
                    BTN_ProcessOre.Enabled = true;
                }
                Sources.CurrentWorkers.ProcessingWorkers = (int)ProcessingWorkers.Value;
                RefreshBaseValues();
            }
            catch (Exception ex) { Logger.Error(ex); }
        }


        private void BTN_SolarUpgrade_Click(object sender, EventArgs e)
        {
            try
            {
                //Update the Level by double each time
                Sources.Solar.NextUpgradeLevl = Sources.Solar.level * 2;
                Sources.Solar.level++;
                Logger.Info($"Solar Upgraded to Level: {Sources.Solar.level}");
                //Updates the Production Level 
                if (Sources.Solar.level < 4)
                {
                    Sources.Solar.Production += 10;
                }
                else
                {
                    Sources.Solar.Production += 20;
                }
                CheckforSolarUpgrade();
            }
            catch (Exception ex) { Logger.Error(ex); }


        }

        private void backgroundWorker_ProcessOre_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Logger.Info("Processing Ore Stopped");
        }

        private void ActiveMiners_Validated(object sender, EventArgs e)
        {

            
        }

        private void ActiveMiners_Validating(object sender, CancelEventArgs e)
        {
            //ActiveMiners.Maximum = Sources.CurrentWorkers.Minners + Sources.OpenWorkers(); 
        }
    }
}
