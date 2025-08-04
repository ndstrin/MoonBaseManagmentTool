using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using People;
using Building;

namespace MoonBaseManagement
{
    public partial class Main : Form
    {
        //Golbal Varibles
        public List<Civilian> ListCivilians = new List<Civilian>();
        public List<Crew> ListCrews = new List<Crew>();
        public List<LivingQuarter> ListLivingQuarters = new List<LivingQuarter>();
        public List<Infrastructure> ListInfrastructures = new List<Infrastructure>();


        public Main()
        {
            InitializeComponent();
            
        }



        //Updates the Data Grid Views if the List are not empty
        private void SyncDataSources() 
        {
            try 
            {
                dataGridViewCrew.DataSource =null;
                dataGridView_Civilians.DataSource = null;
                if (ListCivilians.Count > 0)
                {
                    dataGridView_Civilians.DataSource = ListCivilians;
                    
                }
                if (ListCrews.Count > 0)
                {
                    dataGridViewCrew.DataSource = ListCrews;
                }
                if (ListInfrastructures.Count > 0) 
                {
                    dataGridView_ColonyBuildings.DataSource = ListInfrastructures;
                }
                if (ListLivingQuarters.Count > 0) 
                {
                    dataGridView_LivingQuarters.DataSource = ListLivingQuarters;
                }
                
            }
            catch(Exception ex) 
            {
                
            }
        }

        //Adds Civilian Data to List
        private void AddCivilian() 
        {
            try
            {
                Civilian civilian = new Civilian(TB_FirstName.Text,TB_LastName.Text,CB_Sex.Text,DTP_DOB.Value);
                ListCivilians.Add(civilian);
                TB_StatusWindow.Text += $"\r\nNew Civilian added to MoonBase: {civilian.FirstName} {civilian.LastName}";
            }
            catch (Exception ex) { }
               
        }
        // Adds Crew data to List
        private void AddCrew() 
        {
            try
            {
                Crew crew = new Crew(TB_FirstName.Text, TB_LastName.Text,TB_JobTiltle.Text,int.Parse(TB_ID.Text), CB_Sex.Text, DTP_DOB.Value,$"{CB_Rank.Text}-{NUD_RankNumber.Value}");
                ListCrews.Add(crew);
                TB_StatusWindow.Text += $"\r\nNew Crew added to MoonBase:{crew.Rank} {crew.LastName}";
            }
            catch (Exception ex) { }
        }

