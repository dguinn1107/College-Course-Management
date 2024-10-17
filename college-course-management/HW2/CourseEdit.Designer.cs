namespace CollegeCourseManagement
{
    partial class CourseEdit
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
            this.courseIdtextbox = new System.Windows.Forms.TextBox();
            this.titleCoursetextbox = new System.Windows.Forms.TextBox();
            this.totalCoursehrsbox = new System.Windows.Forms.TextBox();
            this.Days_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeOfclassbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addCourseButoon = new System.Windows.Forms.Button();
            this.deleteCourseButton = new System.Windows.Forms.Button();
            this.courseDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.semesterOfferedbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseIdtextbox
            // 
            this.courseIdtextbox.Location = new System.Drawing.Point(6, 47);
            this.courseIdtextbox.Name = "courseIdtextbox";
            this.courseIdtextbox.Size = new System.Drawing.Size(100, 22);
            this.courseIdtextbox.TabIndex = 0;
            // 
            // titleCoursetextbox
            // 
            this.titleCoursetextbox.Location = new System.Drawing.Point(134, 47);
            this.titleCoursetextbox.Name = "titleCoursetextbox";
            this.titleCoursetextbox.Size = new System.Drawing.Size(100, 22);
            this.titleCoursetextbox.TabIndex = 1;
            // 
            // totalCoursehrsbox
            // 
            this.totalCoursehrsbox.Location = new System.Drawing.Point(9, 113);
            this.totalCoursehrsbox.Name = "totalCoursehrsbox";
            this.totalCoursehrsbox.Size = new System.Drawing.Size(100, 22);
            this.totalCoursehrsbox.TabIndex = 2;
            // 
            // Days_CheckedListBox
            // 
            this.Days_CheckedListBox.FormattingEnabled = true;
            this.Days_CheckedListBox.Items.AddRange(new object[] {
            "Tue",
            "Fri",
            "TTh",
            "MWF",
            "Online"});
            this.Days_CheckedListBox.Location = new System.Drawing.Point(265, 113);
            this.Days_CheckedListBox.Name = "Days_CheckedListBox";
            this.Days_CheckedListBox.Size = new System.Drawing.Size(159, 55);
            this.Days_CheckedListBox.TabIndex = 3;
            this.Days_CheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title of Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Course Hrs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course Days";
            // 
            // timeOfclassbox
            // 
            this.timeOfclassbox.Location = new System.Drawing.Point(134, 113);
            this.timeOfclassbox.Name = "timeOfclassbox";
            this.timeOfclassbox.Size = new System.Drawing.Size(100, 22);
            this.timeOfclassbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time of Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "hh:mm AM/PM";
            // 
            // addCourseButoon
            // 
            this.addCourseButoon.Location = new System.Drawing.Point(21, 462);
            this.addCourseButoon.Name = "addCourseButoon";
            this.addCourseButoon.Size = new System.Drawing.Size(75, 23);
            this.addCourseButoon.TabIndex = 13;
            this.addCourseButoon.Text = "Add";
            this.addCourseButoon.UseVisualStyleBackColor = true;
            this.addCourseButoon.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Location = new System.Drawing.Point(21, 491);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCourseButton.TabIndex = 14;
            this.deleteCourseButton.Text = "Delete";
            this.deleteCourseButton.UseVisualStyleBackColor = true;
            this.deleteCourseButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // courseDataGrid
            // 
            this.courseDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.courseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.courseDataGrid.Location = new System.Drawing.Point(525, 21);
            this.courseDataGrid.Name = "courseDataGrid";
            this.courseDataGrid.RowHeadersWidth = 51;
            this.courseDataGrid.RowTemplate.Height = 24;
            this.courseDataGrid.Size = new System.Drawing.Size(558, 330);
            this.courseDataGrid.TabIndex = 15;
            this.courseDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.semesterOfferedbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.courseIdtextbox);
            this.groupBox1.Controls.Add(this.titleCoursetextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Days_CheckedListBox);
            this.groupBox1.Controls.Add(this.totalCoursehrsbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timeOfclassbox);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 330);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Semester Offered";
            // 
            // semesterOfferedbox
            // 
            this.semesterOfferedbox.Location = new System.Drawing.Point(265, 47);
            this.semesterOfferedbox.Name = "semesterOfferedbox";
            this.semesterOfferedbox.Size = new System.Drawing.Size(100, 22);
            this.semesterOfferedbox.TabIndex = 13;
            // 
            // CourseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.courseDataGrid);
            this.Controls.Add(this.deleteCourseButton);
            this.Controls.Add(this.addCourseButoon);
            this.Name = "CourseEdit";
            this.Size = new System.Drawing.Size(1100, 547);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox courseIdtextbox;
        private System.Windows.Forms.TextBox titleCoursetextbox;
        private System.Windows.Forms.TextBox totalCoursehrsbox;
        private System.Windows.Forms.CheckedListBox Days_CheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeOfclassbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addCourseButoon;
        private System.Windows.Forms.Button deleteCourseButton;
        private System.Windows.Forms.DataGridView courseDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox semesterOfferedbox;
    }
}

