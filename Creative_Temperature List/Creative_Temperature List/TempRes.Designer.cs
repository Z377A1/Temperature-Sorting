namespace Creative_Temperature_List
{
    partial class TempRes
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
            this.lsbOutput = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSaved = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chbConfirm = new System.Windows.Forms.CheckBox();
            this.saveF = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lsbOutput
            // 
            this.lsbOutput.FormattingEnabled = true;
            this.lsbOutput.Location = new System.Drawing.Point(13, 23);
            this.lsbOutput.Name = "lsbOutput";
            this.lsbOutput.Size = new System.Drawing.Size(366, 290);
            this.lsbOutput.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(304, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSaved
            // 
            this.lblSaved.Location = new System.Drawing.Point(102, 343);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(72, 23);
            this.lblSaved.TabIndex = 10;
            this.lblSaved.Text = "Saved!";
            this.lblSaved.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chbConfirm
            // 
            this.chbConfirm.AutoSize = true;
            this.chbConfirm.Location = new System.Drawing.Point(12, 319);
            this.chbConfirm.Name = "chbConfirm";
            this.chbConfirm.Size = new System.Drawing.Size(155, 17);
            this.chbConfirm.TabIndex = 12;
            this.chbConfirm.Text = "Check box to confirm save.";
            this.chbConfirm.UseVisualStyleBackColor = true;
            // 
            // saveF
            // 
            this.saveF.FileName = "saveF";
            // 
            // TempRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 375);
            this.Controls.Add(this.chbConfirm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lsbOutput);
            this.Name = "TempRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TempRes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lsbOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.SaveFileDialog saveF;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.CheckBox chbConfirm;
    }
}