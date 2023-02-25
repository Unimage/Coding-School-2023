namespace FuelStation.Win {
    partial class SelectedTransactionDetailsF {
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
            this.components = new System.ComponentModel.Container();
            this.grvTransLines = new System.Windows.Forms.DataGridView();
            this.bsTransLines = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLines)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTransLines
            // 
            this.grvTransLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransLines.Location = new System.Drawing.Point(246, 114);
            this.grvTransLines.Name = "grvTransLines";
            this.grvTransLines.RowTemplate.Height = 25;
            this.grvTransLines.Size = new System.Drawing.Size(240, 150);
            this.grvTransLines.TabIndex = 0;
            // 
            // SelectedTransactionDetailsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grvTransLines);
            this.Name = "SelectedTransactionDetailsF";
            this.Text = "SelectedTransactionDetailsF";
            this.Load += new System.EventHandler(this.SelectedTransactionDetailsF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grvTransLines;
        private BindingSource bsTransLines;
    }
}