        // When the Added button is click will add the Person type to the correct list.
        private void BTN_PeopleAdd_Click(object sender, EventArgs e)
        {
            if (CB_PersonType.Text == "Civilian")
            {
                AddCivilian();
                SyncDataSources();
            }
            else if (CB_PersonType.Text == "Crew") 
            {
                AddCrew();
                SyncDataSources();
            }
        }
        //Updates the required fields in the display for selected type
        private void CB_PersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_PersonType.Text == "Civilian")
            {
                GB_Crew.Visible = false;
                GB_PersonDetails.Enabled = true;
            }
            else if (CB_PersonType.Text == "Crew")
            {
                GB_Crew.Visible = true;
                GB_PersonDetails.Enabled = true;
            }
            else { GB_PersonDetails.Enabled = false; }

        }


        //Creates the Objects for the Buildings Classes
        private void CreateBuildings() 
        {
            try 
            {
                //Adds Living Quarters to List 
                LivingQuarter Quarters1 = new LivingQuarter("Dome 1","Basic Living Quarters 1", 1001);
                ListLivingQuarters.Add(Quarters1);
                LivingQuarter Quarters3 = new LivingQuarter("Dome 3", "Basic Living Quarters 3", 1003);
                Quarters3.Upgradeable = true;
                ListLivingQuarters.Add(Quarters3);
                LivingQuarter Quarters2 = new LivingQuarter("Dome 2", "Living Quarters 2", 1002);
                Quarters2.NumberOfPeople = 4;
                Quarters2.Level = 2;
                Quarters2.MaxNumberOfPeople = 15;
                ListLivingQuarters.Add(Quarters2);

                //Adds Infra Buildings to List
                Infrastructure PowerPlant1 = new Infrastructure("Solar Plant","Solar Power Station",5001,"Power","Solar");
                PowerPlant1.ProductionRate = 25;
                PowerPlant1.Workers = 3;
                PowerPlant1.Upgradeable = true;
                ListInfrastructures.Add(PowerPlant1);
                Infrastructure Mine1 = new Infrastructure("Ore Mine 1", "Mining for ORE Plant", 4001, "Resource", "Ore");
                Mine1.ProductionRate = 10;
                Mine1.Workers = 2;
                Mine1.Cost = 150;
                ListInfrastructures.Add (Mine1);
                Infrastructure Mine2 = new Infrastructure("Ore Mine 2", "Mining for ORE Plant", 4002, "Resource", "Ore");
                Mine2.ProductionRate = 20;
                Mine2.Level = 2;
                Mine2.Workers = 6;
                Mine2.Cost = 200;
                ListInfrastructures.Add(Mine1);
                Infrastructure GreenHouse1 = new Infrastructure("GreenHouse 1", "BioDome for Growing Plants", 3001, "Resource", "Food");
                GreenHouse1.ProductionRate = 20;
                GreenHouse1.Workers = 4;
                ListInfrastructures.Add(GreenHouse1);
                Infrastructure WaterTreatment = new Infrastructure("WaterTreatment1", "Metting Ice for Water", 3001, "Resource", "Water");
                WaterTreatment.ProductionRate = 5;
                WaterTreatment.Workers = 2;
                ListInfrastructures.Add(WaterTreatment);

                SyncDataSources();
            }
            catch (Exception ex) { }
        }
        //Creates the Objects for the People Class
        private void CreatePeople() 
        {
            Civilian civilian = new Civilian("John", "Doe", "M", new DateTime(1989, 06, 4));
            ListCivilians.Add(civilian);
            Crew crew = new Crew("Bob", "Doe", "Engineer", 1, "M", new DateTime(1960, 08, 2), $"O-2");
            ListCrews.Add(crew);
        }
        //On the Load of the Main Form
        private void Main_Load(object sender, EventArgs e)
        {
            TB_StatusWindow.Text += $"\r\nWelcome to the Moon Base Management Tool";
            CreateBuildings();
            CreatePeople();
            SyncDataSources();
        }
        //Say Hello to when double click peson
        private void dataGridView_Civilians_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = dataGridView_Civilians.CurrentRow.Index;
            TB_StatusWindow.Text += $"\r\n{ListCivilians[ID].SayHello()}";
        }
        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Adds Person to a Living Quaters
            int ID = dataGridView_LivingQuarters.CurrentRow.Index;
            if (ListLivingQuarters[ID].RoomAvailable())
            {
                ListLivingQuarters[ID].NumberOfPeople++;
                TB_StatusWindow.Text += $"\r\nPerson added to {ListLivingQuarters[ID].Name}";
            }
            else {TB_StatusWindow.Text += $"\r\nNo Room in {ListLivingQuarters[ID].Name}"; }
            SyncDataSources();
        }

        private void removePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Removes Person from Living Quaters
            int ID = dataGridView_LivingQuarters.CurrentRow.Index;
            if (!ListLivingQuarters[ID].QuartersEmpty())
            {
                ListLivingQuarters[ID].NumberOfPeople--;
                TB_StatusWindow.Text += $"\r\nPerson removed from {ListLivingQuarters[ID].Name}";
            }
            else { TB_StatusWindow.Text += $"\r\nNo One is Living in {ListLivingQuarters[ID].Name}"; }
            SyncDataSources();
        }
        //Says Hello when double click on a crew member
        private void dataGridViewCrew_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = dataGridViewCrew.CurrentRow.Index;
            TB_StatusWindow.Text += $"\r\n{ListCrews[ID].SayHello()}";
        }

        private void TB_StatusWindow_TextChanged(object sender, EventArgs e)
        {
            TB_StatusWindow.SelectionStart = TB_StatusWindow.Text.Length;
            TB_StatusWindow.ScrollToCaret();
        }
    }




    
}
