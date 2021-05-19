
namespace Project
{
    partial class Delete_Session
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
            this.SesDeleteLecturerlabel = new System.Windows.Forms.TextBox();
            this.SescomboBoxLecturerID = new System.Windows.Forms.ComboBox();
            this.SesbuttonDelete = new System.Windows.Forms.Button();
            this.SesLabel3 = new System.Windows.Forms.Button();
            this.SesLabel2 = new System.Windows.Forms.Button();
            this.SesLabel1 = new System.Windows.Forms.Button();
            this.Seslab = new System.Windows.Forms.Label();
            this.LTimeTable = new System.Windows.Forms.Button();
            this.LStatistics = new System.Windows.Forms.Button();
            this.LLocations = new System.Windows.Forms.Button();
            this.LRoom = new System.Windows.Forms.Button();
            this.LHome = new System.Windows.Forms.Button();
            this.LTag = new System.Windows.Forms.Button();
            this.LWorking = new System.Windows.Forms.Button();
            this.LAdvanced = new System.Windows.Forms.Button();
            this.LSession = new System.Windows.Forms.Button();
            this.LSubject = new System.Windows.Forms.Button();
            this.LStudent = new System.Windows.Forms.Button();
            this.LLecturer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SesDeleteLecturerlabel
            // 
            this.SesDeleteLecturerlabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SesDeleteLecturerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SesDeleteLecturerlabel.ForeColor = System.Drawing.Color.White;
            this.SesDeleteLecturerlabel.Location = new System.Drawing.Point(179, 169);
            this.SesDeleteLecturerlabel.Name = "SesDeleteLecturerlabel";
            this.SesDeleteLecturerlabel.Size = new System.Drawing.Size(484, 34);
            this.SesDeleteLecturerlabel.TabIndex = 103;
            this.SesDeleteLecturerlabel.Text = "Enter the Lecturer Table ID for Delete details";
            // 
            // SescomboBoxLecturerID
            // 
            this.SescomboBoxLecturerID.FormattingEnabled = true;
            this.SescomboBoxLecturerID.Location = new System.Drawing.Point(179, 257);
            this.SescomboBoxLecturerID.Name = "SescomboBoxLecturerID";
            this.SescomboBoxLecturerID.Size = new System.Drawing.Size(439, 24);
            this.SescomboBoxLecturerID.TabIndex = 102;
            // 
            // SesbuttonDelete
            // 
            this.SesbuttonDelete.BackColor = System.Drawing.Color.Red;
            this.SesbuttonDelete.Location = new System.Drawing.Point(649, 247);
            this.SesbuttonDelete.Name = "SesbuttonDelete";
            this.SesbuttonDelete.Size = new System.Drawing.Size(90, 35);
            this.SesbuttonDelete.TabIndex = 101;
            this.SesbuttonDelete.Text = "DELETE";
            this.SesbuttonDelete.UseVisualStyleBackColor = false;
            this.SesbuttonDelete.Click += new System.EventHandler(this.SesbuttonDelete_Click);
            // 
            // SesLabel3
            // 
            this.SesLabel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.SesLabel3.Location = new System.Drawing.Point(558, 91);
            this.SesLabel3.Name = "SesLabel3";
            this.SesLabel3.Size = new System.Drawing.Size(208, 35);
            this.SesLabel3.TabIndex = 100;
            this.SesLabel3.Text = "View Session";
            this.SesLabel3.UseVisualStyleBackColor = false;
            // 
            // SesLabel2
            // 
            this.SesLabel2.BackColor = System.Drawing.Color.Crimson;
            this.SesLabel2.Location = new System.Drawing.Point(344, 90);
            this.SesLabel2.Name = "SesLabel2";
            this.SesLabel2.Size = new System.Drawing.Size(208, 35);
            this.SesLabel2.TabIndex = 99;
            this.SesLabel2.Text = "Edit Session";
            this.SesLabel2.UseVisualStyleBackColor = false;
            // 
            // SesLabel1
            // 
            this.SesLabel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.SesLabel1.Location = new System.Drawing.Point(130, 91);
            this.SesLabel1.Name = "SesLabel1";
            this.SesLabel1.Size = new System.Drawing.Size(208, 35);
            this.SesLabel1.TabIndex = 98;
            this.SesLabel1.Text = "Add Session";
            this.SesLabel1.UseVisualStyleBackColor = false;
            // 
            // Seslab
            // 
            this.Seslab.AutoSize = true;
            this.Seslab.BackColor = System.Drawing.Color.Blue;
            this.Seslab.Location = new System.Drawing.Point(39, 40);
            this.Seslab.Name = "Seslab";
            this.Seslab.Size = new System.Drawing.Size(58, 17);
            this.Seslab.TabIndex = 97;
            this.Seslab.Text = "Session";
            // 
            // LTimeTable
            // 
            this.LTimeTable.Location = new System.Drawing.Point(735, 12);
            this.LTimeTable.Name = "LTimeTable";
            this.LTimeTable.Size = new System.Drawing.Size(104, 72);
            this.LTimeTable.TabIndex = 96;
            this.LTimeTable.Text = "Time Table";
            this.LTimeTable.UseVisualStyleBackColor = true;
            // 
            // LStatistics
            // 
            this.LStatistics.Location = new System.Drawing.Point(584, 12);
            this.LStatistics.Name = "LStatistics";
            this.LStatistics.Size = new System.Drawing.Size(104, 72);
            this.LStatistics.TabIndex = 95;
            this.LStatistics.Text = "Statistics";
            this.LStatistics.UseVisualStyleBackColor = true;
            // 
            // LLocations
            // 
            this.LLocations.Location = new System.Drawing.Point(435, 12);
            this.LLocations.Name = "LLocations";
            this.LLocations.Size = new System.Drawing.Size(104, 72);
            this.LLocations.TabIndex = 94;
            this.LLocations.Text = "Location";
            this.LLocations.UseVisualStyleBackColor = true;
            // 
            // LRoom
            // 
            this.LRoom.Location = new System.Drawing.Point(277, 12);
            this.LRoom.Name = "LRoom";
            this.LRoom.Size = new System.Drawing.Size(104, 72);
            this.LRoom.TabIndex = 93;
            this.LRoom.Text = "Room";
            this.LRoom.UseVisualStyleBackColor = true;
            // 
            // LHome
            // 
            this.LHome.Location = new System.Drawing.Point(129, 12);
            this.LHome.Name = "LHome";
            this.LHome.Size = new System.Drawing.Size(104, 72);
            this.LHome.TabIndex = 92;
            this.LHome.Text = "Home";
            this.LHome.UseVisualStyleBackColor = true;
            // 
            // LTag
            // 
            this.LTag.Location = new System.Drawing.Point(20, 325);
            this.LTag.Name = "LTag";
            this.LTag.Size = new System.Drawing.Size(104, 72);
            this.LTag.TabIndex = 91;
            this.LTag.Text = "Tag";
            this.LTag.UseVisualStyleBackColor = true;
            // 
            // LWorking
            // 
            this.LWorking.Location = new System.Drawing.Point(20, 559);
            this.LWorking.Name = "LWorking";
            this.LWorking.Size = new System.Drawing.Size(104, 72);
            this.LWorking.TabIndex = 90;
            this.LWorking.Text = "Working Days and Hours";
            this.LWorking.UseVisualStyleBackColor = true;
            // 
            // LAdvanced
            // 
            this.LAdvanced.Location = new System.Drawing.Point(20, 481);
            this.LAdvanced.Name = "LAdvanced";
            this.LAdvanced.Size = new System.Drawing.Size(104, 72);
            this.LAdvanced.TabIndex = 89;
            this.LAdvanced.Text = "Advanced Session";
            this.LAdvanced.UseVisualStyleBackColor = true;
            // 
            // LSession
            // 
            this.LSession.Location = new System.Drawing.Point(20, 403);
            this.LSession.Name = "LSession";
            this.LSession.Size = new System.Drawing.Size(104, 72);
            this.LSession.TabIndex = 88;
            this.LSession.Text = "Session";
            this.LSession.UseVisualStyleBackColor = true;
            // 
            // LSubject
            // 
            this.LSubject.Location = new System.Drawing.Point(20, 247);
            this.LSubject.Name = "LSubject";
            this.LSubject.Size = new System.Drawing.Size(104, 72);
            this.LSubject.TabIndex = 87;
            this.LSubject.Text = "Subject";
            this.LSubject.UseVisualStyleBackColor = true;
            // 
            // LStudent
            // 
            this.LStudent.Location = new System.Drawing.Point(20, 169);
            this.LStudent.Name = "LStudent";
            this.LStudent.Size = new System.Drawing.Size(104, 72);
            this.LStudent.TabIndex = 86;
            this.LStudent.Text = "Student";
            this.LStudent.UseVisualStyleBackColor = true;
            // 
            // LLecturer
            // 
            this.LLecturer.Location = new System.Drawing.Point(20, 91);
            this.LLecturer.Name = "LLecturer";
            this.LLecturer.Size = new System.Drawing.Size(104, 72);
            this.LLecturer.TabIndex = 85;
            this.LLecturer.Text = "Lecturer";
            this.LLecturer.UseVisualStyleBackColor = true;
            // 
            // Delete_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 643);
            this.Controls.Add(this.SesDeleteLecturerlabel);
            this.Controls.Add(this.SescomboBoxLecturerID);
            this.Controls.Add(this.SesbuttonDelete);
            this.Controls.Add(this.SesLabel3);
            this.Controls.Add(this.SesLabel2);
            this.Controls.Add(this.SesLabel1);
            this.Controls.Add(this.Seslab);
            this.Controls.Add(this.LTimeTable);
            this.Controls.Add(this.LStatistics);
            this.Controls.Add(this.LLocations);
            this.Controls.Add(this.LRoom);
            this.Controls.Add(this.LHome);
            this.Controls.Add(this.LTag);
            this.Controls.Add(this.LWorking);
            this.Controls.Add(this.LAdvanced);
            this.Controls.Add(this.LSession);
            this.Controls.Add(this.LSubject);
            this.Controls.Add(this.LStudent);
            this.Controls.Add(this.LLecturer);
            this.Name = "Delete_Session";
            this.Text = "Delete_Session";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SesDeleteLecturerlabel;
        private System.Windows.Forms.ComboBox SescomboBoxLecturerID;
        private System.Windows.Forms.Button SesbuttonDelete;
        private System.Windows.Forms.Button SesLabel3;
        private System.Windows.Forms.Button SesLabel2;
        private System.Windows.Forms.Button SesLabel1;
        private System.Windows.Forms.Label Seslab;
        private System.Windows.Forms.Button LTimeTable;
        private System.Windows.Forms.Button LStatistics;
        private System.Windows.Forms.Button LLocations;
        private System.Windows.Forms.Button LRoom;
        private System.Windows.Forms.Button LHome;
        private System.Windows.Forms.Button LTag;
        private System.Windows.Forms.Button LWorking;
        private System.Windows.Forms.Button LAdvanced;
        private System.Windows.Forms.Button LSession;
        private System.Windows.Forms.Button LSubject;
        private System.Windows.Forms.Button LStudent;
        private System.Windows.Forms.Button LLecturer;
    }
}