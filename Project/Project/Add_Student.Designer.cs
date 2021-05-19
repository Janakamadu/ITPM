
namespace Project
{
    partial class Add_Student
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
            this.StuCLEAR = new System.Windows.Forms.Button();
            this.StuGenerate = new System.Windows.Forms.Button();
            this.StuADD = new System.Windows.Forms.Button();
            this.StucomboBox1 = new System.Windows.Forms.ComboBox();
            this.StutextBox1 = new System.Windows.Forms.TextBox();
            this.StuSubGroupNo = new System.Windows.Forms.Label();
            this.StuSubgroupID = new System.Windows.Forms.Label();
            this.StuGroupID = new System.Windows.Forms.Label();
            this.StuGroupNo = new System.Windows.Forms.Label();
            this.StuProgramme = new System.Windows.Forms.Label();
            this.StuAcedemicYear = new System.Windows.Forms.Label();
            this.StuLabel1 = new System.Windows.Forms.Button();
            this.StuLabl = new System.Windows.Forms.Label();
            this.StuTimeTable = new System.Windows.Forms.Button();
            this.StuStatistics = new System.Windows.Forms.Button();
            this.StuLocations = new System.Windows.Forms.Button();
            this.StuRoom = new System.Windows.Forms.Button();
            this.StuHome = new System.Windows.Forms.Button();
            this.StuTag = new System.Windows.Forms.Button();
            this.StuWorking = new System.Windows.Forms.Button();
            this.StuAdvanced = new System.Windows.Forms.Button();
            this.StuSession = new System.Windows.Forms.Button();
            this.StuSubject = new System.Windows.Forms.Button();
            this.StuStudent = new System.Windows.Forms.Button();
            this.StuLecturer = new System.Windows.Forms.Button();
            this.StutextBox2 = new System.Windows.Forms.TextBox();
            this.StutextBox3 = new System.Windows.Forms.TextBox();
            this.StunumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.StunumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.StuLabel3 = new System.Windows.Forms.Button();
            this.StuLabel2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StunumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StunumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // StuCLEAR
            // 
            this.StuCLEAR.BackColor = System.Drawing.Color.Red;
            this.StuCLEAR.Location = new System.Drawing.Point(416, 559);
            this.StuCLEAR.Name = "StuCLEAR";
            this.StuCLEAR.Size = new System.Drawing.Size(90, 35);
            this.StuCLEAR.TabIndex = 69;
            this.StuCLEAR.Text = "CLEAR";
            this.StuCLEAR.UseVisualStyleBackColor = false;
            this.StuCLEAR.Click += new System.EventHandler(this.StuCLEAR_Click);
            // 
            // StuGenerate
            // 
            this.StuGenerate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.StuGenerate.Location = new System.Drawing.Point(591, 559);
            this.StuGenerate.Name = "StuGenerate";
            this.StuGenerate.Size = new System.Drawing.Size(100, 35);
            this.StuGenerate.TabIndex = 68;
            this.StuGenerate.Text = "Generate ID";
            this.StuGenerate.UseVisualStyleBackColor = false;
            this.StuGenerate.Click += new System.EventHandler(this.StuGenerate_Click);
            // 
            // StuADD
            // 
            this.StuADD.BackColor = System.Drawing.Color.Blue;
            this.StuADD.Location = new System.Drawing.Point(251, 559);
            this.StuADD.Name = "StuADD";
            this.StuADD.Size = new System.Drawing.Size(90, 35);
            this.StuADD.TabIndex = 67;
            this.StuADD.Text = "ADD";
            this.StuADD.UseVisualStyleBackColor = false;
            this.StuADD.Click += new System.EventHandler(this.StuADD_Click);
            // 
            // StucomboBox1
            // 
            this.StucomboBox1.FormattingEnabled = true;
            this.StucomboBox1.Items.AddRange(new object[] {
            "CSE",
            "IT",
            "DS",
            "SE"});
            this.StucomboBox1.Location = new System.Drawing.Point(348, 217);
            this.StucomboBox1.Name = "StucomboBox1";
            this.StucomboBox1.Size = new System.Drawing.Size(375, 24);
            this.StucomboBox1.TabIndex = 61;
            // 
            // StutextBox1
            // 
            this.StutextBox1.Location = new System.Drawing.Point(347, 169);
            this.StutextBox1.Name = "StutextBox1";
            this.StutextBox1.Size = new System.Drawing.Size(376, 22);
            this.StutextBox1.TabIndex = 59;
            // 
            // StuSubGroupNo
            // 
            this.StuSubGroupNo.AutoSize = true;
            this.StuSubGroupNo.Location = new System.Drawing.Point(166, 332);
            this.StuSubGroupNo.Name = "StuSubGroupNo";
            this.StuSubGroupNo.Size = new System.Drawing.Size(99, 17);
            this.StuSubGroupNo.TabIndex = 58;
            this.StuSubGroupNo.Text = "Sub Group No";
            // 
            // StuSubgroupID
            // 
            this.StuSubgroupID.AutoSize = true;
            this.StuSubgroupID.Location = new System.Drawing.Point(166, 435);
            this.StuSubgroupID.Name = "StuSubgroupID";
            this.StuSubgroupID.Size = new System.Drawing.Size(94, 17);
            this.StuSubgroupID.TabIndex = 55;
            this.StuSubgroupID.Text = "Sub Group ID";
            // 
            // StuGroupID
            // 
            this.StuGroupID.AutoSize = true;
            this.StuGroupID.Location = new System.Drawing.Point(167, 384);
            this.StuGroupID.Name = "StuGroupID";
            this.StuGroupID.Size = new System.Drawing.Size(65, 17);
            this.StuGroupID.TabIndex = 54;
            this.StuGroupID.Text = "Group ID";
            // 
            // StuGroupNo
            // 
            this.StuGroupNo.AutoSize = true;
            this.StuGroupNo.Location = new System.Drawing.Point(168, 279);
            this.StuGroupNo.Name = "StuGroupNo";
            this.StuGroupNo.Size = new System.Drawing.Size(70, 17);
            this.StuGroupNo.TabIndex = 53;
            this.StuGroupNo.Text = "Group No";
            // 
            // StuProgramme
            // 
            this.StuProgramme.AutoSize = true;
            this.StuProgramme.Location = new System.Drawing.Point(168, 224);
            this.StuProgramme.Name = "StuProgramme";
            this.StuProgramme.Size = new System.Drawing.Size(81, 17);
            this.StuProgramme.TabIndex = 52;
            this.StuProgramme.Text = "Programme";
            // 
            // StuAcedemicYear
            // 
            this.StuAcedemicYear.AutoSize = true;
            this.StuAcedemicYear.Location = new System.Drawing.Point(166, 174);
            this.StuAcedemicYear.Name = "StuAcedemicYear";
            this.StuAcedemicYear.Size = new System.Drawing.Size(163, 17);
            this.StuAcedemicYear.TabIndex = 51;
            this.StuAcedemicYear.Text = " Academic Year Semster";
            // 
            // StuLabel1
            // 
            this.StuLabel1.BackColor = System.Drawing.Color.Crimson;
            this.StuLabel1.Location = new System.Drawing.Point(133, 91);
            this.StuLabel1.Name = "StuLabel1";
            this.StuLabel1.Size = new System.Drawing.Size(208, 35);
            this.StuLabel1.TabIndex = 48;
            this.StuLabel1.Text = "Add Student";
            this.StuLabel1.UseVisualStyleBackColor = false;
            // 
            // StuLabl
            // 
            this.StuLabl.AutoSize = true;
            this.StuLabl.BackColor = System.Drawing.Color.Blue;
            this.StuLabl.Location = new System.Drawing.Point(42, 40);
            this.StuLabl.Name = "StuLabl";
            this.StuLabl.Size = new System.Drawing.Size(57, 17);
            this.StuLabl.TabIndex = 47;
            this.StuLabl.Text = "Student";
            // 
            // StuTimeTable
            // 
            this.StuTimeTable.Location = new System.Drawing.Point(738, 12);
            this.StuTimeTable.Name = "StuTimeTable";
            this.StuTimeTable.Size = new System.Drawing.Size(104, 72);
            this.StuTimeTable.TabIndex = 46;
            this.StuTimeTable.Text = "Time Table";
            this.StuTimeTable.UseVisualStyleBackColor = true;
            // 
            // StuStatistics
            // 
            this.StuStatistics.Location = new System.Drawing.Point(587, 12);
            this.StuStatistics.Name = "StuStatistics";
            this.StuStatistics.Size = new System.Drawing.Size(104, 72);
            this.StuStatistics.TabIndex = 45;
            this.StuStatistics.Text = "Statistics";
            this.StuStatistics.UseVisualStyleBackColor = true;
            // 
            // StuLocations
            // 
            this.StuLocations.Location = new System.Drawing.Point(438, 12);
            this.StuLocations.Name = "StuLocations";
            this.StuLocations.Size = new System.Drawing.Size(104, 72);
            this.StuLocations.TabIndex = 44;
            this.StuLocations.Text = "Location";
            this.StuLocations.UseVisualStyleBackColor = true;
            // 
            // StuRoom
            // 
            this.StuRoom.Location = new System.Drawing.Point(280, 12);
            this.StuRoom.Name = "StuRoom";
            this.StuRoom.Size = new System.Drawing.Size(104, 72);
            this.StuRoom.TabIndex = 43;
            this.StuRoom.Text = "Room";
            this.StuRoom.UseVisualStyleBackColor = true;
            // 
            // StuHome
            // 
            this.StuHome.Location = new System.Drawing.Point(132, 12);
            this.StuHome.Name = "StuHome";
            this.StuHome.Size = new System.Drawing.Size(104, 72);
            this.StuHome.TabIndex = 42;
            this.StuHome.Text = "Home";
            this.StuHome.UseVisualStyleBackColor = true;
            // 
            // StuTag
            // 
            this.StuTag.Location = new System.Drawing.Point(23, 325);
            this.StuTag.Name = "StuTag";
            this.StuTag.Size = new System.Drawing.Size(104, 72);
            this.StuTag.TabIndex = 41;
            this.StuTag.Text = "Tag";
            this.StuTag.UseVisualStyleBackColor = true;
            // 
            // StuWorking
            // 
            this.StuWorking.Location = new System.Drawing.Point(23, 559);
            this.StuWorking.Name = "StuWorking";
            this.StuWorking.Size = new System.Drawing.Size(104, 72);
            this.StuWorking.TabIndex = 40;
            this.StuWorking.Text = "Working Days and Hours";
            this.StuWorking.UseVisualStyleBackColor = true;
            // 
            // StuAdvanced
            // 
            this.StuAdvanced.Location = new System.Drawing.Point(23, 481);
            this.StuAdvanced.Name = "StuAdvanced";
            this.StuAdvanced.Size = new System.Drawing.Size(104, 72);
            this.StuAdvanced.TabIndex = 39;
            this.StuAdvanced.Text = "Advanced Session";
            this.StuAdvanced.UseVisualStyleBackColor = true;
            // 
            // StuSession
            // 
            this.StuSession.Location = new System.Drawing.Point(23, 403);
            this.StuSession.Name = "StuSession";
            this.StuSession.Size = new System.Drawing.Size(104, 72);
            this.StuSession.TabIndex = 38;
            this.StuSession.Text = "Session";
            this.StuSession.UseVisualStyleBackColor = true;
            // 
            // StuSubject
            // 
            this.StuSubject.Location = new System.Drawing.Point(23, 247);
            this.StuSubject.Name = "StuSubject";
            this.StuSubject.Size = new System.Drawing.Size(104, 72);
            this.StuSubject.TabIndex = 37;
            this.StuSubject.Text = "Subject";
            this.StuSubject.UseVisualStyleBackColor = true;
            // 
            // StuStudent
            // 
            this.StuStudent.Location = new System.Drawing.Point(23, 169);
            this.StuStudent.Name = "StuStudent";
            this.StuStudent.Size = new System.Drawing.Size(104, 72);
            this.StuStudent.TabIndex = 36;
            this.StuStudent.Text = "Student";
            this.StuStudent.UseVisualStyleBackColor = true;
            // 
            // StuLecturer
            // 
            this.StuLecturer.Location = new System.Drawing.Point(23, 91);
            this.StuLecturer.Name = "StuLecturer";
            this.StuLecturer.Size = new System.Drawing.Size(104, 72);
            this.StuLecturer.TabIndex = 35;
            this.StuLecturer.Text = "Lecturer";
            this.StuLecturer.UseVisualStyleBackColor = true;
            // 
            // StutextBox2
            // 
            this.StutextBox2.Location = new System.Drawing.Point(346, 381);
            this.StutextBox2.Name = "StutextBox2";
            this.StutextBox2.Size = new System.Drawing.Size(376, 22);
            this.StutextBox2.TabIndex = 70;
            // 
            // StutextBox3
            // 
            this.StutextBox3.Location = new System.Drawing.Point(346, 432);
            this.StutextBox3.Name = "StutextBox3";
            this.StutextBox3.Size = new System.Drawing.Size(376, 22);
            this.StutextBox3.TabIndex = 71;
            // 
            // StunumericUpDown1
            // 
            this.StunumericUpDown1.Location = new System.Drawing.Point(348, 277);
            this.StunumericUpDown1.Name = "StunumericUpDown1";
            this.StunumericUpDown1.Size = new System.Drawing.Size(374, 22);
            this.StunumericUpDown1.TabIndex = 72;
            // 
            // StunumericUpDown2
            // 
            this.StunumericUpDown2.Location = new System.Drawing.Point(346, 330);
            this.StunumericUpDown2.Name = "StunumericUpDown2";
            this.StunumericUpDown2.Size = new System.Drawing.Size(377, 22);
            this.StunumericUpDown2.TabIndex = 73;
            // 
            // StuLabel3
            // 
            this.StuLabel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.StuLabel3.Location = new System.Drawing.Point(561, 90);
            this.StuLabel3.Name = "StuLabel3";
            this.StuLabel3.Size = new System.Drawing.Size(208, 35);
            this.StuLabel3.TabIndex = 74;
            this.StuLabel3.Text = "Edit Student";
            this.StuLabel3.UseVisualStyleBackColor = false;
            this.StuLabel3.Click += new System.EventHandler(this.StuLabel3_Click_1);
            // 
            // StuLabel2
            // 
            this.StuLabel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.StuLabel2.Location = new System.Drawing.Point(346, 91);
            this.StuLabel2.Name = "StuLabel2";
            this.StuLabel2.Size = new System.Drawing.Size(208, 35);
            this.StuLabel2.TabIndex = 75;
            this.StuLabel2.Text = "Edit Student";
            this.StuLabel2.UseVisualStyleBackColor = false;
            this.StuLabel2.Click += new System.EventHandler(this.StuLabel2_Click);
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 643);
            this.Controls.Add(this.StuLabel2);
            this.Controls.Add(this.StuLabel3);
            this.Controls.Add(this.StunumericUpDown2);
            this.Controls.Add(this.StunumericUpDown1);
            this.Controls.Add(this.StutextBox3);
            this.Controls.Add(this.StutextBox2);
            this.Controls.Add(this.StuCLEAR);
            this.Controls.Add(this.StuGenerate);
            this.Controls.Add(this.StuADD);
            this.Controls.Add(this.StucomboBox1);
            this.Controls.Add(this.StutextBox1);
            this.Controls.Add(this.StuSubGroupNo);
            this.Controls.Add(this.StuSubgroupID);
            this.Controls.Add(this.StuGroupID);
            this.Controls.Add(this.StuGroupNo);
            this.Controls.Add(this.StuProgramme);
            this.Controls.Add(this.StuAcedemicYear);
            this.Controls.Add(this.StuLabel1);
            this.Controls.Add(this.StuLabl);
            this.Controls.Add(this.StuTimeTable);
            this.Controls.Add(this.StuStatistics);
            this.Controls.Add(this.StuLocations);
            this.Controls.Add(this.StuRoom);
            this.Controls.Add(this.StuHome);
            this.Controls.Add(this.StuTag);
            this.Controls.Add(this.StuWorking);
            this.Controls.Add(this.StuAdvanced);
            this.Controls.Add(this.StuSession);
            this.Controls.Add(this.StuSubject);
            this.Controls.Add(this.StuStudent);
            this.Controls.Add(this.StuLecturer);
            this.Name = "Add_Student";
            this.Text = "Add_Student";
            ((System.ComponentModel.ISupportInitialize)(this.StunumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StunumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StuCLEAR;
        private System.Windows.Forms.Button StuGenerate;
        private System.Windows.Forms.Button StuADD;
        private System.Windows.Forms.ComboBox StucomboBox1;
        private System.Windows.Forms.TextBox StutextBox1;
        private System.Windows.Forms.Label StuSubGroupNo;
        private System.Windows.Forms.Label StuSubgroupID;
        private System.Windows.Forms.Label StuGroupID;
        private System.Windows.Forms.Label StuGroupNo;
        private System.Windows.Forms.Label StuProgramme;
        private System.Windows.Forms.Label StuAcedemicYear;
        private System.Windows.Forms.Button StuLabel1;
        private System.Windows.Forms.Label StuLabl;
        private System.Windows.Forms.Button StuTimeTable;
        private System.Windows.Forms.Button StuStatistics;
        private System.Windows.Forms.Button StuLocations;
        private System.Windows.Forms.Button StuRoom;
        private System.Windows.Forms.Button StuHome;
        private System.Windows.Forms.Button StuTag;
        private System.Windows.Forms.Button StuWorking;
        private System.Windows.Forms.Button StuAdvanced;
        private System.Windows.Forms.Button StuSession;
        private System.Windows.Forms.Button StuSubject;
        private System.Windows.Forms.Button StuStudent;
        private System.Windows.Forms.Button StuLecturer;
        private System.Windows.Forms.TextBox StutextBox2;
        private System.Windows.Forms.TextBox StutextBox3;
        private System.Windows.Forms.NumericUpDown StunumericUpDown1;
        private System.Windows.Forms.NumericUpDown StunumericUpDown2;
        private System.Windows.Forms.Button StuLabel3;
        private System.Windows.Forms.Button StuLabel2;
    }
}