
namespace Project
{
    partial class Consecutive_Session
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
            this.LLabel1 = new System.Windows.Forms.Button();
            this.AsCTag = new System.Windows.Forms.Button();
            this.AsCWorking = new System.Windows.Forms.Button();
            this.AsCAdvanced = new System.Windows.Forms.Button();
            this.AsCSession = new System.Windows.Forms.Button();
            this.AsCSubject = new System.Windows.Forms.Button();
            this.AsCStudent = new System.Windows.Forms.Button();
            this.AsCLecturer = new System.Windows.Forms.Button();
            this.AsCTimeTable = new System.Windows.Forms.Button();
            this.AsCStatistics = new System.Windows.Forms.Button();
            this.AsCLocations = new System.Windows.Forms.Button();
            this.AsCRoom = new System.Windows.Forms.Button();
            this.AsCHome = new System.Windows.Forms.Button();
            this.btnLabel_NotAvailableTime_Session = new System.Windows.Forms.Button();
            this.btnLabel_NonOverlap_Session = new System.Windows.Forms.Button();
            this.btnLabel_PArallel_Session = new System.Windows.Forms.Button();
            this.btnLabel_Consective_Session = new System.Windows.Forms.Button();
            this.btn_Consective_Refresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add_Consective_Session = new System.Windows.Forms.Button();
            this.btnClear_Consective_Session = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewConsective = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsective)).BeginInit();
            this.SuspendLayout();
            // 
            // LLabel1
            // 
            this.LLabel1.BackColor = System.Drawing.Color.Crimson;
            this.LLabel1.Location = new System.Drawing.Point(351, -45);
            this.LLabel1.Name = "LLabel1";
            this.LLabel1.Size = new System.Drawing.Size(208, 35);
            this.LLabel1.TabIndex = 21;
            this.LLabel1.Text = "Add Lecturer";
            this.LLabel1.UseVisualStyleBackColor = false;
            // 
            // AsCTag
            // 
            this.AsCTag.Location = new System.Drawing.Point(12, 325);
            this.AsCTag.Name = "AsCTag";
            this.AsCTag.Size = new System.Drawing.Size(104, 72);
            this.AsCTag.TabIndex = 20;
            this.AsCTag.Text = "Tag";
            this.AsCTag.UseVisualStyleBackColor = true;
            this.AsCTag.Click += new System.EventHandler(this.AsCTag_Click);
            // 
            // AsCWorking
            // 
            this.AsCWorking.Location = new System.Drawing.Point(12, 559);
            this.AsCWorking.Name = "AsCWorking";
            this.AsCWorking.Size = new System.Drawing.Size(104, 72);
            this.AsCWorking.TabIndex = 19;
            this.AsCWorking.Text = "Working Days and Hours";
            this.AsCWorking.UseVisualStyleBackColor = true;
            this.AsCWorking.Click += new System.EventHandler(this.AsCWorking_Click);
            // 
            // AsCAdvanced
            // 
            this.AsCAdvanced.Location = new System.Drawing.Point(12, 481);
            this.AsCAdvanced.Name = "AsCAdvanced";
            this.AsCAdvanced.Size = new System.Drawing.Size(104, 72);
            this.AsCAdvanced.TabIndex = 18;
            this.AsCAdvanced.Text = "Advanced Session";
            this.AsCAdvanced.UseVisualStyleBackColor = true;
            this.AsCAdvanced.Click += new System.EventHandler(this.AsCAdvanced_Click);
            // 
            // AsCSession
            // 
            this.AsCSession.Location = new System.Drawing.Point(12, 403);
            this.AsCSession.Name = "AsCSession";
            this.AsCSession.Size = new System.Drawing.Size(104, 72);
            this.AsCSession.TabIndex = 17;
            this.AsCSession.Text = "Session";
            this.AsCSession.UseVisualStyleBackColor = true;
            this.AsCSession.Click += new System.EventHandler(this.AsCSession_Click);
            // 
            // AsCSubject
            // 
            this.AsCSubject.Location = new System.Drawing.Point(12, 247);
            this.AsCSubject.Name = "AsCSubject";
            this.AsCSubject.Size = new System.Drawing.Size(104, 72);
            this.AsCSubject.TabIndex = 16;
            this.AsCSubject.Text = "Subject";
            this.AsCSubject.UseVisualStyleBackColor = true;
            this.AsCSubject.Click += new System.EventHandler(this.AsCSubject_Click);
            // 
            // AsCStudent
            // 
            this.AsCStudent.Location = new System.Drawing.Point(12, 169);
            this.AsCStudent.Name = "AsCStudent";
            this.AsCStudent.Size = new System.Drawing.Size(104, 72);
            this.AsCStudent.TabIndex = 15;
            this.AsCStudent.Text = "Student";
            this.AsCStudent.UseVisualStyleBackColor = true;
            this.AsCStudent.Click += new System.EventHandler(this.AsCStudent_Click);
            // 
            // AsCLecturer
            // 
            this.AsCLecturer.Location = new System.Drawing.Point(12, 91);
            this.AsCLecturer.Name = "AsCLecturer";
            this.AsCLecturer.Size = new System.Drawing.Size(104, 72);
            this.AsCLecturer.TabIndex = 14;
            this.AsCLecturer.Text = "Lecturer";
            this.AsCLecturer.UseVisualStyleBackColor = true;
            this.AsCLecturer.Click += new System.EventHandler(this.AsCLecturer_Click);
            // 
            // AsCTimeTable
            // 
            this.AsCTimeTable.Location = new System.Drawing.Point(727, 12);
            this.AsCTimeTable.Name = "AsCTimeTable";
            this.AsCTimeTable.Size = new System.Drawing.Size(104, 72);
            this.AsCTimeTable.TabIndex = 26;
            this.AsCTimeTable.Text = "Time Table";
            this.AsCTimeTable.UseVisualStyleBackColor = true;
            this.AsCTimeTable.Click += new System.EventHandler(this.AsCTimeTable_Click);
            // 
            // AsCStatistics
            // 
            this.AsCStatistics.Location = new System.Drawing.Point(576, 12);
            this.AsCStatistics.Name = "AsCStatistics";
            this.AsCStatistics.Size = new System.Drawing.Size(104, 72);
            this.AsCStatistics.TabIndex = 25;
            this.AsCStatistics.Text = "Statistics";
            this.AsCStatistics.UseVisualStyleBackColor = true;
            this.AsCStatistics.Click += new System.EventHandler(this.AsCStatistics_Click);
            // 
            // AsCLocations
            // 
            this.AsCLocations.Location = new System.Drawing.Point(427, 12);
            this.AsCLocations.Name = "AsCLocations";
            this.AsCLocations.Size = new System.Drawing.Size(104, 72);
            this.AsCLocations.TabIndex = 24;
            this.AsCLocations.Text = "Location";
            this.AsCLocations.UseVisualStyleBackColor = true;
            this.AsCLocations.Click += new System.EventHandler(this.AsCLocations_Click);
            // 
            // AsCRoom
            // 
            this.AsCRoom.Location = new System.Drawing.Point(269, 12);
            this.AsCRoom.Name = "AsCRoom";
            this.AsCRoom.Size = new System.Drawing.Size(104, 72);
            this.AsCRoom.TabIndex = 23;
            this.AsCRoom.Text = "Room";
            this.AsCRoom.UseVisualStyleBackColor = true;
            this.AsCRoom.Click += new System.EventHandler(this.AsCRoom_Click);
            // 
            // AsCHome
            // 
            this.AsCHome.Location = new System.Drawing.Point(121, 12);
            this.AsCHome.Name = "AsCHome";
            this.AsCHome.Size = new System.Drawing.Size(104, 72);
            this.AsCHome.TabIndex = 22;
            this.AsCHome.Text = "Home";
            this.AsCHome.UseVisualStyleBackColor = true;
            this.AsCHome.Click += new System.EventHandler(this.AsCHome_Click);
            // 
            // btnLabel_NotAvailableTime_Session
            // 
            this.btnLabel_NotAvailableTime_Session.Location = new System.Drawing.Point(645, 128);
            this.btnLabel_NotAvailableTime_Session.Name = "btnLabel_NotAvailableTime_Session";
            this.btnLabel_NotAvailableTime_Session.Size = new System.Drawing.Size(191, 35);
            this.btnLabel_NotAvailableTime_Session.TabIndex = 31;
            this.btnLabel_NotAvailableTime_Session.Text = "Not Available Time ";
            this.btnLabel_NotAvailableTime_Session.UseVisualStyleBackColor = true;
            this.btnLabel_NotAvailableTime_Session.Click += new System.EventHandler(this.btnLabel_NotAvailableTime_Session_Click);
            // 
            // btnLabel_NonOverlap_Session
            // 
            this.btnLabel_NonOverlap_Session.Location = new System.Drawing.Point(455, 128);
            this.btnLabel_NonOverlap_Session.Name = "btnLabel_NonOverlap_Session";
            this.btnLabel_NonOverlap_Session.Size = new System.Drawing.Size(191, 35);
            this.btnLabel_NonOverlap_Session.TabIndex = 30;
            this.btnLabel_NonOverlap_Session.Text = "Non Overlapping Session ";
            this.btnLabel_NonOverlap_Session.UseVisualStyleBackColor = true;
            this.btnLabel_NonOverlap_Session.Click += new System.EventHandler(this.btnLabel_NonOverlap_Session_Click);
            // 
            // btnLabel_PArallel_Session
            // 
            this.btnLabel_PArallel_Session.Location = new System.Drawing.Point(300, 128);
            this.btnLabel_PArallel_Session.Name = "btnLabel_PArallel_Session";
            this.btnLabel_PArallel_Session.Size = new System.Drawing.Size(160, 35);
            this.btnLabel_PArallel_Session.TabIndex = 29;
            this.btnLabel_PArallel_Session.Text = "Parallel Session ";
            this.btnLabel_PArallel_Session.UseVisualStyleBackColor = true;
            this.btnLabel_PArallel_Session.Click += new System.EventHandler(this.btnLabel_PArallel_Session_Click);
            // 
            // btnLabel_Consective_Session
            // 
            this.btnLabel_Consective_Session.BackColor = System.Drawing.Color.Crimson;
            this.btnLabel_Consective_Session.Location = new System.Drawing.Point(145, 128);
            this.btnLabel_Consective_Session.Name = "btnLabel_Consective_Session";
            this.btnLabel_Consective_Session.Size = new System.Drawing.Size(160, 35);
            this.btnLabel_Consective_Session.TabIndex = 28;
            this.btnLabel_Consective_Session.Text = "Consecutive Session ";
            this.btnLabel_Consective_Session.UseVisualStyleBackColor = false;
            this.btnLabel_Consective_Session.Click += new System.EventHandler(this.btnLabel_Consective_Session_Click);
            // 
            // btn_Consective_Refresh
            // 
            this.btn_Consective_Refresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Consective_Refresh.Location = new System.Drawing.Point(204, 423);
            this.btn_Consective_Refresh.Name = "btn_Consective_Refresh";
            this.btn_Consective_Refresh.Size = new System.Drawing.Size(195, 33);
            this.btn_Consective_Refresh.TabIndex = 42;
            this.btn_Consective_Refresh.Text = "Refresh";
            this.btn_Consective_Refresh.UseVisualStyleBackColor = false;
            this.btn_Consective_Refresh.Click += new System.EventHandler(this.btn_Consective_Refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // btn_Add_Consective_Session
            // 
            this.btn_Add_Consective_Session.BackColor = System.Drawing.Color.Blue;
            this.btn_Add_Consective_Session.Location = new System.Drawing.Point(204, 305);
            this.btn_Add_Consective_Session.Name = "btn_Add_Consective_Session";
            this.btn_Add_Consective_Session.Size = new System.Drawing.Size(195, 33);
            this.btn_Add_Consective_Session.TabIndex = 40;
            this.btn_Add_Consective_Session.Text = "Add Consecutive Session ";
            this.btn_Add_Consective_Session.UseVisualStyleBackColor = false;
            this.btn_Add_Consective_Session.Click += new System.EventHandler(this.btn_Add_Consective_Session_Click);
            // 
            // btnClear_Consective_Session
            // 
            this.btnClear_Consective_Session.BackColor = System.Drawing.Color.Crimson;
            this.btnClear_Consective_Session.Location = new System.Drawing.Point(204, 364);
            this.btnClear_Consective_Session.Name = "btnClear_Consective_Session";
            this.btnClear_Consective_Session.Size = new System.Drawing.Size(195, 33);
            this.btnClear_Consective_Session.TabIndex = 39;
            this.btnClear_Consective_Session.Text = "Clear";
            this.btnClear_Consective_Session.UseVisualStyleBackColor = false;
            this.btnClear_Consective_Session.Click += new System.EventHandler(this.btnClear_Consective_Session_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(204, 256);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(238, 24);
            this.comboBox2.TabIndex = 38;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // dataGridViewConsective
            // 
            this.dataGridViewConsective.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsective.Location = new System.Drawing.Point(406, 455);
            this.dataGridViewConsective.Name = "dataGridViewConsective";
            this.dataGridViewConsective.RowHeadersWidth = 51;
            this.dataGridViewConsective.RowTemplate.Height = 24;
            this.dataGridViewConsective.Size = new System.Drawing.Size(466, 150);
            this.dataGridViewConsective.TabIndex = 43;
            this.dataGridViewConsective.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsective_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Search";
            // 
            // textBoxSsearch
            // 
            this.textBoxSsearch.Location = new System.Drawing.Point(633, 385);
            this.textBoxSsearch.Name = "textBoxSsearch";
            this.textBoxSsearch.Size = new System.Drawing.Size(168, 22);
            this.textBoxSsearch.TabIndex = 44;
            this.textBoxSsearch.TextChanged += new System.EventHandler(this.textBoxSsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(26, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Advanced";
            // 
            // Consecutive_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSsearch);
            this.Controls.Add(this.dataGridViewConsective);
            this.Controls.Add(this.btn_Consective_Refresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Add_Consective_Session);
            this.Controls.Add(this.btnClear_Consective_Session);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLabel_NotAvailableTime_Session);
            this.Controls.Add(this.btnLabel_NonOverlap_Session);
            this.Controls.Add(this.btnLabel_PArallel_Session);
            this.Controls.Add(this.btnLabel_Consective_Session);
            this.Controls.Add(this.AsCTimeTable);
            this.Controls.Add(this.AsCStatistics);
            this.Controls.Add(this.AsCLocations);
            this.Controls.Add(this.AsCRoom);
            this.Controls.Add(this.AsCHome);
            this.Controls.Add(this.LLabel1);
            this.Controls.Add(this.AsCTag);
            this.Controls.Add(this.AsCWorking);
            this.Controls.Add(this.AsCAdvanced);
            this.Controls.Add(this.AsCSession);
            this.Controls.Add(this.AsCSubject);
            this.Controls.Add(this.AsCStudent);
            this.Controls.Add(this.AsCLecturer);
            this.Name = "Consecutive_Session";
            this.Text = "Consecutive_Session";
            this.Load += new System.EventHandler(this.Consecutive_Session_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsective)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LLabel1;
        private System.Windows.Forms.Button AsCTag;
        private System.Windows.Forms.Button AsCWorking;
        private System.Windows.Forms.Button AsCAdvanced;
        private System.Windows.Forms.Button AsCSession;
        private System.Windows.Forms.Button AsCSubject;
        private System.Windows.Forms.Button AsCStudent;
        private System.Windows.Forms.Button AsCLecturer;
        private System.Windows.Forms.Button AsCTimeTable;
        private System.Windows.Forms.Button AsCStatistics;
        private System.Windows.Forms.Button AsCLocations;
        private System.Windows.Forms.Button AsCRoom;
        private System.Windows.Forms.Button AsCHome;
        private System.Windows.Forms.Button btnLabel_NotAvailableTime_Session;
        private System.Windows.Forms.Button btnLabel_NonOverlap_Session;
        private System.Windows.Forms.Button btnLabel_PArallel_Session;
        private System.Windows.Forms.Button btnLabel_Consective_Session;
        private System.Windows.Forms.Button btn_Consective_Refresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Add_Consective_Session;
        private System.Windows.Forms.Button btnClear_Consective_Session;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewConsective;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}