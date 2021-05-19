
namespace Project
{
    partial class WorkingDays_Hours
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
            this.WDCLEAR = new System.Windows.Forms.Button();
            this.WDADD = new System.Windows.Forms.Button();
            this.WDWorkingDays = new System.Windows.Forms.Label();
            this.LCenter = new System.Windows.Forms.Label();
            this.WDNoofWorking = new System.Windows.Forms.Label();
            this.WDLabel3 = new System.Windows.Forms.Button();
            this.WDLabel2 = new System.Windows.Forms.Button();
            this.WDLabel1 = new System.Windows.Forms.Button();
            this.WDLablN = new System.Windows.Forms.Label();
            this.WDTimeTable = new System.Windows.Forms.Button();
            this.WDStatistics = new System.Windows.Forms.Button();
            this.WDLocations = new System.Windows.Forms.Button();
            this.WDRoom = new System.Windows.Forms.Button();
            this.WDHome = new System.Windows.Forms.Button();
            this.WDTag = new System.Windows.Forms.Button();
            this.WDWorking = new System.Windows.Forms.Button();
            this.WDAdvanced = new System.Windows.Forms.Button();
            this.WDSession = new System.Windows.Forms.Button();
            this.WDSubject = new System.Windows.Forms.Button();
            this.WDStudent = new System.Windows.Forms.Button();
            this.WDLecturer = new System.Windows.Forms.Button();
            this.WDlabelN = new System.Windows.Forms.Label();
            this.WDlabelHrs = new System.Windows.Forms.Label();
            this.WdlabelMin = new System.Windows.Forms.Label();
            this.mondayCheckBox = new System.Windows.Forms.CheckBox();
            this.wednesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.tuesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.thursdayCheckBox = new System.Windows.Forms.CheckBox();
            this.fridayCheckBox = new System.Windows.Forms.CheckBox();
            this.saturdayheckBox = new System.Windows.Forms.CheckBox();
            this.sundayCheckBox = new System.Windows.Forms.CheckBox();
            this.noOfWorkingDays = new System.Windows.Forms.NumericUpDown();
            this.addHrs = new System.Windows.Forms.NumericUpDown();
            this.addMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.noOfWorkingDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMin)).BeginInit();
            this.SuspendLayout();
            // 
            // WDCLEAR
            // 
            this.WDCLEAR.BackColor = System.Drawing.Color.Red;
            this.WDCLEAR.Location = new System.Drawing.Point(632, 578);
            this.WDCLEAR.Name = "WDCLEAR";
            this.WDCLEAR.Size = new System.Drawing.Size(90, 35);
            this.WDCLEAR.TabIndex = 69;
            this.WDCLEAR.Text = "CLEAR";
            this.WDCLEAR.UseVisualStyleBackColor = false;
            // 
            // WDADD
            // 
            this.WDADD.BackColor = System.Drawing.Color.Blue;
            this.WDADD.Location = new System.Drawing.Point(520, 578);
            this.WDADD.Name = "WDADD";
            this.WDADD.Size = new System.Drawing.Size(90, 35);
            this.WDADD.TabIndex = 67;
            this.WDADD.Text = "ADD";
            this.WDADD.UseVisualStyleBackColor = false;
            this.WDADD.Click += new System.EventHandler(this.WDADD_Click);
            // 
            // WDWorkingDays
            // 
            this.WDWorkingDays.AutoSize = true;
            this.WDWorkingDays.Location = new System.Drawing.Point(167, 275);
            this.WDWorkingDays.Name = "WDWorkingDays";
            this.WDWorkingDays.Size = new System.Drawing.Size(96, 17);
            this.WDWorkingDays.TabIndex = 58;
            this.WDWorkingDays.Text = "Working Days";
            // 
            // LCenter
            // 
            this.LCenter.AutoSize = true;
            this.LCenter.Location = new System.Drawing.Point(166, 403);
            this.LCenter.Name = "LCenter";
            this.LCenter.Size = new System.Drawing.Size(150, 17);
            this.LCenter.TabIndex = 54;
            this.LCenter.Text = "Working Time Per Day";
            // 
            // WDNoofWorking
            // 
            this.WDNoofWorking.AutoSize = true;
            this.WDNoofWorking.Location = new System.Drawing.Point(166, 197);
            this.WDNoofWorking.Name = "WDNoofWorking";
            this.WDNoofWorking.Size = new System.Drawing.Size(138, 17);
            this.WDNoofWorking.TabIndex = 53;
            this.WDNoofWorking.Text = "No  of Working Days";
            // 
            // WDLabel3
            // 
            this.WDLabel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.WDLabel3.Location = new System.Drawing.Point(561, 91);
            this.WDLabel3.Name = "WDLabel3";
            this.WDLabel3.Size = new System.Drawing.Size(208, 35);
            this.WDLabel3.TabIndex = 50;
            this.WDLabel3.Text = "View Working Days & Hours";
            this.WDLabel3.UseVisualStyleBackColor = false;
            this.WDLabel3.Click += new System.EventHandler(this.WDLabel3_Click);
            // 
            // WDLabel2
            // 
            this.WDLabel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.WDLabel2.Location = new System.Drawing.Point(347, 90);
            this.WDLabel2.Name = "WDLabel2";
            this.WDLabel2.Size = new System.Drawing.Size(208, 35);
            this.WDLabel2.TabIndex = 49;
            this.WDLabel2.Text = "Edit Working Days & Hours";
            this.WDLabel2.UseVisualStyleBackColor = false;
            this.WDLabel2.Click += new System.EventHandler(this.WDLabel2_Click);
            // 
            // WDLabel1
            // 
            this.WDLabel1.BackColor = System.Drawing.Color.Crimson;
            this.WDLabel1.Location = new System.Drawing.Point(133, 91);
            this.WDLabel1.Name = "WDLabel1";
            this.WDLabel1.Size = new System.Drawing.Size(208, 35);
            this.WDLabel1.TabIndex = 48;
            this.WDLabel1.Text = "Add Working Days & Hours";
            this.WDLabel1.UseVisualStyleBackColor = false;
            // 
            // WDLablN
            // 
            this.WDLablN.AutoSize = true;
            this.WDLablN.BackColor = System.Drawing.Color.Blue;
            this.WDLablN.Location = new System.Drawing.Point(30, 24);
            this.WDLablN.Name = "WDLablN";
            this.WDLablN.Size = new System.Drawing.Size(96, 17);
            this.WDLablN.TabIndex = 47;
            this.WDLablN.Text = "Working Days";
            // 
            // WDTimeTable
            // 
            this.WDTimeTable.Location = new System.Drawing.Point(738, 12);
            this.WDTimeTable.Name = "WDTimeTable";
            this.WDTimeTable.Size = new System.Drawing.Size(104, 72);
            this.WDTimeTable.TabIndex = 46;
            this.WDTimeTable.Text = "Time Table";
            this.WDTimeTable.UseVisualStyleBackColor = true;
            // 
            // WDStatistics
            // 
            this.WDStatistics.Location = new System.Drawing.Point(587, 12);
            this.WDStatistics.Name = "WDStatistics";
            this.WDStatistics.Size = new System.Drawing.Size(104, 72);
            this.WDStatistics.TabIndex = 45;
            this.WDStatistics.Text = "Statistics";
            this.WDStatistics.UseVisualStyleBackColor = true;
            // 
            // WDLocations
            // 
            this.WDLocations.Location = new System.Drawing.Point(438, 12);
            this.WDLocations.Name = "WDLocations";
            this.WDLocations.Size = new System.Drawing.Size(104, 72);
            this.WDLocations.TabIndex = 44;
            this.WDLocations.Text = "Location";
            this.WDLocations.UseVisualStyleBackColor = true;
            // 
            // WDRoom
            // 
            this.WDRoom.Location = new System.Drawing.Point(280, 12);
            this.WDRoom.Name = "WDRoom";
            this.WDRoom.Size = new System.Drawing.Size(104, 72);
            this.WDRoom.TabIndex = 43;
            this.WDRoom.Text = "Room";
            this.WDRoom.UseVisualStyleBackColor = true;
            // 
            // WDHome
            // 
            this.WDHome.Location = new System.Drawing.Point(132, 12);
            this.WDHome.Name = "WDHome";
            this.WDHome.Size = new System.Drawing.Size(104, 72);
            this.WDHome.TabIndex = 42;
            this.WDHome.Text = "Home";
            this.WDHome.UseVisualStyleBackColor = true;
            // 
            // WDTag
            // 
            this.WDTag.Location = new System.Drawing.Point(23, 325);
            this.WDTag.Name = "WDTag";
            this.WDTag.Size = new System.Drawing.Size(104, 72);
            this.WDTag.TabIndex = 41;
            this.WDTag.Text = "Tag";
            this.WDTag.UseVisualStyleBackColor = true;
            // 
            // WDWorking
            // 
            this.WDWorking.Location = new System.Drawing.Point(23, 559);
            this.WDWorking.Name = "WDWorking";
            this.WDWorking.Size = new System.Drawing.Size(104, 72);
            this.WDWorking.TabIndex = 40;
            this.WDWorking.Text = "Working Days and Hours";
            this.WDWorking.UseVisualStyleBackColor = true;
            // 
            // WDAdvanced
            // 
            this.WDAdvanced.Location = new System.Drawing.Point(23, 481);
            this.WDAdvanced.Name = "WDAdvanced";
            this.WDAdvanced.Size = new System.Drawing.Size(104, 72);
            this.WDAdvanced.TabIndex = 39;
            this.WDAdvanced.Text = "Advanced Session";
            this.WDAdvanced.UseVisualStyleBackColor = true;
            // 
            // WDSession
            // 
            this.WDSession.Location = new System.Drawing.Point(23, 403);
            this.WDSession.Name = "WDSession";
            this.WDSession.Size = new System.Drawing.Size(104, 72);
            this.WDSession.TabIndex = 38;
            this.WDSession.Text = "Session";
            this.WDSession.UseVisualStyleBackColor = true;
            // 
            // WDSubject
            // 
            this.WDSubject.Location = new System.Drawing.Point(23, 247);
            this.WDSubject.Name = "WDSubject";
            this.WDSubject.Size = new System.Drawing.Size(104, 72);
            this.WDSubject.TabIndex = 37;
            this.WDSubject.Text = "Subject";
            this.WDSubject.UseVisualStyleBackColor = true;
            // 
            // WDStudent
            // 
            this.WDStudent.Location = new System.Drawing.Point(23, 169);
            this.WDStudent.Name = "WDStudent";
            this.WDStudent.Size = new System.Drawing.Size(104, 72);
            this.WDStudent.TabIndex = 36;
            this.WDStudent.Text = "Student";
            this.WDStudent.UseVisualStyleBackColor = true;
            // 
            // WDLecturer
            // 
            this.WDLecturer.Location = new System.Drawing.Point(23, 91);
            this.WDLecturer.Name = "WDLecturer";
            this.WDLecturer.Size = new System.Drawing.Size(104, 72);
            this.WDLecturer.TabIndex = 35;
            this.WDLecturer.Text = "Lecturer";
            this.WDLecturer.UseVisualStyleBackColor = true;
            // 
            // WDlabelN
            // 
            this.WDlabelN.AutoSize = true;
            this.WDlabelN.BackColor = System.Drawing.Color.Blue;
            this.WDlabelN.Location = new System.Drawing.Point(31, 50);
            this.WDlabelN.Name = "WDlabelN";
            this.WDlabelN.Size = new System.Drawing.Size(75, 17);
            this.WDlabelN.TabIndex = 70;
            this.WDlabelN.Text = "And Hours";
            // 
            // WDlabelHrs
            // 
            this.WDlabelHrs.AutoSize = true;
            this.WDlabelHrs.Location = new System.Drawing.Point(480, 396);
            this.WDlabelHrs.Name = "WDlabelHrs";
            this.WDlabelHrs.Size = new System.Drawing.Size(30, 17);
            this.WDlabelHrs.TabIndex = 71;
            this.WDlabelHrs.Text = "Hrs";
            // 
            // WdlabelMin
            // 
            this.WdlabelMin.AutoSize = true;
            this.WdlabelMin.Location = new System.Drawing.Point(666, 399);
            this.WdlabelMin.Name = "WdlabelMin";
            this.WdlabelMin.Size = new System.Drawing.Size(30, 17);
            this.WdlabelMin.TabIndex = 73;
            this.WdlabelMin.Text = "Min";
            // 
            // mondayCheckBox
            // 
            this.mondayCheckBox.AutoSize = true;
            this.mondayCheckBox.Location = new System.Drawing.Point(346, 277);
            this.mondayCheckBox.Name = "mondayCheckBox";
            this.mondayCheckBox.Size = new System.Drawing.Size(80, 21);
            this.mondayCheckBox.TabIndex = 75;
            this.mondayCheckBox.Text = "Monday";
            this.mondayCheckBox.UseVisualStyleBackColor = true;
            this.mondayCheckBox.CheckedChanged += new System.EventHandler(this.WDcheckBox1_CheckedChanged);
            // 
            // wednesdayCheckBox
            // 
            this.wednesdayCheckBox.AutoSize = true;
            this.wednesdayCheckBox.Location = new System.Drawing.Point(561, 277);
            this.wednesdayCheckBox.Name = "wednesdayCheckBox";
            this.wednesdayCheckBox.Size = new System.Drawing.Size(105, 21);
            this.wednesdayCheckBox.TabIndex = 76;
            this.wednesdayCheckBox.Text = "Wednesday";
            this.wednesdayCheckBox.UseVisualStyleBackColor = true;
            this.wednesdayCheckBox.CheckedChanged += new System.EventHandler(this.WDcheckBox3_CheckedChanged);
            // 
            // tuesdayCheckBox
            // 
            this.tuesdayCheckBox.AutoSize = true;
            this.tuesdayCheckBox.Location = new System.Drawing.Point(457, 277);
            this.tuesdayCheckBox.Name = "tuesdayCheckBox";
            this.tuesdayCheckBox.Size = new System.Drawing.Size(85, 21);
            this.tuesdayCheckBox.TabIndex = 77;
            this.tuesdayCheckBox.Text = "Tuesday";
            this.tuesdayCheckBox.UseVisualStyleBackColor = true;
            this.tuesdayCheckBox.CheckedChanged += new System.EventHandler(this.tuesdayCheckBox_CheckedChanged);
            // 
            // thursdayCheckBox
            // 
            this.thursdayCheckBox.AutoSize = true;
            this.thursdayCheckBox.Location = new System.Drawing.Point(665, 275);
            this.thursdayCheckBox.Name = "thursdayCheckBox";
            this.thursdayCheckBox.Size = new System.Drawing.Size(90, 21);
            this.thursdayCheckBox.TabIndex = 78;
            this.thursdayCheckBox.Text = "Thursday";
            this.thursdayCheckBox.UseVisualStyleBackColor = true;
            this.thursdayCheckBox.CheckedChanged += new System.EventHandler(this.thursdayCheckBox_CheckedChanged);
            // 
            // fridayCheckBox
            // 
            this.fridayCheckBox.AutoSize = true;
            this.fridayCheckBox.Location = new System.Drawing.Point(347, 325);
            this.fridayCheckBox.Name = "fridayCheckBox";
            this.fridayCheckBox.Size = new System.Drawing.Size(69, 21);
            this.fridayCheckBox.TabIndex = 79;
            this.fridayCheckBox.Text = "Friday";
            this.fridayCheckBox.UseVisualStyleBackColor = true;
            this.fridayCheckBox.CheckedChanged += new System.EventHandler(this.fridayCheckBox_CheckedChanged);
            // 
            // saturdayheckBox
            // 
            this.saturdayheckBox.AutoSize = true;
            this.saturdayheckBox.Location = new System.Drawing.Point(457, 325);
            this.saturdayheckBox.Name = "saturdayheckBox";
            this.saturdayheckBox.Size = new System.Drawing.Size(87, 21);
            this.saturdayheckBox.TabIndex = 80;
            this.saturdayheckBox.Text = "Saturday";
            this.saturdayheckBox.UseVisualStyleBackColor = true;
            this.saturdayheckBox.CheckedChanged += new System.EventHandler(this.saturdayheckBox_CheckedChanged);
            // 
            // sundayCheckBox
            // 
            this.sundayCheckBox.AutoSize = true;
            this.sundayCheckBox.Location = new System.Drawing.Point(562, 325);
            this.sundayCheckBox.Name = "sundayCheckBox";
            this.sundayCheckBox.Size = new System.Drawing.Size(78, 21);
            this.sundayCheckBox.TabIndex = 81;
            this.sundayCheckBox.Text = "Sunday";
            this.sundayCheckBox.UseVisualStyleBackColor = true;
            this.sundayCheckBox.CheckedChanged += new System.EventHandler(this.WDcheckBox7_CheckedChanged);
            // 
            // noOfWorkingDays
            // 
            this.noOfWorkingDays.Location = new System.Drawing.Point(347, 195);
            this.noOfWorkingDays.Name = "noOfWorkingDays";
            this.noOfWorkingDays.Size = new System.Drawing.Size(119, 22);
            this.noOfWorkingDays.TabIndex = 82;
            // 
            // addHrs
            // 
            this.addHrs.Location = new System.Drawing.Point(347, 403);
            this.addHrs.Name = "addHrs";
            this.addHrs.Size = new System.Drawing.Size(120, 22);
            this.addHrs.TabIndex = 83;
            // 
            // addMin
            // 
            this.addMin.Location = new System.Drawing.Point(540, 403);
            this.addMin.Name = "addMin";
            this.addMin.Size = new System.Drawing.Size(120, 22);
            this.addMin.TabIndex = 84;
            // 
            // WorkingDays_Hours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 643);
            this.Controls.Add(this.addMin);
            this.Controls.Add(this.addHrs);
            this.Controls.Add(this.noOfWorkingDays);
            this.Controls.Add(this.sundayCheckBox);
            this.Controls.Add(this.saturdayheckBox);
            this.Controls.Add(this.fridayCheckBox);
            this.Controls.Add(this.thursdayCheckBox);
            this.Controls.Add(this.tuesdayCheckBox);
            this.Controls.Add(this.wednesdayCheckBox);
            this.Controls.Add(this.mondayCheckBox);
            this.Controls.Add(this.WdlabelMin);
            this.Controls.Add(this.WDlabelHrs);
            this.Controls.Add(this.WDlabelN);
            this.Controls.Add(this.WDCLEAR);
            this.Controls.Add(this.WDADD);
            this.Controls.Add(this.WDWorkingDays);
            this.Controls.Add(this.LCenter);
            this.Controls.Add(this.WDNoofWorking);
            this.Controls.Add(this.WDLabel3);
            this.Controls.Add(this.WDLabel2);
            this.Controls.Add(this.WDLabel1);
            this.Controls.Add(this.WDLablN);
            this.Controls.Add(this.WDTimeTable);
            this.Controls.Add(this.WDStatistics);
            this.Controls.Add(this.WDLocations);
            this.Controls.Add(this.WDRoom);
            this.Controls.Add(this.WDHome);
            this.Controls.Add(this.WDTag);
            this.Controls.Add(this.WDWorking);
            this.Controls.Add(this.WDAdvanced);
            this.Controls.Add(this.WDSession);
            this.Controls.Add(this.WDSubject);
            this.Controls.Add(this.WDStudent);
            this.Controls.Add(this.WDLecturer);
            this.Name = "WorkingDays_Hours";
            this.Text = "WorkingDays_Hours";
            ((System.ComponentModel.ISupportInitialize)(this.noOfWorkingDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WDCLEAR;
        private System.Windows.Forms.Button WDADD;
        private System.Windows.Forms.Label WDWorkingDays;
        private System.Windows.Forms.Label LCenter;
        private System.Windows.Forms.Label WDNoofWorking;
        private System.Windows.Forms.Button WDLabel3;
        private System.Windows.Forms.Button WDLabel2;
        private System.Windows.Forms.Button WDLabel1;
        private System.Windows.Forms.Label WDLablN;
        private System.Windows.Forms.Button WDTimeTable;
        private System.Windows.Forms.Button WDStatistics;
        private System.Windows.Forms.Button WDLocations;
        private System.Windows.Forms.Button WDRoom;
        private System.Windows.Forms.Button WDHome;
        private System.Windows.Forms.Button WDTag;
        private System.Windows.Forms.Button WDWorking;
        private System.Windows.Forms.Button WDAdvanced;
        private System.Windows.Forms.Button WDSession;
        private System.Windows.Forms.Button WDSubject;
        private System.Windows.Forms.Button WDStudent;
        private System.Windows.Forms.Button WDLecturer;
        private System.Windows.Forms.Label WDlabelN;
        private System.Windows.Forms.Label WDlabelHrs;
        private System.Windows.Forms.Label WdlabelMin;
        private System.Windows.Forms.CheckBox mondayCheckBox;
        private System.Windows.Forms.CheckBox wednesdayCheckBox;
        private System.Windows.Forms.CheckBox tuesdayCheckBox;
        private System.Windows.Forms.CheckBox thursdayCheckBox;
        private System.Windows.Forms.CheckBox fridayCheckBox;
        private System.Windows.Forms.CheckBox saturdayheckBox;
        private System.Windows.Forms.CheckBox sundayCheckBox;
        private System.Windows.Forms.NumericUpDown noOfWorkingDays;
        private System.Windows.Forms.NumericUpDown addHrs;
        private System.Windows.Forms.NumericUpDown addMin;
    }
}