namespace Session_10 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnLoadDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadDefault
            // 
            this.btnLoadDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoadDefault.Location = new System.Drawing.Point(116, 388);
            this.btnLoadDefault.Name = "btnLoadDefault";
            this.btnLoadDefault.Size = new System.Drawing.Size(131, 47);
            this.btnLoadDefault.TabIndex = 0;
            this.btnLoadDefault.Text = "Load Default";
            this.btnLoadDefault.UseVisualStyleBackColor = true;
            this.btnLoadDefault.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 481);
            this.Controls.Add(this.btnLoadDefault);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLoadDefault;
    }
}