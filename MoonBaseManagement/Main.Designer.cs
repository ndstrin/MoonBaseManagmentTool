namespace MoonBaseManagement
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControlObjectType = new System.Windows.Forms.TabControl();
            this.tabPagePeople = new System.Windows.Forms.TabPage();
            this.GB_Type = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_PeopleAdd = new System.Windows.Forms.Button();
            this.CB_PersonType = new System.Windows.Forms.ComboBox();
            this.GB_Crew = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NUD_RankNumber = new System.Windows.Forms.NumericUpDown();
            this.CB_Rank = new System.Windows.Forms.ComboBox();
            this.LB_JobTitle = new System.Windows.Forms.Label();
            this.TB_JobTiltle = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.LB_ID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GB_PersonDetails = new System.Windows.Forms.GroupBox();
            this.LB_FirstName = new System.Windows.Forms.Label();
            this.TB_FirstName = new System.Windows.Forms.TextBox();
            this.TB_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_DOB = new System.Windows.Forms.DateTimePicker();
            this.CB_Sex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_CiviliansTitle = new System.Windows.Forms.Label();
            this.dataGridViewCrew = new System.Windows.Forms.DataGridView();
            this.dataGridView_Civilians = new System.Windows.Forms.DataGridView();
            this.tabPageBulidings = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_ColonyBuildings = new System.Windows.Forms.DataGridView();
            this.dataGridView_LivingQuarters = new System.Windows.Forms.DataGridView();
            this.contextMenuStripQuarters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_StatusWindow = new System.Windows.Forms.TextBox();
            this.tabControlObjectType.SuspendLayout();
            this.tabPagePeople.SuspendLayout();
            this.GB_Type.SuspendLayout();
            this.GB_Crew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_RankNumber)).BeginInit();
            this.GB_PersonDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Civilians)).BeginInit();
            this.tabPageBulidings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ColonyBuildings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LivingQuarters)).BeginInit();
            this.contextMenuStripQuarters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlObjectType
            // 
            this.tabControlObjectType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlObjectType.Controls.Add(this.tabPagePeople);
            this.tabControlObjectType.Controls.Add(this.tabPageBulidings);
            this.tabControlObjectType.Location = new System.Drawing.Point(4, 107);
            this.tabControlObjectType.Name = "tabControlObjectType";
            this.tabControlObjectType.SelectedIndex = 0;
            this.tabControlObjectType.Size = new System.Drawing.Size(1399, 795);
            this.tabControlObjectType.TabIndex = 0;
            // 
            // tabPagePeople
            // 
            this.tabPagePeople.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPagePeople.BackgroundImage")));
            this.tabPagePeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagePeople.Controls.Add(this.GB_Type);
            this.tabPagePeople.Controls.Add(this.GB_Crew);
            this.tabPagePeople.Controls.Add(this.GB_PersonDetails);
            this.tabPagePeople.Controls.Add(this.label2);
            this.tabPagePeople.Controls.Add(this.label1);
            this.tabPagePeople.Controls.Add(this.LB_CiviliansTitle);
            this.tabPagePeople.Controls.Add(this.dataGridViewCrew);
            this.tabPagePeople.Controls.Add(this.dataGridView_Civilians);
            this.tabPagePeople.Location = new System.Drawing.Point(4, 22);
            this.tabPagePeople.Name = "tabPagePeople";
            this.tabPagePeople.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePeople.Size = new System.Drawing.Size(1391, 769);
            this.tabPagePeople.TabIndex = 0;
            this.tabPagePeople.Text = "People";
            this.tabPagePeople.UseVisualStyleBackColor = true;
            // 
            // GB_Type
            // 
            this.GB_Type.BackColor = System.Drawing.SystemColors.GrayText;
            this.GB_Type.Controls.Add(this.label6);
            this.GB_Type.Controls.Add(this.BTN_PeopleAdd);
            this.GB_Type.Controls.Add(this.CB_PersonType);
            this.GB_Type.Location = new System.Drawing.Point(967, 598);
            this.GB_Type.Name = "GB_Type";
            this.GB_Type.Size = new System.Drawing.Size(234, 93);
            this.GB_Type.TabIndex = 19;
            this.GB_Type.TabStop = false;
            this.GB_Type.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Person Type";
            // 
            // BTN_PeopleAdd
            // 
            this.BTN_PeopleAdd.Location = new System.Drawing.Point(121, 51);
            this.BTN_PeopleAdd.Name = "BTN_PeopleAdd";
            this.BTN_PeopleAdd.Size = new System.Drawing.Size(75, 23);
            this.BTN_PeopleAdd.TabIndex = 14;
            this.BTN_PeopleAdd.Text = "Add";
            this.BTN_PeopleAdd.UseVisualStyleBackColor = true;
            this.BTN_PeopleAdd.Click += new System.EventHandler(this.BTN_PeopleAdd_Click);
            // 
            // CB_PersonType
            // 
            this.CB_PersonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_PersonType.FormattingEnabled = true;
            this.CB_PersonType.Items.AddRange(new object[] {
            "Civilian",
            "Crew"});
            this.CB_PersonType.Location = new System.Drawing.Point(121, 21);
            this.CB_PersonType.Name = "CB_PersonType";
            this.CB_PersonType.Size = new System.Drawing.Size(73, 24);
            this.CB_PersonType.TabIndex = 15;
            this.CB_PersonType.SelectedIndexChanged += new System.EventHandler(this.CB_PersonType_SelectedIndexChanged);
            // 
            // GB_Crew
            // 
            this.GB_Crew.BackColor = System.Drawing.SystemColors.GrayText;
            this.GB_Crew.Controls.Add(this.label7);
            this.GB_Crew.Controls.Add(this.NUD_RankNumber);
            this.GB_Crew.Controls.Add(this.CB_Rank);
            this.GB_Crew.Controls.Add(this.LB_JobTitle);
            this.GB_Crew.Controls.Add(this.TB_JobTiltle);
            this.GB_Crew.Controls.Add(this.TB_ID);
            this.GB_Crew.Controls.Add(this.LB_ID);
            this.GB_Crew.Controls.Add(this.label10);
            this.GB_Crew.Location = new System.Drawing.Point(490, 598);
            this.GB_Crew.Name = "GB_Crew";
            this.GB_Crew.Size = new System.Drawing.Size(443, 151);
            this.GB_Crew.TabIndex = 18;
            this.GB_Crew.TabStop = false;
            this.GB_Crew.Text = "Crew Info";
            this.GB_Crew.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 39);
            this.label7.TabIndex = 14;
            this.label7.Text = "-";
            // 
            // NUD_RankNumber
            // 
            this.NUD_RankNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_RankNumber.Location = new System.Drawing.Point(87, 99);
            this.NUD_RankNumber.Name = "NUD_RankNumber";
            this.NUD_RankNumber.Size = new System.Drawing.Size(47, 23);
            this.NUD_RankNumber.TabIndex = 15;
            // 
            // CB_Rank
            // 
            this.CB_Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Rank.FormattingEnabled = true;
            this.CB_Rank.Items.AddRange(new object[] {
            "O",
            "E"});
            this.CB_Rank.Location = new System.Drawing.Point(12, 98);
            this.CB_Rank.Name = "CB_Rank";
            this.CB_Rank.Size = new System.Drawing.Size(44, 24);
            this.CB_Rank.TabIndex = 14;
            // 
            // LB_JobTitle
            // 
            this.LB_JobTitle.AutoSize = true;
            this.LB_JobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_JobTitle.Location = new System.Drawing.Point(11, 20);
            this.LB_JobTitle.Name = "LB_JobTitle";
            this.LB_JobTitle.Size = new System.Drawing.Size(75, 17);
            this.LB_JobTitle.TabIndex = 6;
            this.LB_JobTitle.Text = "Job Tiltle";
            // 
            // TB_JobTiltle
            // 
            this.TB_JobTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_JobTiltle.Location = new System.Drawing.Point(11, 39);
            this.TB_JobTiltle.Name = "TB_JobTiltle";
            this.TB_JobTiltle.Size = new System.Drawing.Size(159, 23);
            this.TB_JobTiltle.TabIndex = 5;
            // 
            // TB_ID
            // 
            this.TB_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ID.Location = new System.Drawing.Point(201, 40);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(159, 23);
            this.TB_ID.TabIndex = 7;
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(198, 20);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(84, 17);
            this.LB_ID.TabIndex = 8;
            this.LB_ID.Text = "ID Number";
            this.LB_ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Rank";
            // 
            // GB_PersonDetails
            // 
            this.GB_PersonDetails.BackColor = System.Drawing.SystemColors.GrayText;
            this.GB_PersonDetails.Controls.Add(this.LB_FirstName);
            this.GB_PersonDetails.Controls.Add(this.TB_FirstName);
            this.GB_PersonDetails.Controls.Add(this.TB_LastName);
            this.GB_PersonDetails.Controls.Add(this.label3);
            this.GB_PersonDetails.Controls.Add(this.label5);
            this.GB_PersonDetails.Controls.Add(this.DTP_DOB);
            this.GB_PersonDetails.Controls.Add(this.CB_Sex);
            this.GB_PersonDetails.Controls.Add(this.label4);
            this.GB_PersonDetails.Enabled = false;
            this.GB_PersonDetails.Location = new System.Drawing.Point(18, 598);
            this.GB_PersonDetails.Name = "GB_PersonDetails";
            this.GB_PersonDetails.Size = new System.Drawing.Size(443, 151);
            this.GB_PersonDetails.TabIndex = 17;
            this.GB_PersonDetails.TabStop = false;
            this.GB_PersonDetails.Text = "Person Info";
            // 
            // LB_FirstName
            // 
            this.LB_FirstName.AutoSize = true;
            this.LB_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FirstName.Location = new System.Drawing.Point(11, 20);
            this.LB_FirstName.Name = "LB_FirstName";
            this.LB_FirstName.Size = new System.Drawing.Size(86, 17);
            this.LB_FirstName.TabIndex = 6;
            this.LB_FirstName.Text = "First Name";
            // 
            // TB_FirstName
            // 
            this.TB_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FirstName.Location = new System.Drawing.Point(11, 39);
            this.TB_FirstName.Name = "TB_FirstName";
            this.TB_FirstName.Size = new System.Drawing.Size(159, 23);
            this.TB_FirstName.TabIndex = 5;
            // 
            // TB_LastName
            // 
            this.TB_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LastName.Location = new System.Drawing.Point(201, 40);
            this.TB_LastName.Name = "TB_LastName";
            this.TB_LastName.Size = new System.Drawing.Size(159, 23);
            this.TB_LastName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender";
            // 
            // DTP_DOB
            // 
            this.DTP_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DOB.Location = new System.Drawing.Point(11, 96);
            this.DTP_DOB.Name = "DTP_DOB";
            this.DTP_DOB.Size = new System.Drawing.Size(239, 23);
            this.DTP_DOB.TabIndex = 10;
            // 
            // CB_Sex
            // 
            this.CB_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Sex.FormattingEnabled = true;
            this.CB_Sex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CB_Sex.Location = new System.Drawing.Point(276, 96);
            this.CB_Sex.Name = "CB_Sex";
            this.CB_Sex.Size = new System.Drawing.Size(44, 24);
            this.CB_Sex.TabIndex = 12;
            this.CB_Sex.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "DOB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(447, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Crew";
            // 
            // LB_CiviliansTitle
            // 
            this.LB_CiviliansTitle.AutoSize = true;
            this.LB_CiviliansTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CiviliansTitle.ForeColor = System.Drawing.Color.White;
            this.LB_CiviliansTitle.Location = new System.Drawing.Point(183, 16);
            this.LB_CiviliansTitle.Name = "LB_CiviliansTitle";
            this.LB_CiviliansTitle.Size = new System.Drawing.Size(118, 31);
            this.LB_CiviliansTitle.TabIndex = 2;
            this.LB_CiviliansTitle.Text = "Civilans";
            // 
            // dataGridViewCrew
            // 
            this.dataGridViewCrew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrew.Location = new System.Drawing.Point(6, 300);
            this.dataGridViewCrew.Name = "dataGridViewCrew";
            this.dataGridViewCrew.ReadOnly = true;
            this.dataGridViewCrew.Size = new System.Drawing.Size(960, 173);
            this.dataGridViewCrew.TabIndex = 1;
            this.dataGridViewCrew.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCrew_CellDoubleClick);
            // 
            // dataGridView_Civilians
            // 
            this.dataGridView_Civilians.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Civilians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Civilians.Location = new System.Drawing.Point(4, 50);
            this.dataGridView_Civilians.Name = "dataGridView_Civilians";
            this.dataGridView_Civilians.ReadOnly = true;
            this.dataGridView_Civilians.Size = new System.Drawing.Size(656, 175);
            this.dataGridView_Civilians.TabIndex = 0;
            this.dataGridView_Civilians.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Civilians_CellDoubleClick);
            // 
            // tabPageBulidings
            // 
            this.tabPageBulidings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageBulidings.BackgroundImage")));
            this.tabPageBulidings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageBulidings.Controls.Add(this.label8);
            this.tabPageBulidings.Controls.Add(this.label9);
            this.tabPageBulidings.Controls.Add(this.dataGridView_ColonyBuildings);
            this.tabPageBulidings.Controls.Add(this.dataGridView_LivingQuarters);
            this.tabPageBulidings.Location = new System.Drawing.Point(4, 22);
            this.tabPageBulidings.Name = "tabPageBulidings";
            this.tabPageBulidings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBulidings.Size = new System.Drawing.Size(1391, 769);
            this.tabPageBulidings.TabIndex = 1;
            this.tabPageBulidings.Text = "Buildings";
            this.tabPageBulidings.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(257, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "Colony Buildings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(257, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 31);
            this.label9.TabIndex = 6;
            this.label9.Text = "Living Quarters";
            // 
            // dataGridView_ColonyBuildings
            // 
            this.dataGridView_ColonyBuildings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ColonyBuildings.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView_ColonyBuildings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ColonyBuildings.Location = new System.Drawing.Point(6, 292);
            this.dataGridView_ColonyBuildings.Name = "dataGridView_ColonyBuildings";
            this.dataGridView_ColonyBuildings.ReadOnly = true;
            this.dataGridView_ColonyBuildings.Size = new System.Drawing.Size(903, 284);
            this.dataGridView_ColonyBuildings.TabIndex = 5;
            // 
            // dataGridView_LivingQuarters
            // 
            this.dataGridView_LivingQuarters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_LivingQuarters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LivingQuarters.ContextMenuStrip = this.contextMenuStripQuarters;
            this.dataGridView_LivingQuarters.Location = new System.Drawing.Point(4, 44);
            this.dataGridView_LivingQuarters.Name = "dataGridView_LivingQuarters";
            this.dataGridView_LivingQuarters.ReadOnly = true;
            this.dataGridView_LivingQuarters.Size = new System.Drawing.Size(905, 192);
            this.dataGridView_LivingQuarters.TabIndex = 4;
            // 
            // contextMenuStripQuarters
            // 
            this.contextMenuStripQuarters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPersonToolStripMenuItem,
            this.removePersonToolStripMenuItem});
            this.contextMenuStripQuarters.Name = "contextMenuStripQuarters";
            this.contextMenuStripQuarters.Size = new System.Drawing.Size(157, 48);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addPersonToolStripMenuItem.Text = "Add Person";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // removePersonToolStripMenuItem
            // 
            this.removePersonToolStripMenuItem.Name = "removePersonToolStripMenuItem";
            this.removePersonToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.removePersonToolStripMenuItem.Text = "Remove Person";
            this.removePersonToolStripMenuItem.Click += new System.EventHandler(this.removePersonToolStripMenuItem_Click);
            // 
            // TB_StatusWindow
            // 
            this.TB_StatusWindow.BackColor = System.Drawing.SystemColors.Desktop;
            this.TB_StatusWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_StatusWindow.ForeColor = System.Drawing.Color.White;
            this.TB_StatusWindow.Location = new System.Drawing.Point(14, 12);
            this.TB_StatusWindow.Multiline = true;
            this.TB_StatusWindow.Name = "TB_StatusWindow";
            this.TB_StatusWindow.ReadOnly = true;
            this.TB_StatusWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_StatusWindow.Size = new System.Drawing.Size(1378, 69);
            this.TB_StatusWindow.TabIndex = 1;
            this.TB_StatusWindow.TextChanged += new System.EventHandler(this.TB_StatusWindow_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1404, 906);
            this.Controls.Add(this.TB_StatusWindow);
            this.Controls.Add(this.tabControlObjectType);
            this.Name = "Main";
            this.Text = "Moon Base Management Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControlObjectType.ResumeLayout(false);
            this.tabPagePeople.ResumeLayout(false);
            this.tabPagePeople.PerformLayout();
            this.GB_Type.ResumeLayout(false);
            this.GB_Type.PerformLayout();
            this.GB_Crew.ResumeLayout(false);
            this.GB_Crew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_RankNumber)).EndInit();
            this.GB_PersonDetails.ResumeLayout(false);
            this.GB_PersonDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Civilians)).EndInit();
            this.tabPageBulidings.ResumeLayout(false);
            this.tabPageBulidings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ColonyBuildings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LivingQuarters)).EndInit();
            this.contextMenuStripQuarters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlObjectType;
        private System.Windows.Forms.TabPage tabPagePeople;
        private System.Windows.Forms.TabPage tabPageBulidings;
        private System.Windows.Forms.DataGridView dataGridView_Civilians;
        private System.Windows.Forms.DataGridView dataGridViewCrew;
        private System.Windows.Forms.Label LB_CiviliansTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_LastName;
        private System.Windows.Forms.Label LB_FirstName;
        private System.Windows.Forms.TextBox TB_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTP_DOB;
        private System.Windows.Forms.Button BTN_PeopleAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_Sex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_PersonType;
        private System.Windows.Forms.GroupBox GB_Crew;
        private System.Windows.Forms.Label LB_JobTitle;
        private System.Windows.Forms.TextBox TB_JobTiltle;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox GB_PersonDetails;
        private System.Windows.Forms.ComboBox CB_Rank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NUD_RankNumber;
        private System.Windows.Forms.GroupBox GB_Type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_ColonyBuildings;
        private System.Windows.Forms.DataGridView dataGridView_LivingQuarters;
        private System.Windows.Forms.TextBox TB_StatusWindow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQuarters;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePersonToolStripMenuItem;
    }
}

