namespace WindowsFormsApplication1
{
    partial class kontrolaEmailu
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bOtevrit = new System.Windows.Forms.Button();
            this.bUlozit = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.bKonec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // bOtevrit
            // 
            this.bOtevrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.bOtevrit.Location = new System.Drawing.Point(70, 62);
            this.bOtevrit.Name = "bOtevrit";
            this.bOtevrit.Size = new System.Drawing.Size(154, 54);
            this.bOtevrit.TabIndex = 0;
            this.bOtevrit.Text = "Otevřít";
            this.bOtevrit.UseVisualStyleBackColor = true;
            this.bOtevrit.Click += new System.EventHandler(this.bOtevrit_Click);
            // 
            // bUlozit
            // 
            this.bUlozit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.bUlozit.Location = new System.Drawing.Point(70, 187);
            this.bUlozit.Name = "bUlozit";
            this.bUlozit.Size = new System.Drawing.Size(154, 54);
            this.bUlozit.TabIndex = 1;
            this.bUlozit.Text = "Uložit";
            this.bUlozit.UseVisualStyleBackColor = true;
            this.bUlozit.Click += new System.EventHandler(this.bUlozit_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(429, 62);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(415, 20);
            this.tbText.TabIndex = 2;
            // 
            // bKonec
            // 
            this.bKonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.bKonec.Location = new System.Drawing.Point(70, 313);
            this.bKonec.Name = "bKonec";
            this.bKonec.Size = new System.Drawing.Size(154, 54);
            this.bKonec.TabIndex = 3;
            this.bKonec.Text = "Konec";
            this.bKonec.UseVisualStyleBackColor = true;
            this.bKonec.Click += new System.EventHandler(this.bKonec_Click);
            // 
            // kontrolaEmailu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 431);
            this.Controls.Add(this.bKonec);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.bUlozit);
            this.Controls.Add(this.bOtevrit);
            this.Name = "kontrolaEmailu";
            this.Text = "kontrolaEmailu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bOtevrit;
        private System.Windows.Forms.Button bUlozit;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button bKonec;
    }
}