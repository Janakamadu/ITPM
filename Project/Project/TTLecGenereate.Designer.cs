
namespace Project
{
    partial class TTLecGenereate
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
            this.TimetextBoxsearch = new System.Windows.Forms.TextBox();
            this.dataGridViewtimeTable = new System.Windows.Forms.DataGridView();
            this.TLabl = new System.Windows.Forms.Label();
            this.TTimeTable = new System.Windows.Forms.Button();
            this.TStatistics = new System.Windows.Forms.Button();
            this.TLocations = new System.Windows.Forms.Button();
            this.TRoom = new System.Windows.Forms.Button();
            this.THome = new System.Windows.Forms.Button();
            this.TTag = new System.Windows.Forms.Button();
            this.TWorking = new System.Windows.Forms.Button();
            this.TAdvanced = new System.Windows.Forms.Button();
            this.TSession = new System.Windows.Forms.Button();
            this.TSubject = new System.Windows.Forms.Button();
            this.TStudent = new System.Windows.Forms.Button();
            this.TLecturer = new System.Windows.Forms.Button();
            this.TTOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TimetextBoxsearch
            // 
            this.TimetextBoxsearch.Location = new System.Drawing.Point(583, 141);
            this.TimetextBoxsearch.Name = "TimetextBoxsearch";
            this.TimetextBoxsearch.Size = new System.Drawing.Size(295, 22);
            this.TimetextBoxsearch.TabIndex = 73;
            // 
            // dataGridViewtimeTable
            // 
            this.dataGridViewtimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtimeTable.Location = new System.Drawing.Point(126, 180);
            this.dataGridViewtimeTable.Name = "dataGridViewtimeTable";
            this.dataGridViewtimeTable.RowHeadersWidth = 51;
            this.dataGridViewtimeTable.RowTemplate.Height = 24;
            this.dataGridViewtimeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewtimeTable.Size = new System.Drawing.Size(754, 385);
            this.dataGridViewtimeTable.TabIndex = 70;
            // 
            // TLabl
            // 
            this.TLabl.AutoSize = true;
            this.TLabl.BackColor = System.Drawing.Color.Blue;
            this.TLabl.Location = new System.Drawing.Point(31, 40);
            this.TLabl.Name = "TLabl";
            this.TLabl.Size = new System.Drawing.Size(79, 17);
            this.TLabl.TabIndex = 66;
            this.TLabl.Text = "Time Table";
            // 
            // TTimeTable
            // 
            this.TTimeTable.Location = new System.Drawing.Point(727, 12);
            this.TTimeTable.Name = "TTimeTable";
            this.TTimeTable.Size = new System.Drawing.Size(104, 72);
            this.TTimeTable.TabIndex = 65;
            this.TTimeTable.Text = "Time Table";
            this.TTimeTable.UseVisualStyleBackColor = true;
            this.TTimeTable.Click += new System.EventHandler(this.TTimeTable_Click);
            // 
            // TStatistics
            // 
            this.TStatistics.Location = new System.Drawing.Point(576, 12);
            this.TStatistics.Name = "TStatistics";
            this.TStatistics.Size = new System.Drawing.Size(104, 72);
            this.TStatistics.TabIndex = 64;
            this.TStatistics.Text = "Statistics";
            this.TStatistics.UseVisualStyleBackColor = true;
            this.TStatistics.Click += new System.EventHandler(this.TStatistics_Click);
            // 
            // TLocations
            // 
            this.TLocations.Location = new System.Drawing.Point(427, 12);
            this.TLocations.Name = "TLocations";
            this.TLocations.Size = new System.Drawing.Size(104, 72);
            this.TLocations.TabIndex = 63;
            this.TLocations.Text = "Location";
            this.TLocations.UseVisualStyleBackColor = true;
            this.TLocations.Click += new System.EventHandler(this.TLocations_Click);
            // 
            // TRoom
            // 
            this.TRoom.Location = new System.Drawing.Point(269, 12);
            this.TRoom.Name = "TRoom";
            this.TRoom.Size = new System.Drawing.Size(104, 72);
            this.TRoom.TabIndex = 62;
            this.TRoom.Text = "Room";
            this.TRoom.UseVisualStyleBackColor = true;
            this.TRoom.Click += new System.EventHandler(this.TRoom_Click);
            // 
            // THome
            // 
            this.THome.Location = new System.Drawing.Point(121, 12);
            this.THome.Name = "THome";
            this.THome.Size = new System.Drawing.Size(104, 72);
            this.THome.TabIndex = 61;
            this.THome.Text = "Home";
            this.THome.UseVisualStyleBackColor = true;
            this.THome.Click += new System.EventHandler(this.THome_Click);
            // 
            // TTag
            // 
            this.TTag.Location = new System.Drawing.Point(12, 325);
            this.TTag.Name = "TTag";
            this.TTag.Size = new System.Drawing.Size(104, 72);
            this.TTag.TabIndex = 60;
            this.TTag.Text = "Tag";
            this.TTag.UseVisualStyleBackColor = true;
            this.TTag.Click += new System.EventHandler(this.TTag_Click);
            // 
            // TWorking
            // 
            this.TWorking.Location = new System.Drawing.Point(12, 559);
            this.TWorking.Name = "TWorking";
            this.TWorking.Size = new System.Drawing.Size(104, 72);
            this.TWorking.TabIndex = 59;
            this.TWorking.Text = "Working Days and Hours";
            this.TWorking.UseVisualStyleBackColor = true;
            this.TWorking.Click += new System.EventHandler(this.TWorking_Click);
            // 
            // TAdvanced
            // 
            this.TAdvanced.Location = new System.Drawing.Point(12, 481);
            this.TAdvanced.Name = "TAdvanced";
            this.TAdvanced.Size = new System.Drawing.Size(104, 72);
            this.TAdvanced.TabIndex = 58;
            this.TAdvanced.Text = "Advanced Session";
            this.TAdvanced.UseVisualStyleBackColor = true;
            this.TAdvanced.Click += new System.EventHandler(this.TAdvanced_Click);
            // 
            // TSession
            // 
            this.TSession.Location = new System.Drawing.Point(12, 403);
            this.TSession.Name = "TSession";
            this.TSession.Size = new System.Drawing.Size(104, 72);
            this.TSession.TabIndex = 57;
            this.TSession.Text = "Session";
            this.TSession.UseVisualStyleBackColor = true;
            this.TSession.Click += new System.EventHandler(this.TSession_Click);
            // 
            // TSubject
            // 
            this.TSubject.Location = new System.Drawing.Point(12, 247);
            this.TSubject.Name = "TSubject";
            this.TSubject.Size = new System.Drawing.Size(104, 72);
            this.TSubject.TabIndex = 56;
            this.TSubject.Text = "Subject";
            this.TSubject.UseVisualStyleBackColor = true;
            this.TSubject.Click += new System.EventHandler(this.TSubject_Click);
            // 
            // TStudent
            // 
            this.TStudent.Location = new System.Drawing.Point(12, 169);
            this.TStudent.Name = "TStudent";
            this.TStudent.Size = new System.Drawing.Size(104, 72);
            this.TStudent.TabIndex = 55;
            this.TStudent.Text = "Student";
            this.TStudent.UseVisualStyleBackColor = true;
            this.TStudent.Click += new System.EventHandler(this.TStudent_Click);
            // 
            // TLecturer
            // 
            this.TLecturer.Location = new System.Drawing.Point(12, 91);
            this.TLecturer.Name = "TLecturer";
            this.TLecturer.Size = new System.Drawing.Size(104, 72);
            this.TLecturer.TabIndex = 54;
            this.TLecturer.Text = "Lecturer";
            this.TLecturer.UseVisualStyleBackColor = true;
            this.TLecturer.Click += new System.EventHandler(this.TLecturer_Click);
            // 
            // TTOK
            // 
            this.TTOK.BackColor = System.Drawing.Color.Olive;
            this.TTOK.Location = new System.Drawing.Point(777, 595);
            this.TTOK.Name = "TTOK";
            this.TTOK.Size = new System.Drawing.Size(90, 36);
            this.TTOK.TabIndex = 71;
            this.TTOK.Text = "OK";
            this.TTOK.UseVisualStyleBackColor = false;
            this.TTOK.Click += new System.EventHandler(this.TTOK_Click);
            // 
            // TTLecGenereate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 643);
            this.Controls.Add(this.TimetextBoxsearch);
            this.Controls.Add(this.TTOK);
            this.Controls.Add(this.dataGridViewtimeTable);
            this.Controls.Add(this.TLabl);
            this.Controls.Add(this.TTimeTable);
            this.Controls.Add(this.TStatistics);
            this.Controls.Add(this.TLocations);
            this.Controls.Add(this.TRoom);
            this.Controls.Add(this.THome);
            this.Controls.Add(this.TTag);
            this.Controls.Add(this.TWorking);
            this.Controls.Add(this.TAdvanced);
            this.Controls.Add(this.TSession);
            this.Controls.Add(this.TSubject);
            this.Controls.Add(this.TStudent);
            this.Controls.Add(this.TLecturer);
            this.Name = "TTLecGenereate";
            this.Text = "TTLecGenereate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TimetextBoxsearch;
        private System.Windows.Forms.DataGridView dataGridViewtimeTable;
        private System.Windows.Forms.Label TLabl;
        private System.Windows.Forms.Button TTimeTable;
        private System.Windows.Forms.Button TStatistics;
        private System.Windows.Forms.Button TLocations;
        private System.Windows.Forms.Button TRoom;
        private System.Windows.Forms.Button THome;
        private System.Windows.Forms.Button TTag;
        private System.Windows.Forms.Button TWorking;
        private System.Windows.Forms.Button TAdvanced;
        private System.Windows.Forms.Button TSession;
        private System.Windows.Forms.Button TSubject;
        private System.Windows.Forms.Button TStudent;
        private System.Windows.Forms.Button TLecturer;
        private System.Windows.Forms.Button TTOK;
    }
}