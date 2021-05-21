
namespace Project
{
    partial class Add_Location
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
            this.LocACLEAR = new System.Windows.Forms.Button();
            this.LocAADD = new System.Windows.Forms.Button();
            this.LocAcomboBox2 = new System.Windows.Forms.ComboBox();
            this.LocAtextBox1 = new System.Windows.Forms.TextBox();
            this.LocARoomType = new System.Windows.Forms.Label();
            this.LocACapcity = new System.Windows.Forms.Label();
            this.LocARoomName = new System.Windows.Forms.Label();
            this.LocABuilding = new System.Windows.Forms.Label();
            this.LocALabel3 = new System.Windows.Forms.Button();
            this.LocALabel2 = new System.Windows.Forms.Button();
            this.LocALabel1 = new System.Windows.Forms.Button();
            this.LocALabl = new System.Windows.Forms.Label();
            this.LocATimeTable = new System.Windows.Forms.Button();
            this.LocAStatistics = new System.Windows.Forms.Button();
            this.LocALocations = new System.Windows.Forms.Button();
            this.LocARoom = new System.Windows.Forms.Button();
            this.LocAHome = new System.Windows.Forms.Button();
            this.LocATag = new System.Windows.Forms.Button();
            this.LocAWorking = new System.Windows.Forms.Button();
            this.LocAAdvanced = new System.Windows.Forms.Button();
            this.LocASession = new System.Windows.Forms.Button();
            this.LocASubject = new System.Windows.Forms.Button();
            this.LocAStudent = new System.Windows.Forms.Button();
            this.LocALecturer = new System.Windows.Forms.Button();
            this.LocAcomboBox1 = new System.Windows.Forms.ComboBox();
            this.LocAcomboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LocACLEAR
            // 
            this.LocACLEAR.BackColor = System.Drawing.Color.Crimson;
            this.LocACLEAR.Location = new System.Drawing.Point(633, 500);
            this.LocACLEAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocACLEAR.Name = "LocACLEAR";
            this.LocACLEAR.Size = new System.Drawing.Size(91, 34);
            this.LocACLEAR.TabIndex = 69;
            this.LocACLEAR.Text = "CLEAR";
            this.LocACLEAR.UseVisualStyleBackColor = false;
            this.LocACLEAR.Click += new System.EventHandler(this.LocACLEAR_Click);
            // 
            // LocAADD
            // 
            this.LocAADD.BackColor = System.Drawing.Color.Blue;
            this.LocAADD.Location = new System.Drawing.Point(511, 500);
            this.LocAADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocAADD.Name = "LocAADD";
            this.LocAADD.Size = new System.Drawing.Size(91, 34);
            this.LocAADD.TabIndex = 67;
            this.LocAADD.Text = "ADD";
            this.LocAADD.UseVisualStyleBackColor = false;
            this.LocAADD.Click += new System.EventHandler(this.LocAADD_Click);
            // 
            // LocAcomboBox2
            // 
            this.LocAcomboBox2.FormattingEnabled = true;
            this.LocAcomboBox2.Items.AddRange(new object[] {
            "60",
            "100",
            "120",
            "150"});
            this.LocAcomboBox2.Location = new System.Drawing.Point(348, 325);
            this.LocAcomboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocAcomboBox2.Name = "LocAcomboBox2";
            this.LocAcomboBox2.Size = new System.Drawing.Size(375, 24);
            this.LocAcomboBox2.TabIndex = 61;
            // 
            // LocAtextBox1
            // 
            this.LocAtextBox1.Location = new System.Drawing.Point(347, 247);
            this.LocAtextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocAtextBox1.Name = "LocAtextBox1";
            this.LocAtextBox1.Size = new System.Drawing.Size(376, 22);
            this.LocAtextBox1.TabIndex = 60;
            // 
            // LocARoomType
            // 
            this.LocARoomType.AutoSize = true;
            this.LocARoomType.Location = new System.Drawing.Point(169, 406);
            this.LocARoomType.Name = "LocARoomType";
            this.LocARoomType.Size = new System.Drawing.Size(76, 17);
            this.LocARoomType.TabIndex = 58;
            this.LocARoomType.Text = "Room type";
            // 
            // LocACapcity
            // 
            this.LocACapcity.AutoSize = true;
            this.LocACapcity.Location = new System.Drawing.Point(169, 327);
            this.LocACapcity.Name = "LocACapcity";
            this.LocACapcity.Size = new System.Drawing.Size(62, 17);
            this.LocACapcity.TabIndex = 53;
            this.LocACapcity.Text = "Capacity";
            // 
            // LocARoomName
            // 
            this.LocARoomName.AutoSize = true;
            this.LocARoomName.Location = new System.Drawing.Point(169, 250);
            this.LocARoomName.Name = "LocARoomName";
            this.LocARoomName.Size = new System.Drawing.Size(86, 17);
            this.LocARoomName.TabIndex = 52;
            this.LocARoomName.Text = "Room Name";
            // 
            // LocABuilding
            // 
            this.LocABuilding.AutoSize = true;
            this.LocABuilding.Location = new System.Drawing.Point(169, 172);
            this.LocABuilding.Name = "LocABuilding";
            this.LocABuilding.Size = new System.Drawing.Size(99, 17);
            this.LocABuilding.TabIndex = 51;
            this.LocABuilding.Text = "Building Name";
            // 
            // LocALabel3
            // 
            this.LocALabel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.LocALabel3.Location = new System.Drawing.Point(563, 91);
            this.LocALabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocALabel3.Name = "LocALabel3";
            this.LocALabel3.Size = new System.Drawing.Size(208, 34);
            this.LocALabel3.TabIndex = 50;
            this.LocALabel3.Text = "View Location";
            this.LocALabel3.UseVisualStyleBackColor = false;
            this.LocALabel3.Click += new System.EventHandler(this.LocALabel3_Click);
            // 
            // LocALabel2
            // 
            this.LocALabel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.LocALabel2.Location = new System.Drawing.Point(348, 90);
            this.LocALabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocALabel2.Name = "LocALabel2";
            this.LocALabel2.Size = new System.Drawing.Size(208, 34);
            this.LocALabel2.TabIndex = 49;
            this.LocALabel2.Text = "Edit Location";
            this.LocALabel2.UseVisualStyleBackColor = false;
            this.LocALabel2.Click += new System.EventHandler(this.LocALabel2_Click);
            // 
            // LocALabel1
            // 
            this.LocALabel1.BackColor = System.Drawing.Color.Crimson;
            this.LocALabel1.Location = new System.Drawing.Point(133, 91);
            this.LocALabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocALabel1.Name = "LocALabel1";
            this.LocALabel1.Size = new System.Drawing.Size(208, 34);
            this.LocALabel1.TabIndex = 48;
            this.LocALabel1.Text = "Add Location";
            this.LocALabel1.UseVisualStyleBackColor = false;
            // 
            // LocALabl
            // 
            this.LocALabl.AutoSize = true;
            this.LocALabl.BackColor = System.Drawing.Color.Blue;
            this.LocALabl.Location = new System.Drawing.Point(43, 39);
            this.LocALabl.Name = "LocALabl";
            this.LocALabl.Size = new System.Drawing.Size(62, 17);
            this.LocALabl.TabIndex = 47;
            this.LocALabl.Text = "Location";
            // 
            // LocATimeTable
            // 
            this.LocATimeTable.Location = new System.Drawing.Point(739, 12);
            this.LocATimeTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocATimeTable.Name = "LocATimeTable";
            this.LocATimeTable.Size = new System.Drawing.Size(104, 71);
            this.LocATimeTable.TabIndex = 46;
            this.LocATimeTable.Text = "Time Table";
            this.LocATimeTable.UseVisualStyleBackColor = true;
            this.LocATimeTable.Click += new System.EventHandler(this.LocATimeTable_Click);
            // 
            // LocAStatistics
            // 
            this.LocAStatistics.Location = new System.Drawing.Point(588, 12);
            this.LocAStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocAStatistics.Name = "LocAStatistics";
            this.LocAStatistics.Size = new System.Drawing.Size(104, 71);
            this.LocAStatistics.TabIndex = 45;
            this.LocAStatistics.Text = "Statistics";
            this.LocAStatistics.UseVisualStyleBackColor = true;
            this.LocAStatistics.Click += new System.EventHandler(this.LocAStatistics_Click);
            // 
            // LocALocations
            // 
            this.LocALocations.Location = new System.Drawing.Point(439, 12);
            this.LocALocations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocALocations.Name = "LocALocations";
            this.LocALocations.Size = new System.Drawing.Size(104, 71);
            this.LocALocations.TabIndex = 44;
            this.LocALocations.Text = "Location";
            this.LocALocations.UseVisualStyleBackColor = true;
            this.LocALocations.Click += new System.EventHandler(this.LocALocations_Click);
            // 
            // LocARoom
            // 
            this.LocARoom.Location = new System.Drawing.Point(281, 12);
            this.LocARoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocARoom.Name = "LocARoom";
            this.LocARoom.Size = new System.Drawing.Size(104, 71);
            this.LocARoom.TabIndex = 43;
            this.LocARoom.Text = "Room";
            this.LocARoom.UseVisualStyleBackColor = true;
            this.LocARoom.Click += new System.EventHandler(this.LocARoom_Click);
            // 
            // LocAHome
            // 
            this.LocAHome.Location = new System.Drawing.Point(133, 12);
            this.LocAHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocAHome.Name = "LocAHome";
            this.LocAHome.Size = new System.Drawing.Size(104, 71);
            this.LocAHome.TabIndex = 42;
            this.LocAHome.Text = "Home";
            this.LocAHome.UseVisualStyleBackColor = true;
            this.LocAHome.Click += new System.EventHandler(this.LocAHome_Click);
            // 
            // LocATag
            // 
            this.LocATag.Location = new System.Drawing.Point(24, 325);
            this.LocATag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocATag.Name = "LocATag";
            this.LocATag.Size = new System.Drawing.Size(104, 71);
            this.LocATag.TabIndex = 41;
            this.LocATag.Text = "Tag";
            this.LocATag.UseVisualStyleBackColor = true;
            this.LocATag.Click += new System.EventHandler(this.LocATag_Click);
            // 
            // LocAWorking
            // 
            this.LocAWorking.Location = new System.Drawing.Point(24, 559);
            this.LocAWorking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocAWorking.Name = "LocAWorking";
            this.LocAWorking.Size = new System.Drawing.Size(104, 71);
            this.LocAWorking.TabIndex = 40;
            this.LocAWorking.Text = "Working Days and Hours";
            this.LocAWorking.UseVisualStyleBackColor = true;
            this.LocAWorking.Click += new System.EventHandler(this.LocAWorking_Click);
            // 
            // LocAAdvanced
            // 
            this.LocAAdvanced.Location = new System.Drawing.Point(24, 481);
            this.LocAAdvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocAAdvanced.Name = "LocAAdvanced";
            this.LocAAdvanced.Size = new System.Drawing.Size(104, 71);
            this.LocAAdvanced.TabIndex = 39;
            this.LocAAdvanced.Text = "Advanced Session";
            this.LocAAdvanced.UseVisualStyleBackColor = true;
            this.LocAAdvanced.Click += new System.EventHandler(this.LocAAdvanced_Click);
            // 
            // LocASession
            // 
            this.LocASession.Location = new System.Drawing.Point(24, 402);
            this.LocASession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocASession.Name = "LocASession";
            this.LocASession.Size = new System.Drawing.Size(104, 71);
            this.LocASession.TabIndex = 38;
            this.LocASession.Text = "Session";
            this.LocASession.UseVisualStyleBackColor = true;
            this.LocASession.Click += new System.EventHandler(this.LocASession_Click);
            // 
            // LocASubject
            // 
            this.LocASubject.Location = new System.Drawing.Point(24, 247);
            this.LocASubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocASubject.Name = "LocASubject";
            this.LocASubject.Size = new System.Drawing.Size(104, 71);
            this.LocASubject.TabIndex = 37;
            this.LocASubject.Text = "Subject";
            this.LocASubject.UseVisualStyleBackColor = true;
            this.LocASubject.Click += new System.EventHandler(this.LocASubject_Click);
            // 
            // LocAStudent
            // 
            this.LocAStudent.Location = new System.Drawing.Point(24, 169);
            this.LocAStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocAStudent.Name = "LocAStudent";
            this.LocAStudent.Size = new System.Drawing.Size(104, 71);
            this.LocAStudent.TabIndex = 36;
            this.LocAStudent.Text = "Student";
            this.LocAStudent.UseVisualStyleBackColor = true;
            this.LocAStudent.Click += new System.EventHandler(this.LocAStudent_Click);
            // 
            // LocALecturer
            // 
            this.LocALecturer.Location = new System.Drawing.Point(24, 91);
            this.LocALecturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocALecturer.Name = "LocALecturer";
            this.LocALecturer.Size = new System.Drawing.Size(104, 71);
            this.LocALecturer.TabIndex = 35;
            this.LocALecturer.Text = "Lecturer";
            this.LocALecturer.UseVisualStyleBackColor = true;
            this.LocALecturer.Click += new System.EventHandler(this.LocALecturer_Click);
            // 
            // LocAcomboBox1
            // 
            this.LocAcomboBox1.FormattingEnabled = true;
            this.LocAcomboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.LocAcomboBox1.Location = new System.Drawing.Point(347, 169);
            this.LocAcomboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocAcomboBox1.Name = "LocAcomboBox1";
            this.LocAcomboBox1.Size = new System.Drawing.Size(375, 24);
            this.LocAcomboBox1.TabIndex = 71;
            // 
            // LocAcomboBox3
            // 
            this.LocAcomboBox3.FormattingEnabled = true;
            this.LocAcomboBox3.Items.AddRange(new object[] {
            "Lecture  Hall",
            "Labarotary"});
            this.LocAcomboBox3.Location = new System.Drawing.Point(347, 402);
            this.LocAcomboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocAcomboBox3.Name = "LocAcomboBox3";
            this.LocAcomboBox3.Size = new System.Drawing.Size(375, 24);
            this.LocAcomboBox3.TabIndex = 70;
            // 
            // Add_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 642);
            this.Controls.Add(this.LocAcomboBox1);
            this.Controls.Add(this.LocAcomboBox3);
            this.Controls.Add(this.LocACLEAR);
            this.Controls.Add(this.LocAADD);
            this.Controls.Add(this.LocAcomboBox2);
            this.Controls.Add(this.LocAtextBox1);
            this.Controls.Add(this.LocARoomType);
            this.Controls.Add(this.LocACapcity);
            this.Controls.Add(this.LocARoomName);
            this.Controls.Add(this.LocABuilding);
            this.Controls.Add(this.LocALabel3);
            this.Controls.Add(this.LocALabel2);
            this.Controls.Add(this.LocALabel1);
            this.Controls.Add(this.LocALabl);
            this.Controls.Add(this.LocATimeTable);
            this.Controls.Add(this.LocAStatistics);
            this.Controls.Add(this.LocALocations);
            this.Controls.Add(this.LocARoom);
            this.Controls.Add(this.LocAHome);
            this.Controls.Add(this.LocATag);
            this.Controls.Add(this.LocAWorking);
            this.Controls.Add(this.LocAAdvanced);
            this.Controls.Add(this.LocASession);
            this.Controls.Add(this.LocASubject);
            this.Controls.Add(this.LocAStudent);
            this.Controls.Add(this.LocALecturer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_Location";
            this.Text = "Add_Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LocACLEAR;
        private System.Windows.Forms.Button LocAADD;
        private System.Windows.Forms.ComboBox LocAcomboBox2;
        private System.Windows.Forms.TextBox LocAtextBox1;
        private System.Windows.Forms.Label LocARoomType;
        private System.Windows.Forms.Label LocACapcity;
        private System.Windows.Forms.Label LocARoomName;
        private System.Windows.Forms.Label LocABuilding;
        private System.Windows.Forms.Button LocALabel3;
        private System.Windows.Forms.Button LocALabel2;
        private System.Windows.Forms.Button LocALabel1;
        private System.Windows.Forms.Label LocALabl;
        private System.Windows.Forms.Button LocATimeTable;
        private System.Windows.Forms.Button LocAStatistics;
        private System.Windows.Forms.Button LocALocations;
        private System.Windows.Forms.Button LocARoom;
        private System.Windows.Forms.Button LocAHome;
        private System.Windows.Forms.Button LocATag;
        private System.Windows.Forms.Button LocAWorking;
        private System.Windows.Forms.Button LocAAdvanced;
        private System.Windows.Forms.Button LocASession;
        private System.Windows.Forms.Button LocASubject;
        private System.Windows.Forms.Button LocAStudent;
        private System.Windows.Forms.Button LocALecturer;
        private System.Windows.Forms.ComboBox LocAcomboBox1;
        private System.Windows.Forms.ComboBox LocAcomboBox3;
    }
}