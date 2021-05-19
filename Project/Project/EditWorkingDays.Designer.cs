
namespace Project
{
    partial class EditWorkingDays
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
            this.EaddMin = new System.Windows.Forms.NumericUpDown();
            this.EaddHrs = new System.Windows.Forms.NumericUpDown();
            this.EnoOfWorkingDays = new System.Windows.Forms.NumericUpDown();
            this.EsundayCheckBox = new System.Windows.Forms.CheckBox();
            this.EsaturdayheckBox = new System.Windows.Forms.CheckBox();
            this.EfridayCheckBox = new System.Windows.Forms.CheckBox();
            this.EthursdayCheckBox = new System.Windows.Forms.CheckBox();
            this.EtuesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.EwednesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.EmondayCheckBox = new System.Windows.Forms.CheckBox();
            this.WdlabelMin = new System.Windows.Forms.Label();
            this.WDlabelHrs = new System.Windows.Forms.Label();
            this.WDlabelN = new System.Windows.Forms.Label();
            this.WDWorkingDays = new System.Windows.Forms.Label();
            this.LCenter = new System.Windows.Forms.Label();
            this.WDNoofWorking = new System.Windows.Forms.Label();
            this.WDELabel3 = new System.Windows.Forms.Button();
            this.WDELabel2 = new System.Windows.Forms.Button();
            this.WDELabel1 = new System.Windows.Forms.Button();
            this.WDLablN = new System.Windows.Forms.Label();
            this.WDETimeTable = new System.Windows.Forms.Button();
            this.WDEStatistics = new System.Windows.Forms.Button();
            this.WDELocations = new System.Windows.Forms.Button();
            this.WDERoom = new System.Windows.Forms.Button();
            this.WDEHome = new System.Windows.Forms.Button();
            this.WDETag = new System.Windows.Forms.Button();
            this.WDEWorking = new System.Windows.Forms.Button();
            this.WDEAdvanced = new System.Windows.Forms.Button();
            this.WDESession = new System.Windows.Forms.Button();
            this.WDESubject = new System.Windows.Forms.Button();
            this.WDEStudent = new System.Windows.Forms.Button();
            this.WDELecturer = new System.Windows.Forms.Button();
            this.WDEDELETE = new System.Windows.Forms.Button();
            this.WDUPDATE = new System.Windows.Forms.Button();
            this.recordID = new System.Windows.Forms.ComboBox();
            this.WDlabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EaddMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EaddHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnoOfWorkingDays)).BeginInit();
            this.SuspendLayout();
            // 
            // EaddMin
            // 
            this.EaddMin.Location = new System.Drawing.Point(518, 453);
            this.EaddMin.Name = "EaddMin";
            this.EaddMin.Size = new System.Drawing.Size(120, 22);
            this.EaddMin.TabIndex = 118;
            // 
            // EaddHrs
            // 
            this.EaddHrs.Location = new System.Drawing.Point(325, 453);
            this.EaddHrs.Name = "EaddHrs";
            this.EaddHrs.Size = new System.Drawing.Size(120, 22);
            this.EaddHrs.TabIndex = 117;
            // 
            // EnoOfWorkingDays
            // 
            this.EnoOfWorkingDays.Location = new System.Drawing.Point(325, 245);
            this.EnoOfWorkingDays.Name = "EnoOfWorkingDays";
            this.EnoOfWorkingDays.Size = new System.Drawing.Size(119, 22);
            this.EnoOfWorkingDays.TabIndex = 116;
            // 
            // EsundayCheckBox
            // 
            this.EsundayCheckBox.AutoSize = true;
            this.EsundayCheckBox.Location = new System.Drawing.Point(540, 375);
            this.EsundayCheckBox.Name = "EsundayCheckBox";
            this.EsundayCheckBox.Size = new System.Drawing.Size(78, 21);
            this.EsundayCheckBox.TabIndex = 115;
            this.EsundayCheckBox.Text = "Sunday";
            this.EsundayCheckBox.UseVisualStyleBackColor = true;
            this.EsundayCheckBox.CheckedChanged += new System.EventHandler(this.EsundayCheckBox_CheckedChanged);
            // 
            // EsaturdayheckBox
            // 
            this.EsaturdayheckBox.AutoSize = true;
            this.EsaturdayheckBox.Location = new System.Drawing.Point(435, 375);
            this.EsaturdayheckBox.Name = "EsaturdayheckBox";
            this.EsaturdayheckBox.Size = new System.Drawing.Size(87, 21);
            this.EsaturdayheckBox.TabIndex = 114;
            this.EsaturdayheckBox.Text = "Saturday";
            this.EsaturdayheckBox.UseVisualStyleBackColor = true;
            this.EsaturdayheckBox.CheckedChanged += new System.EventHandler(this.EsaturdayheckBox_CheckedChanged);
            // 
            // EfridayCheckBox
            // 
            this.EfridayCheckBox.AutoSize = true;
            this.EfridayCheckBox.Location = new System.Drawing.Point(325, 375);
            this.EfridayCheckBox.Name = "EfridayCheckBox";
            this.EfridayCheckBox.Size = new System.Drawing.Size(69, 21);
            this.EfridayCheckBox.TabIndex = 113;
            this.EfridayCheckBox.Text = "Friday";
            this.EfridayCheckBox.UseVisualStyleBackColor = true;
            this.EfridayCheckBox.CheckedChanged += new System.EventHandler(this.EfridayCheckBox_CheckedChanged);
            // 
            // EthursdayCheckBox
            // 
            this.EthursdayCheckBox.AutoSize = true;
            this.EthursdayCheckBox.Location = new System.Drawing.Point(643, 325);
            this.EthursdayCheckBox.Name = "EthursdayCheckBox";
            this.EthursdayCheckBox.Size = new System.Drawing.Size(90, 21);
            this.EthursdayCheckBox.TabIndex = 112;
            this.EthursdayCheckBox.Text = "Thursday";
            this.EthursdayCheckBox.UseVisualStyleBackColor = true;
            this.EthursdayCheckBox.CheckedChanged += new System.EventHandler(this.EthursdayCheckBox_CheckedChanged);
            // 
            // EtuesdayCheckBox
            // 
            this.EtuesdayCheckBox.AutoSize = true;
            this.EtuesdayCheckBox.Location = new System.Drawing.Point(435, 327);
            this.EtuesdayCheckBox.Name = "EtuesdayCheckBox";
            this.EtuesdayCheckBox.Size = new System.Drawing.Size(85, 21);
            this.EtuesdayCheckBox.TabIndex = 111;
            this.EtuesdayCheckBox.Text = "Tuesday";
            this.EtuesdayCheckBox.UseVisualStyleBackColor = true;
            this.EtuesdayCheckBox.CheckedChanged += new System.EventHandler(this.EtuesdayCheckBox_CheckedChanged);
            // 
            // EwednesdayCheckBox
            // 
            this.EwednesdayCheckBox.AutoSize = true;
            this.EwednesdayCheckBox.Location = new System.Drawing.Point(539, 327);
            this.EwednesdayCheckBox.Name = "EwednesdayCheckBox";
            this.EwednesdayCheckBox.Size = new System.Drawing.Size(105, 21);
            this.EwednesdayCheckBox.TabIndex = 110;
            this.EwednesdayCheckBox.Text = "Wednesday";
            this.EwednesdayCheckBox.UseVisualStyleBackColor = true;
            this.EwednesdayCheckBox.CheckedChanged += new System.EventHandler(this.EwednesdayCheckBox_CheckedChanged);
            // 
            // EmondayCheckBox
            // 
            this.EmondayCheckBox.AutoSize = true;
            this.EmondayCheckBox.Location = new System.Drawing.Point(324, 327);
            this.EmondayCheckBox.Name = "EmondayCheckBox";
            this.EmondayCheckBox.Size = new System.Drawing.Size(80, 21);
            this.EmondayCheckBox.TabIndex = 109;
            this.EmondayCheckBox.Text = "Monday";
            this.EmondayCheckBox.UseVisualStyleBackColor = true;
            this.EmondayCheckBox.CheckedChanged += new System.EventHandler(this.EmondayCheckBox_CheckedChanged);
            // 
            // WdlabelMin
            // 
            this.WdlabelMin.AutoSize = true;
            this.WdlabelMin.Location = new System.Drawing.Point(644, 449);
            this.WdlabelMin.Name = "WdlabelMin";
            this.WdlabelMin.Size = new System.Drawing.Size(30, 17);
            this.WdlabelMin.TabIndex = 108;
            this.WdlabelMin.Text = "Min";
            // 
            // WDlabelHrs
            // 
            this.WDlabelHrs.AutoSize = true;
            this.WDlabelHrs.Location = new System.Drawing.Point(458, 446);
            this.WDlabelHrs.Name = "WDlabelHrs";
            this.WDlabelHrs.Size = new System.Drawing.Size(30, 17);
            this.WDlabelHrs.TabIndex = 107;
            this.WDlabelHrs.Text = "Hrs";
            // 
            // WDlabelN
            // 
            this.WDlabelN.AutoSize = true;
            this.WDlabelN.BackColor = System.Drawing.Color.Blue;
            this.WDlabelN.Location = new System.Drawing.Point(32, 50);
            this.WDlabelN.Name = "WDlabelN";
            this.WDlabelN.Size = new System.Drawing.Size(75, 17);
            this.WDlabelN.TabIndex = 106;
            this.WDlabelN.Text = "And Hours";
            // 
            // WDWorkingDays
            // 
            this.WDWorkingDays.AutoSize = true;
            this.WDWorkingDays.Location = new System.Drawing.Point(145, 325);
            this.WDWorkingDays.Name = "WDWorkingDays";
            this.WDWorkingDays.Size = new System.Drawing.Size(96, 17);
            this.WDWorkingDays.TabIndex = 103;
            this.WDWorkingDays.Text = "Working Days";
            // 
            // LCenter
            // 
            this.LCenter.AutoSize = true;
            this.LCenter.Location = new System.Drawing.Point(144, 453);
            this.LCenter.Name = "LCenter";
            this.LCenter.Size = new System.Drawing.Size(150, 17);
            this.LCenter.TabIndex = 102;
            this.LCenter.Text = "Working Time Per Day";
            // 
            // WDNoofWorking
            // 
            this.WDNoofWorking.AutoSize = true;
            this.WDNoofWorking.Location = new System.Drawing.Point(144, 247);
            this.WDNoofWorking.Name = "WDNoofWorking";
            this.WDNoofWorking.Size = new System.Drawing.Size(138, 17);
            this.WDNoofWorking.TabIndex = 101;
            this.WDNoofWorking.Text = "No  of Working Days";
            // 
            // WDELabel3
            // 
            this.WDELabel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.WDELabel3.Location = new System.Drawing.Point(562, 91);
            this.WDELabel3.Name = "WDELabel3";
            this.WDELabel3.Size = new System.Drawing.Size(208, 35);
            this.WDELabel3.TabIndex = 100;
            this.WDELabel3.Text = "View Working Days & Hours";
            this.WDELabel3.UseVisualStyleBackColor = false;
            // 
            // WDELabel2
            // 
            this.WDELabel2.BackColor = System.Drawing.Color.Crimson;
            this.WDELabel2.Location = new System.Drawing.Point(348, 90);
            this.WDELabel2.Name = "WDELabel2";
            this.WDELabel2.Size = new System.Drawing.Size(208, 35);
            this.WDELabel2.TabIndex = 99;
            this.WDELabel2.Text = "Edit Working Days & Hours";
            this.WDELabel2.UseVisualStyleBackColor = false;
            // 
            // WDELabel1
            // 
            this.WDELabel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.WDELabel1.Location = new System.Drawing.Point(134, 91);
            this.WDELabel1.Name = "WDELabel1";
            this.WDELabel1.Size = new System.Drawing.Size(208, 35);
            this.WDELabel1.TabIndex = 98;
            this.WDELabel1.Text = "Add Working Days & Hours";
            this.WDELabel1.UseVisualStyleBackColor = false;
            // 
            // WDLablN
            // 
            this.WDLablN.AutoSize = true;
            this.WDLablN.BackColor = System.Drawing.Color.Blue;
            this.WDLablN.Location = new System.Drawing.Point(31, 24);
            this.WDLablN.Name = "WDLablN";
            this.WDLablN.Size = new System.Drawing.Size(96, 17);
            this.WDLablN.TabIndex = 97;
            this.WDLablN.Text = "Working Days";
            // 
            // WDETimeTable
            // 
            this.WDETimeTable.Location = new System.Drawing.Point(739, 12);
            this.WDETimeTable.Name = "WDETimeTable";
            this.WDETimeTable.Size = new System.Drawing.Size(104, 72);
            this.WDETimeTable.TabIndex = 96;
            this.WDETimeTable.Text = "Time Table";
            this.WDETimeTable.UseVisualStyleBackColor = true;
            // 
            // WDEStatistics
            // 
            this.WDEStatistics.Location = new System.Drawing.Point(588, 12);
            this.WDEStatistics.Name = "WDEStatistics";
            this.WDEStatistics.Size = new System.Drawing.Size(104, 72);
            this.WDEStatistics.TabIndex = 95;
            this.WDEStatistics.Text = "Statistics";
            this.WDEStatistics.UseVisualStyleBackColor = true;
            // 
            // WDELocations
            // 
            this.WDELocations.Location = new System.Drawing.Point(439, 12);
            this.WDELocations.Name = "WDELocations";
            this.WDELocations.Size = new System.Drawing.Size(104, 72);
            this.WDELocations.TabIndex = 94;
            this.WDELocations.Text = "Location";
            this.WDELocations.UseVisualStyleBackColor = true;
            // 
            // WDERoom
            // 
            this.WDERoom.Location = new System.Drawing.Point(281, 12);
            this.WDERoom.Name = "WDERoom";
            this.WDERoom.Size = new System.Drawing.Size(104, 72);
            this.WDERoom.TabIndex = 93;
            this.WDERoom.Text = "Room";
            this.WDERoom.UseVisualStyleBackColor = true;
            // 
            // WDEHome
            // 
            this.WDEHome.Location = new System.Drawing.Point(133, 12);
            this.WDEHome.Name = "WDEHome";
            this.WDEHome.Size = new System.Drawing.Size(104, 72);
            this.WDEHome.TabIndex = 92;
            this.WDEHome.Text = "Home";
            this.WDEHome.UseVisualStyleBackColor = true;
            // 
            // WDETag
            // 
            this.WDETag.Location = new System.Drawing.Point(24, 325);
            this.WDETag.Name = "WDETag";
            this.WDETag.Size = new System.Drawing.Size(104, 72);
            this.WDETag.TabIndex = 91;
            this.WDETag.Text = "Tag";
            this.WDETag.UseVisualStyleBackColor = true;
            // 
            // WDEWorking
            // 
            this.WDEWorking.Location = new System.Drawing.Point(24, 559);
            this.WDEWorking.Name = "WDEWorking";
            this.WDEWorking.Size = new System.Drawing.Size(104, 72);
            this.WDEWorking.TabIndex = 90;
            this.WDEWorking.Text = "Working Days and Hours";
            this.WDEWorking.UseVisualStyleBackColor = true;
            // 
            // WDEAdvanced
            // 
            this.WDEAdvanced.Location = new System.Drawing.Point(24, 481);
            this.WDEAdvanced.Name = "WDEAdvanced";
            this.WDEAdvanced.Size = new System.Drawing.Size(104, 72);
            this.WDEAdvanced.TabIndex = 89;
            this.WDEAdvanced.Text = "Advanced Session";
            this.WDEAdvanced.UseVisualStyleBackColor = true;
            // 
            // WDESession
            // 
            this.WDESession.Location = new System.Drawing.Point(24, 403);
            this.WDESession.Name = "WDESession";
            this.WDESession.Size = new System.Drawing.Size(104, 72);
            this.WDESession.TabIndex = 88;
            this.WDESession.Text = "Session";
            this.WDESession.UseVisualStyleBackColor = true;
            // 
            // WDESubject
            // 
            this.WDESubject.Location = new System.Drawing.Point(24, 247);
            this.WDESubject.Name = "WDESubject";
            this.WDESubject.Size = new System.Drawing.Size(104, 72);
            this.WDESubject.TabIndex = 87;
            this.WDESubject.Text = "Subject";
            this.WDESubject.UseVisualStyleBackColor = true;
            // 
            // WDEStudent
            // 
            this.WDEStudent.Location = new System.Drawing.Point(24, 169);
            this.WDEStudent.Name = "WDEStudent";
            this.WDEStudent.Size = new System.Drawing.Size(104, 72);
            this.WDEStudent.TabIndex = 86;
            this.WDEStudent.Text = "Student";
            this.WDEStudent.UseVisualStyleBackColor = true;
            // 
            // WDELecturer
            // 
            this.WDELecturer.Location = new System.Drawing.Point(24, 91);
            this.WDELecturer.Name = "WDELecturer";
            this.WDELecturer.Size = new System.Drawing.Size(104, 72);
            this.WDELecturer.TabIndex = 85;
            this.WDELecturer.Text = "Lecturer";
            this.WDELecturer.UseVisualStyleBackColor = true;
            // 
            // WDEDELETE
            // 
            this.WDEDELETE.BackColor = System.Drawing.Color.Red;
            this.WDEDELETE.Location = new System.Drawing.Point(739, 578);
            this.WDEDELETE.Name = "WDEDELETE";
            this.WDEDELETE.Size = new System.Drawing.Size(90, 35);
            this.WDEDELETE.TabIndex = 120;
            this.WDEDELETE.Text = "DELETE";
            this.WDEDELETE.UseVisualStyleBackColor = false;
            // 
            // WDUPDATE
            // 
            this.WDUPDATE.BackColor = System.Drawing.Color.DarkMagenta;
            this.WDUPDATE.Location = new System.Drawing.Point(619, 578);
            this.WDUPDATE.Name = "WDUPDATE";
            this.WDUPDATE.Size = new System.Drawing.Size(90, 35);
            this.WDUPDATE.TabIndex = 119;
            this.WDUPDATE.Text = "UPDATE";
            this.WDUPDATE.UseVisualStyleBackColor = false;
            this.WDUPDATE.Click += new System.EventHandler(this.WDUPDATE_Click);
            // 
            // recordID
            // 
            this.recordID.FormattingEnabled = true;
            this.recordID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.recordID.Location = new System.Drawing.Point(324, 176);
            this.recordID.Name = "recordID";
            this.recordID.Size = new System.Drawing.Size(329, 24);
            this.recordID.TabIndex = 122;
            this.recordID.SelectedIndexChanged += new System.EventHandler(this.recordID_SelectedIndexChanged);
            // 
            // WDlabel1
            // 
            this.WDlabel1.AutoSize = true;
            this.WDlabel1.Location = new System.Drawing.Point(144, 179);
            this.WDlabel1.Name = "WDlabel1";
            this.WDlabel1.Size = new System.Drawing.Size(54, 17);
            this.WDlabel1.TabIndex = 121;
            this.WDlabel1.Text = "Roll No";
            // 
            // EditWorkingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 643);
            this.Controls.Add(this.recordID);
            this.Controls.Add(this.WDlabel1);
            this.Controls.Add(this.WDEDELETE);
            this.Controls.Add(this.WDUPDATE);
            this.Controls.Add(this.EaddMin);
            this.Controls.Add(this.EaddHrs);
            this.Controls.Add(this.EnoOfWorkingDays);
            this.Controls.Add(this.EsundayCheckBox);
            this.Controls.Add(this.EsaturdayheckBox);
            this.Controls.Add(this.EfridayCheckBox);
            this.Controls.Add(this.EthursdayCheckBox);
            this.Controls.Add(this.EtuesdayCheckBox);
            this.Controls.Add(this.EwednesdayCheckBox);
            this.Controls.Add(this.EmondayCheckBox);
            this.Controls.Add(this.WdlabelMin);
            this.Controls.Add(this.WDlabelHrs);
            this.Controls.Add(this.WDlabelN);
            this.Controls.Add(this.WDWorkingDays);
            this.Controls.Add(this.LCenter);
            this.Controls.Add(this.WDNoofWorking);
            this.Controls.Add(this.WDELabel3);
            this.Controls.Add(this.WDELabel2);
            this.Controls.Add(this.WDELabel1);
            this.Controls.Add(this.WDLablN);
            this.Controls.Add(this.WDETimeTable);
            this.Controls.Add(this.WDEStatistics);
            this.Controls.Add(this.WDELocations);
            this.Controls.Add(this.WDERoom);
            this.Controls.Add(this.WDEHome);
            this.Controls.Add(this.WDETag);
            this.Controls.Add(this.WDEWorking);
            this.Controls.Add(this.WDEAdvanced);
            this.Controls.Add(this.WDESession);
            this.Controls.Add(this.WDESubject);
            this.Controls.Add(this.WDEStudent);
            this.Controls.Add(this.WDELecturer);
            this.Name = "EditWorkingDays";
            this.Text = "EditWorkingDays";
            ((System.ComponentModel.ISupportInitialize)(this.EaddMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EaddHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnoOfWorkingDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown EaddMin;
        private System.Windows.Forms.NumericUpDown EaddHrs;
        private System.Windows.Forms.NumericUpDown EnoOfWorkingDays;
        private System.Windows.Forms.CheckBox EsundayCheckBox;
        private System.Windows.Forms.CheckBox EsaturdayheckBox;
        private System.Windows.Forms.CheckBox EfridayCheckBox;
        private System.Windows.Forms.CheckBox EthursdayCheckBox;
        private System.Windows.Forms.CheckBox EtuesdayCheckBox;
        private System.Windows.Forms.CheckBox EwednesdayCheckBox;
        private System.Windows.Forms.CheckBox EmondayCheckBox;
        private System.Windows.Forms.Label WdlabelMin;
        private System.Windows.Forms.Label WDlabelHrs;
        private System.Windows.Forms.Label WDlabelN;
        private System.Windows.Forms.Label WDWorkingDays;
        private System.Windows.Forms.Label LCenter;
        private System.Windows.Forms.Label WDNoofWorking;
        private System.Windows.Forms.Button WDELabel3;
        private System.Windows.Forms.Button WDELabel2;
        private System.Windows.Forms.Button WDELabel1;
        private System.Windows.Forms.Label WDLablN;
        private System.Windows.Forms.Button WDETimeTable;
        private System.Windows.Forms.Button WDEStatistics;
        private System.Windows.Forms.Button WDELocations;
        private System.Windows.Forms.Button WDERoom;
        private System.Windows.Forms.Button WDEHome;
        private System.Windows.Forms.Button WDETag;
        private System.Windows.Forms.Button WDEWorking;
        private System.Windows.Forms.Button WDEAdvanced;
        private System.Windows.Forms.Button WDESession;
        private System.Windows.Forms.Button WDESubject;
        private System.Windows.Forms.Button WDEStudent;
        private System.Windows.Forms.Button WDELecturer;
        private System.Windows.Forms.Button WDEDELETE;
        private System.Windows.Forms.Button WDUPDATE;
        private System.Windows.Forms.ComboBox recordID;
        private System.Windows.Forms.Label WDlabel1;
    }
}