
namespace Project
{
    partial class Add_Tag
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
            this.TagCLEAR = new System.Windows.Forms.Button();
            this.TagADD = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RelatedTag = new System.Windows.Forms.Label();
            this.TagCode = new System.Windows.Forms.Label();
            this.TagName = new System.Windows.Forms.Label();
            this.TagLabel1 = new System.Windows.Forms.Button();
            this.TagLabl = new System.Windows.Forms.Label();
            this.TagTimeTable = new System.Windows.Forms.Button();
            this.TagStatistics = new System.Windows.Forms.Button();
            this.TagLocations = new System.Windows.Forms.Button();
            this.TagRoom = new System.Windows.Forms.Button();
            this.TagHome = new System.Windows.Forms.Button();
            this.TagWorking = new System.Windows.Forms.Button();
            this.TagStudent = new System.Windows.Forms.Button();
            this.TagLecturer = new System.Windows.Forms.Button();
            this.TagSubject = new System.Windows.Forms.Button();
            this.TagSession = new System.Windows.Forms.Button();
            this.TagAdvanced = new System.Windows.Forms.Button();
            this.TagTag = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TagLabel2 = new System.Windows.Forms.Button();
            this.TagLabel3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TagCLEAR
            // 
            this.TagCLEAR.BackColor = System.Drawing.Color.Red;
            this.TagCLEAR.Location = new System.Drawing.Point(644, 543);
            this.TagCLEAR.Name = "TagCLEAR";
            this.TagCLEAR.Size = new System.Drawing.Size(90, 35);
            this.TagCLEAR.TabIndex = 100;
            this.TagCLEAR.Text = "CLEAR";
            this.TagCLEAR.UseVisualStyleBackColor = false;
            this.TagCLEAR.Click += new System.EventHandler(this.TagCLEAR_Click);
            // 
            // TagADD
            // 
            this.TagADD.BackColor = System.Drawing.Color.Blue;
            this.TagADD.Location = new System.Drawing.Point(469, 543);
            this.TagADD.Name = "TagADD";
            this.TagADD.Size = new System.Drawing.Size(90, 35);
            this.TagADD.TabIndex = 98;
            this.TagADD.Text = "ADD";
            this.TagADD.UseVisualStyleBackColor = false;
            this.TagADD.Click += new System.EventHandler(this.TagADD_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lecturer",
            "Tutorial",
            "Lab"});
            this.comboBox1.Location = new System.Drawing.Point(339, 373);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(376, 24);
            this.comboBox1.TabIndex = 97;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 22);
            this.textBox1.TabIndex = 96;
            // 
            // RelatedTag
            // 
            this.RelatedTag.AutoSize = true;
            this.RelatedTag.Location = new System.Drawing.Point(159, 376);
            this.RelatedTag.Name = "RelatedTag";
            this.RelatedTag.Size = new System.Drawing.Size(86, 17);
            this.RelatedTag.TabIndex = 92;
            this.RelatedTag.Text = "Related Tag";
            // 
            // TagCode
            // 
            this.TagCode.AutoSize = true;
            this.TagCode.Location = new System.Drawing.Point(159, 287);
            this.TagCode.Name = "TagCode";
            this.TagCode.Size = new System.Drawing.Size(70, 17);
            this.TagCode.TabIndex = 91;
            this.TagCode.Text = "Tag Code";
            // 
            // TagName
            // 
            this.TagName.AutoSize = true;
            this.TagName.Location = new System.Drawing.Point(159, 197);
            this.TagName.Name = "TagName";
            this.TagName.Size = new System.Drawing.Size(74, 17);
            this.TagName.TabIndex = 90;
            this.TagName.Text = "Tag Name";
            // 
            // TagLabel1
            // 
            this.TagLabel1.BackColor = System.Drawing.Color.Crimson;
            this.TagLabel1.Location = new System.Drawing.Point(124, 91);
            this.TagLabel1.Name = "TagLabel1";
            this.TagLabel1.Size = new System.Drawing.Size(208, 35);
            this.TagLabel1.TabIndex = 89;
            this.TagLabel1.Text = "Add Tag";
            this.TagLabel1.UseVisualStyleBackColor = false;
            this.TagLabel1.Click += new System.EventHandler(this.TagLabel1_Click);
            // 
            // TagLabl
            // 
            this.TagLabl.AutoSize = true;
            this.TagLabl.BackColor = System.Drawing.Color.Blue;
            this.TagLabl.Location = new System.Drawing.Point(33, 40);
            this.TagLabl.Name = "TagLabl";
            this.TagLabl.Size = new System.Drawing.Size(33, 17);
            this.TagLabl.TabIndex = 88;
            this.TagLabl.Text = "Tag";
            // 
            // TagTimeTable
            // 
            this.TagTimeTable.Location = new System.Drawing.Point(729, 12);
            this.TagTimeTable.Name = "TagTimeTable";
            this.TagTimeTable.Size = new System.Drawing.Size(104, 72);
            this.TagTimeTable.TabIndex = 87;
            this.TagTimeTable.Text = "Time Table";
            this.TagTimeTable.UseVisualStyleBackColor = true;
            this.TagTimeTable.Click += new System.EventHandler(this.TagTimeTable_Click);
            // 
            // TagStatistics
            // 
            this.TagStatistics.Location = new System.Drawing.Point(578, 12);
            this.TagStatistics.Name = "TagStatistics";
            this.TagStatistics.Size = new System.Drawing.Size(104, 72);
            this.TagStatistics.TabIndex = 86;
            this.TagStatistics.Text = "Statistics";
            this.TagStatistics.UseVisualStyleBackColor = true;
            this.TagStatistics.Click += new System.EventHandler(this.TagStatistics_Click);
            // 
            // TagLocations
            // 
            this.TagLocations.Location = new System.Drawing.Point(429, 12);
            this.TagLocations.Name = "TagLocations";
            this.TagLocations.Size = new System.Drawing.Size(104, 72);
            this.TagLocations.TabIndex = 85;
            this.TagLocations.Text = "Location";
            this.TagLocations.UseVisualStyleBackColor = true;
            this.TagLocations.Click += new System.EventHandler(this.TagLocations_Click);
            // 
            // TagRoom
            // 
            this.TagRoom.Location = new System.Drawing.Point(271, 12);
            this.TagRoom.Name = "TagRoom";
            this.TagRoom.Size = new System.Drawing.Size(104, 72);
            this.TagRoom.TabIndex = 84;
            this.TagRoom.Text = "Room";
            this.TagRoom.UseVisualStyleBackColor = true;
            this.TagRoom.Click += new System.EventHandler(this.TagRoom_Click);
            // 
            // TagHome
            // 
            this.TagHome.Location = new System.Drawing.Point(123, 12);
            this.TagHome.Name = "TagHome";
            this.TagHome.Size = new System.Drawing.Size(104, 72);
            this.TagHome.TabIndex = 83;
            this.TagHome.Text = "Home";
            this.TagHome.UseVisualStyleBackColor = true;
            this.TagHome.Click += new System.EventHandler(this.TagHome_Click);
            // 
            // TagWorking
            // 
            this.TagWorking.Location = new System.Drawing.Point(14, 559);
            this.TagWorking.Name = "TagWorking";
            this.TagWorking.Size = new System.Drawing.Size(104, 72);
            this.TagWorking.TabIndex = 81;
            this.TagWorking.Text = "Working Days and Hours";
            this.TagWorking.UseVisualStyleBackColor = true;
            this.TagWorking.Click += new System.EventHandler(this.TagWorking_Click);
            // 
            // TagStudent
            // 
            this.TagStudent.Location = new System.Drawing.Point(14, 169);
            this.TagStudent.Name = "TagStudent";
            this.TagStudent.Size = new System.Drawing.Size(104, 72);
            this.TagStudent.TabIndex = 77;
            this.TagStudent.Text = "Student";
            this.TagStudent.UseVisualStyleBackColor = true;
            this.TagStudent.Click += new System.EventHandler(this.TagStudent_Click);
            // 
            // TagLecturer
            // 
            this.TagLecturer.Location = new System.Drawing.Point(14, 91);
            this.TagLecturer.Name = "TagLecturer";
            this.TagLecturer.Size = new System.Drawing.Size(104, 72);
            this.TagLecturer.TabIndex = 76;
            this.TagLecturer.Text = "Lecturer";
            this.TagLecturer.UseVisualStyleBackColor = true;
            this.TagLecturer.Click += new System.EventHandler(this.TagLecturer_Click);
            // 
            // TagSubject
            // 
            this.TagSubject.Location = new System.Drawing.Point(14, 247);
            this.TagSubject.Name = "TagSubject";
            this.TagSubject.Size = new System.Drawing.Size(104, 72);
            this.TagSubject.TabIndex = 78;
            this.TagSubject.Text = "Subject";
            this.TagSubject.UseVisualStyleBackColor = true;
            this.TagSubject.Click += new System.EventHandler(this.TagSubject_Click);
            // 
            // TagSession
            // 
            this.TagSession.Location = new System.Drawing.Point(14, 403);
            this.TagSession.Name = "TagSession";
            this.TagSession.Size = new System.Drawing.Size(104, 72);
            this.TagSession.TabIndex = 79;
            this.TagSession.Text = "Session";
            this.TagSession.UseVisualStyleBackColor = true;
            this.TagSession.Click += new System.EventHandler(this.TagSession_Click);
            // 
            // TagAdvanced
            // 
            this.TagAdvanced.Location = new System.Drawing.Point(14, 481);
            this.TagAdvanced.Name = "TagAdvanced";
            this.TagAdvanced.Size = new System.Drawing.Size(104, 72);
            this.TagAdvanced.TabIndex = 80;
            this.TagAdvanced.Text = "Advanced Session";
            this.TagAdvanced.UseVisualStyleBackColor = true;
            this.TagAdvanced.Click += new System.EventHandler(this.TagAdvanced_Click);
            // 
            // TagTag
            // 
            this.TagTag.Location = new System.Drawing.Point(14, 325);
            this.TagTag.Name = "TagTag";
            this.TagTag.Size = new System.Drawing.Size(104, 72);
            this.TagTag.TabIndex = 82;
            this.TagTag.Text = "Tag";
            this.TagTag.UseVisualStyleBackColor = true;
            this.TagTag.Click += new System.EventHandler(this.TagTag_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(339, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(376, 22);
            this.textBox2.TabIndex = 107;
            // 
            // TagLabel2
            // 
            this.TagLabel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.TagLabel2.Location = new System.Drawing.Point(339, 91);
            this.TagLabel2.Name = "TagLabel2";
            this.TagLabel2.Size = new System.Drawing.Size(208, 35);
            this.TagLabel2.TabIndex = 109;
            this.TagLabel2.Text = "View Tag";
            this.TagLabel2.UseVisualStyleBackColor = false;
            this.TagLabel2.Click += new System.EventHandler(this.TagLabel2_Click_1);
            // 
            // TagLabel3
            // 
            this.TagLabel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.TagLabel3.Location = new System.Drawing.Point(553, 91);
            this.TagLabel3.Name = "TagLabel3";
            this.TagLabel3.Size = new System.Drawing.Size(208, 35);
            this.TagLabel3.TabIndex = 110;
            this.TagLabel3.Text = "Edit Tag";
            this.TagLabel3.UseVisualStyleBackColor = false;
            this.TagLabel3.Click += new System.EventHandler(this.TagLabel3_Click_1);
            // 
            // Add_Tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 643);
            this.Controls.Add(this.TagLabel3);
            this.Controls.Add(this.TagLabel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TagCLEAR);
            this.Controls.Add(this.TagADD);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RelatedTag);
            this.Controls.Add(this.TagCode);
            this.Controls.Add(this.TagName);
            this.Controls.Add(this.TagLabel1);
            this.Controls.Add(this.TagLabl);
            this.Controls.Add(this.TagTimeTable);
            this.Controls.Add(this.TagStatistics);
            this.Controls.Add(this.TagLocations);
            this.Controls.Add(this.TagRoom);
            this.Controls.Add(this.TagHome);
            this.Controls.Add(this.TagTag);
            this.Controls.Add(this.TagWorking);
            this.Controls.Add(this.TagAdvanced);
            this.Controls.Add(this.TagSession);
            this.Controls.Add(this.TagSubject);
            this.Controls.Add(this.TagStudent);
            this.Controls.Add(this.TagLecturer);
            this.Name = "Add_Tag";
            this.Text = "Add_Tag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TagCLEAR;
        private System.Windows.Forms.Button TagADD;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RelatedTag;
        private System.Windows.Forms.Label TagCode;
        private System.Windows.Forms.Label TagName;
        private System.Windows.Forms.Button TagLabel1;
        private System.Windows.Forms.Label TagLabl;
        private System.Windows.Forms.Button TagTimeTable;
        private System.Windows.Forms.Button TagStatistics;
        private System.Windows.Forms.Button TagLocations;
        private System.Windows.Forms.Button TagRoom;
        private System.Windows.Forms.Button TagHome;
        private System.Windows.Forms.Button TagWorking;
        private System.Windows.Forms.Button TagStudent;
        private System.Windows.Forms.Button TagLecturer;
        private System.Windows.Forms.Button TagSubject;
        private System.Windows.Forms.Button TagSession;
        private System.Windows.Forms.Button TagAdvanced;
        private System.Windows.Forms.Button TagTag;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button TagLabel2;
        private System.Windows.Forms.Button TagLabel3;
    }
}