
namespace Project
{
    partial class View_Session
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
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.SesDELETE = new System.Windows.Forms.Button();
            this.SesEDIT = new System.Windows.Forms.Button();
            this.dataGridViewSession = new System.Windows.Forms.DataGridView();
            this.SesLabel3 = new System.Windows.Forms.Button();
            this.SesLabel2 = new System.Windows.Forms.Button();
            this.LLabel1 = new System.Windows.Forms.Button();
            this.SesLabl = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(582, 180);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(295, 22);
            this.textBoxsearch.TabIndex = 73;
            // 
            // SesDELETE
            // 
            this.SesDELETE.BackColor = System.Drawing.Color.Red;
            this.SesDELETE.Location = new System.Drawing.Point(788, 590);
            this.SesDELETE.Name = "SesDELETE";
            this.SesDELETE.Size = new System.Drawing.Size(90, 36);
            this.SesDELETE.TabIndex = 72;
            this.SesDELETE.Text = "DELETE ";
            this.SesDELETE.UseVisualStyleBackColor = false;
            this.SesDELETE.Click += new System.EventHandler(this.SesDELETE_Click);
            // 
            // SesEDIT
            // 
            this.SesEDIT.BackColor = System.Drawing.Color.Green;
            this.SesEDIT.Location = new System.Drawing.Point(692, 590);
            this.SesEDIT.Name = "SesEDIT";
            this.SesEDIT.Size = new System.Drawing.Size(90, 36);
            this.SesEDIT.TabIndex = 71;
            this.SesEDIT.Text = "EDIT ";
            this.SesEDIT.UseVisualStyleBackColor = false;
            this.SesEDIT.Click += new System.EventHandler(this.SesEDIT_Click);
            // 
            // dataGridViewSession
            // 
            this.dataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSession.Location = new System.Drawing.Point(126, 247);
            this.dataGridViewSession.Name = "dataGridViewSession";
            this.dataGridViewSession.RowHeadersWidth = 51;
            this.dataGridViewSession.RowTemplate.Height = 24;
            this.dataGridViewSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSession.Size = new System.Drawing.Size(754, 318);
            this.dataGridViewSession.TabIndex = 70;
            // 
            // SesLabel3
            // 
            this.SesLabel3.BackColor = System.Drawing.Color.Crimson;
            this.SesLabel3.Location = new System.Drawing.Point(550, 91);
            this.SesLabel3.Name = "SesLabel3";
            this.SesLabel3.Size = new System.Drawing.Size(208, 35);
            this.SesLabel3.TabIndex = 69;
            this.SesLabel3.Text = "View Session";
            this.SesLabel3.UseVisualStyleBackColor = false;
            // 
            // SesLabel2
            // 
            this.SesLabel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.SesLabel2.Location = new System.Drawing.Point(336, 90);
            this.SesLabel2.Name = "SesLabel2";
            this.SesLabel2.Size = new System.Drawing.Size(208, 35);
            this.SesLabel2.TabIndex = 68;
            this.SesLabel2.Text = "Edit Session";
            this.SesLabel2.UseVisualStyleBackColor = false;
            // 
            // LLabel1
            // 
            this.LLabel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.LLabel1.Location = new System.Drawing.Point(122, 91);
            this.LLabel1.Name = "LLabel1";
            this.LLabel1.Size = new System.Drawing.Size(208, 35);
            this.LLabel1.TabIndex = 67;
            this.LLabel1.Text = "Add Session";
            this.LLabel1.UseVisualStyleBackColor = false;
            // 
            // SesLabl
            // 
            this.SesLabl.AutoSize = true;
            this.SesLabl.BackColor = System.Drawing.Color.Blue;
            this.SesLabl.Location = new System.Drawing.Point(31, 40);
            this.SesLabl.Name = "SesLabl";
            this.SesLabl.Size = new System.Drawing.Size(58, 17);
            this.SesLabl.TabIndex = 66;
            this.SesLabl.Text = "Session";
            // 
            // LTimeTable
            // 
            this.LTimeTable.Location = new System.Drawing.Point(727, 12);
            this.LTimeTable.Name = "LTimeTable";
            this.LTimeTable.Size = new System.Drawing.Size(104, 72);
            this.LTimeTable.TabIndex = 65;
            this.LTimeTable.Text = "Time Table";
            this.LTimeTable.UseVisualStyleBackColor = true;
            // 
            // LStatistics
            // 
            this.LStatistics.Location = new System.Drawing.Point(576, 12);
            this.LStatistics.Name = "LStatistics";
            this.LStatistics.Size = new System.Drawing.Size(104, 72);
            this.LStatistics.TabIndex = 64;
            this.LStatistics.Text = "Statistics";
            this.LStatistics.UseVisualStyleBackColor = true;
            // 
            // LLocations
            // 
            this.LLocations.Location = new System.Drawing.Point(427, 12);
            this.LLocations.Name = "LLocations";
            this.LLocations.Size = new System.Drawing.Size(104, 72);
            this.LLocations.TabIndex = 63;
            this.LLocations.Text = "Location";
            this.LLocations.UseVisualStyleBackColor = true;
            // 
            // LRoom
            // 
            this.LRoom.Location = new System.Drawing.Point(269, 12);
            this.LRoom.Name = "LRoom";
            this.LRoom.Size = new System.Drawing.Size(104, 72);
            this.LRoom.TabIndex = 62;
            this.LRoom.Text = "Room";
            this.LRoom.UseVisualStyleBackColor = true;
            // 
            // LHome
            // 
            this.LHome.Location = new System.Drawing.Point(121, 12);
            this.LHome.Name = "LHome";
            this.LHome.Size = new System.Drawing.Size(104, 72);
            this.LHome.TabIndex = 61;
            this.LHome.Text = "Home";
            this.LHome.UseVisualStyleBackColor = true;
            // 
            // LTag
            // 
            this.LTag.Location = new System.Drawing.Point(12, 325);
            this.LTag.Name = "LTag";
            this.LTag.Size = new System.Drawing.Size(104, 72);
            this.LTag.TabIndex = 60;
            this.LTag.Text = "Tag";
            this.LTag.UseVisualStyleBackColor = true;
            // 
            // LWorking
            // 
            this.LWorking.Location = new System.Drawing.Point(12, 559);
            this.LWorking.Name = "LWorking";
            this.LWorking.Size = new System.Drawing.Size(104, 72);
            this.LWorking.TabIndex = 59;
            this.LWorking.Text = "Working Days and Hours";
            this.LWorking.UseVisualStyleBackColor = true;
            // 
            // LAdvanced
            // 
            this.LAdvanced.Location = new System.Drawing.Point(12, 481);
            this.LAdvanced.Name = "LAdvanced";
            this.LAdvanced.Size = new System.Drawing.Size(104, 72);
            this.LAdvanced.TabIndex = 58;
            this.LAdvanced.Text = "Advanced Session";
            this.LAdvanced.UseVisualStyleBackColor = true;
            // 
            // LSession
            // 
            this.LSession.Location = new System.Drawing.Point(12, 403);
            this.LSession.Name = "LSession";
            this.LSession.Size = new System.Drawing.Size(104, 72);
            this.LSession.TabIndex = 57;
            this.LSession.Text = "Session";
            this.LSession.UseVisualStyleBackColor = true;
            // 
            // LSubject
            // 
            this.LSubject.Location = new System.Drawing.Point(12, 247);
            this.LSubject.Name = "LSubject";
            this.LSubject.Size = new System.Drawing.Size(104, 72);
            this.LSubject.TabIndex = 56;
            this.LSubject.Text = "Subject";
            this.LSubject.UseVisualStyleBackColor = true;
            // 
            // LStudent
            // 
            this.LStudent.Location = new System.Drawing.Point(12, 169);
            this.LStudent.Name = "LStudent";
            this.LStudent.Size = new System.Drawing.Size(104, 72);
            this.LStudent.TabIndex = 55;
            this.LStudent.Text = "Student";
            this.LStudent.UseVisualStyleBackColor = true;
            // 
            // LLecturer
            // 
            this.LLecturer.Location = new System.Drawing.Point(12, 91);
            this.LLecturer.Name = "LLecturer";
            this.LLecturer.Size = new System.Drawing.Size(104, 72);
            this.LLecturer.TabIndex = 54;
            this.LLecturer.Text = "Lecturer";
            this.LLecturer.UseVisualStyleBackColor = true;
            // 
            // View_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 643);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.SesDELETE);
            this.Controls.Add(this.SesEDIT);
            this.Controls.Add(this.dataGridViewSession);
            this.Controls.Add(this.SesLabel3);
            this.Controls.Add(this.SesLabel2);
            this.Controls.Add(this.LLabel1);
            this.Controls.Add(this.SesLabl);
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
            this.Name = "View_Session";
            this.Text = "View_Session";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Button SesDELETE;
        private System.Windows.Forms.Button SesEDIT;
        private System.Windows.Forms.DataGridView dataGridViewSession;
        private System.Windows.Forms.Button SesLabel3;
        private System.Windows.Forms.Button SesLabel2;
        private System.Windows.Forms.Button LLabel1;
        private System.Windows.Forms.Label SesLabl;
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