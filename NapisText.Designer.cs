namespace WindowsFormsApplication1
{
    partial class NapisText
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
            this.bKonec = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtbVstup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bKonec
            // 
            this.bKonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.bKonec.Location = new System.Drawing.Point(91, 355);
            this.bKonec.Name = "bKonec";
            this.bKonec.Size = new System.Drawing.Size(273, 98);
            this.bKonec.TabIndex = 0;
            this.bKonec.Text = "Konec";
            this.bKonec.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.bSave.Location = new System.Drawing.Point(605, 355);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(273, 98);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // rtbVstup
            // 
            this.rtbVstup.Location = new System.Drawing.Point(91, 44);
            this.rtbVstup.Name = "rtbVstup";
            this.rtbVstup.Size = new System.Drawing.Size(787, 20);
            this.rtbVstup.TabIndex = 2;
            // 
            // NapisText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 485);
            this.Controls.Add(this.rtbVstup);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bKonec);
            this.Name = "NapisText";
            this.Text = "NapisText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bKonec;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox rtbVstup;
    }
}