namespace Session_10 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dvgStudents = new System.Windows.Forms.DataGridView();
            this.dvgGrades = new System.Windows.Forms.DataGridView();
            this.dvgCourses = new System.Windows.Forms.DataGridView();
            this.dvgScheduledCourses = new System.Windows.Forms.DataGridView();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgScheduledCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgStudents
            // 
            this.dvgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudents.Location = new System.Drawing.Point(63, 23);
            this.dvgStudents.Name = "dvgStudents";
            this.dvgStudents.RowTemplate.Height = 25;
            this.dvgStudents.Size = new System.Drawing.Size(513, 194);
            this.dvgStudents.TabIndex = 0;
            // 
            // dvgGrades
            // 
            this.dvgGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGrades.Location = new System.Drawing.Point(691, 23);
            this.dvgGrades.Name = "dvgGrades";
            this.dvgGrades.RowTemplate.Height = 25;
            this.dvgGrades.Size = new System.Drawing.Size(609, 194);
            this.dvgGrades.TabIndex = 1;
            // 
            // dvgCourses
            // 
            this.dvgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCourses.Location = new System.Drawing.Point(63, 274);
            this.dvgCourses.Name = "dvgCourses";
            this.dvgCourses.RowTemplate.Height = 25;
            this.dvgCourses.Size = new System.Drawing.Size(513, 186);
            this.dvgCourses.TabIndex = 2;
            // 
            // dvgScheduledCourses
            // 
            this.dvgScheduledCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgScheduledCourses.Location = new System.Drawing.Point(691, 274);
            this.dvgScheduledCourses.Name = "dvgScheduledCourses";
            this.dvgScheduledCourses.RowTemplate.Height = 25;
            this.dvgScheduledCourses.Size = new System.Drawing.Size(609, 186);
            this.dvgScheduledCourses.TabIndex = 3;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(234, 509);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(128, 46);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "Generate Default.";
            this.btnDefault.UseVisualStyleBackColor = true;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(569, 509);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(107, 47);
            this.btnLoadFile.TabIndex = 5;
            this.btnLoadFile.Text = "Load from File.";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(969, 518);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(133, 38);
            this.btnSaveToFile.TabIndex = 6;
            this.btnSaveToFile.Text = "Save to File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 596);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.dvgScheduledCourses);
            this.Controls.Add(this.dvgCourses);
            this.Controls.Add(this.dvgGrades);
            this.Controls.Add(this.dvgStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgScheduledCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dvgStudents;
        private DataGridView dvgGrades;
        private DataGridView dvgCourses;
        private DataGridView dvgScheduledCourses;
        private Button btnDefault;
        private Button btnLoadFile;
        private Button btnSaveToFile;
    }
}