
namespace Project
{
    partial class View_Lecturer
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
            this.LLecturer = new System.Windows.Forms.Button();
            this.LStudent = new System.Windows.Forms.Button();
            this.LSubject = new System.Windows.Forms.Button();
            this.LSession = new System.Windows.Forms.Button();
            this.LAdvanced = new System.Windows.Forms.Button();
            this.LWorking = new System.Windows.Forms.Button();
            this.LTag = new System.Windows.Forms.Button();
            this.LHome = new System.Windows.Forms.Button();
            this.LRoom = new System.Windows.Forms.Button();
            this.LLocations = new System.Windows.Forms.Button();
            this.LStatistics = new System.Windows.Forms.Button();
            this.LTimeTable = new System.Windows.Forms.Button();
            this.LLabl = new System.Windows.Forms.Label();
            this.LLabel1 = new System.Windows.Forms.Button();
            this.LLabel2 = new System.Windows.Forms.Button();
            this.LLabel3 = new System.Windows.Forms.Button();
            this.dataGridViewLecturer = new System.Windows.Forms.DataGridView();
            this.LDELETE = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.LEDIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // LLecturer
            // 
            this.LLecturer.Location = new System.Drawing.Point(12, 93);
            this.LLecturer.Name = "LLecturer";
            this.LLecturer.Size = new System.Drawing.Size(104, 72);
            this.LLecturer.TabIndex = 34;
            this.LLecturer.Text = "Lecturer";
            this.LLecturer.UseVisualStyleBackColor = true;
            // 
            // LStudent
            // 
            this.LStudent.Location = new System.Drawing.Point(12, 171);
            this.LStudent.Name = "LStudent";
            this.LStudent.Size = new System.Drawing.Size(104, 72);
            this.LStudent.TabIndex = 35;
            this.LStudent.Text = "Student";
            this.LStudent.UseVisualStyleBackColor = true;
            this.LStudent.Click += new System.EventHandler(this.LStudent_Click);
            // 
            // LSubject
            // 
            this.LSubject.Location = new System.Drawing.Point(12, 249);
            this.LSubject.Name = "LSubject";
            this.LSubject.Size = new System.Drawing.Size(104, 72);
            this.LSubject.TabIndex = 36;
            this.LSubject.Text = "Subject";
            this.LSubject.UseVisualStyleBackColor = true;
            this.LSubject.Click += new System.EventHandler(this.LSubject_Click);
            // 
            // LSession
            // 
            this.LSession.Location = new System.Drawing.Point(12, 405);
            this.LSession.Name = "LSession";
            this.LSession.Size = new System.Drawing.Size(104, 72);
            this.LSession.TabIndex = 37;
            this.LSession.Text = "Session";
            this.LSession.UseVisualStyleBackColor = true;
            this.LSession.Click += new System.EventHandler(this.LSession_Click);
            // 
            // LAdvanced
            // 
            this.LAdvanced.Location = new System.Drawing.Point(12, 483);
            this.LAdvanced.Name = "LAdvanced";
            this.LAdvanced.Size = new System.Drawing.Size(104, 72);
            this.LAdvanced.TabIndex = 38;
            this.LAdvanced.Text = "Advanced Session";
            this.LAdvanced.UseVisualStyleBackColor = true;
            this.LAdvanced.Click += new System.EventHandler(this.LAdvanced_Click);
            // 
            // LWorking
            // 
            this.LWorking.Location = new System.Drawing.Point(12, 561);
            this.LWorking.Name = "LWorking";
            this.LWorking.Size = new System.Drawing.Size(104, 72);
            this.LWorking.TabIndex = 39;
            this.LWorking.Text = "Working Days and Hours";
            this.LWorking.UseVisualStyleBackColor = true;
            this.LWorking.Click += new System.EventHandler(this.LWorking_Click);
            // 
            // LTag
            // 
            this.LTag.Location = new System.Drawing.Point(12, 327);
            this.LTag.Name = "LTag";
            this.LTag.Size = new System.Drawing.Size(104, 72);
            this.LTag.TabIndex = 40;
            this.LTag.Text = "Tag";
            this.LTag.UseVisualStyleBackColor = true;
            this.LTag.Click += new System.EventHandler(this.LTag_Click);
            // 
            // LHome
            // 
            this.LHome.Location = new System.Drawing.Point(121, 14);
            this.LHome.Name = "LHome";
            this.LHome.Size = new System.Drawing.Size(104, 72);
            this.LHome.TabIndex = 41;
            this.LHome.Text = "Home";
            this.LHome.UseVisualStyleBackColor = true;
            this.LHome.Click += new System.EventHandler(this.LHome_Click);
            // 
            // LRoom
            // 
            this.LRoom.Location = new System.Drawing.Point(269, 14);
            this.LRoom.Name = "LRoom";
            this.LRoom.Size = new System.Drawing.Size(104, 72);
            this.LRoom.TabIndex = 42;
            this.LRoom.Text = "Room";
            this.LRoom.UseVisualStyleBackColor = true;
            this.LRoom.Click += new System.EventHandler(this.LRoom_Click);
            // 
            // LLocations
            // 
            this.LLocations.Location = new System.Drawing.Point(427, 14);
            this.LLocations.Name = "LLocations";
            this.LLocations.Size = new System.Drawing.Size(104, 72);
            this.LLocations.TabIndex = 43;
            this.LLocations.Text = "Location";
            this.LLocations.UseVisualStyleBackColor = true;
            this.LLocations.Click += new System.EventHandler(this.LLocations_Click);
            // 
            // LStatistics
            // 
            this.LStatistics.Location = new System.Drawing.Point(576, 14);
            this.LStatistics.Name = "LStatistics";
            this.LStatistics.Size = new System.Drawing.Size(104, 72);
            this.LStatistics.TabIndex = 44;
            this.LStatistics.Text = "Statistics";
            this.LStatistics.UseVisualStyleBackColor = true;
            this.LStatistics.Click += new System.EventHandler(this.LStatistics_Click);
            // 
            // LTimeTable
            // 
            this.LTimeTable.Location = new System.Drawing.Point(727, 14);
            this.LTimeTable.Name = "LTimeTable";
            this.LTimeTable.Size = new System.Drawing.Size(104, 72);
            this.LTimeTable.TabIndex = 45;
            this.LTimeTable.Text = "Time Table";
            this.LTimeTable.UseVisualStyleBackColor = true;
            this.LTimeTable.Click += new System.EventHandler(this.LTimeTable_Click);
            // 
            // LLabl
            // 
            this.LLabl.AutoSize = true;
            this.LLabl.BackColor = System.Drawing.Color.Blue;
            this.LLabl.Location = new System.Drawing.Point(31, 42);
            this.LLabl.Name = "LLabl";
            this.LLabl.Size = new System.Drawing.Size(61, 17);
            this.LLabl.TabIndex = 46;
            this.LLabl.Text = "Lecturer";
            // 
            // LLabel1
            // 
            this.LLabel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.LLabel1.Location = new System.Drawing.Point(122, 93);
            this.LLabel1.Name = "LLabel1";
            this.LLabel1.Size = new System.Drawing.Size(208, 35);
            this.LLabel1.TabIndex = 47;
            this.LLabel1.Text = "Add Lecturer";
            this.LLabel1.UseVisualStyleBackColor = false;
            this.LLabel1.Click += new System.EventHandler(this.LLabel1_Click);
            // 
            // LLabel2
            // 
            this.LLabel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.LLabel2.Location = new System.Drawing.Point(336, 92);
            this.LLabel2.Name = "LLabel2";
            this.LLabel2.Size = new System.Drawing.Size(208, 35);
            this.LLabel2.TabIndex = 48;
            this.LLabel2.Text = "Edit Lecturer";
            this.LLabel2.UseVisualStyleBackColor = false;
            this.LLabel2.Click += new System.EventHandler(this.LLabel2_Click);
            // 
            // LLabel3
            // 
            this.LLabel3.BackColor = System.Drawing.Color.Crimson;
            this.LLabel3.Location = new System.Drawing.Point(550, 93);
            this.LLabel3.Name = "LLabel3";
            this.LLabel3.Size = new System.Drawing.Size(208, 35);
            this.LLabel3.TabIndex = 49;
            this.LLabel3.Text = "View Lecturer";
            this.LLabel3.UseVisualStyleBackColor = false;
            // 
            // dataGridViewLecturer
            // 
            this.dataGridViewLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturer.Location = new System.Drawing.Point(126, 249);
            this.dataGridViewLecturer.Name = "dataGridViewLecturer";
            this.dataGridViewLecturer.RowHeadersWidth = 51;
            this.dataGridViewLecturer.RowTemplate.Height = 24;
            this.dataGridViewLecturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLecturer.Size = new System.Drawing.Size(754, 318);
            this.dataGridViewLecturer.TabIndex = 50;
            this.dataGridViewLecturer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LDELETE
            // 
            this.LDELETE.BackColor = System.Drawing.Color.Red;
            this.LDELETE.Location = new System.Drawing.Point(788, 592);
            this.LDELETE.Name = "LDELETE";
            this.LDELETE.Size = new System.Drawing.Size(90, 36);
            this.LDELETE.TabIndex = 52;
            this.LDELETE.Text = "DELETE ";
            this.LDELETE.UseVisualStyleBackColor = false;
            this.LDELETE.Click += new System.EventHandler(this.LDELETE_Click_1);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(582, 182);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(295, 22);
            this.textBoxsearch.TabIndex = 53;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // LEDIT
            // 
            this.LEDIT.BackColor = System.Drawing.Color.Green;
            this.LEDIT.Location = new System.Drawing.Point(692, 592);
            this.LEDIT.Name = "LEDIT";
            this.LEDIT.Size = new System.Drawing.Size(90, 36);
            this.LEDIT.TabIndex = 51;
            this.LEDIT.Text = "EDIT ";
            this.LEDIT.UseVisualStyleBackColor = false;
            this.LEDIT.Click += new System.EventHandler(this.LEDIT_Click);
            // 
            // View_Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 643);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.LDELETE);
            this.Controls.Add(this.LEDIT);
            this.Controls.Add(this.dataGridViewLecturer);
            this.Controls.Add(this.LLabel3);
            this.Controls.Add(this.LLabel2);
            this.Controls.Add(this.LLabel1);
            this.Controls.Add(this.LLabl);
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
            this.Name = "View_Lecturer";
            this.Text = "View_Lecturer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LLecturer;
        private System.Windows.Forms.Button LStudent;
        private System.Windows.Forms.Button LSubject;
        private System.Windows.Forms.Button LSession;
        private System.Windows.Forms.Button LAdvanced;
        private System.Windows.Forms.Button LWorking;
        private System.Windows.Forms.Button LTag;
        private System.Windows.Forms.Button LHome;
        private System.Windows.Forms.Button LRoom;
        private System.Windows.Forms.Button LLocations;
        private System.Windows.Forms.Button LStatistics;
        private System.Windows.Forms.Button LTimeTable;
        private System.Windows.Forms.Label LLabl;
        private System.Windows.Forms.Button LLabel1;
        private System.Windows.Forms.Button LLabel2;
        private System.Windows.Forms.Button LLabel3;
        private System.Windows.Forms.DataGridView dataGridViewLecturer;
        private System.Windows.Forms.Button LDELETE;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Button LEDIT;
    }
}