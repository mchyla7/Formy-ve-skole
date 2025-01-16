namespace WindowsFormsApplication1
{
    partial class nacitaniZeSouboru
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
            this.bOtevrit = new System.Windows.Forms.Button();
            this.bKonec = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // bOtevrit
            // 
            this.bOtevrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.bOtevrit.Location = new System.Drawing.Point(85, 68);
            this.bOtevrit.Name = "bOtevrit";
            this.bOtevrit.Size = new System.Drawing.Size(137, 40);
            this.bOtevrit.TabIndex = 0;
            this.bOtevrit.Text = "Otevřít";
            this.bOtevrit.UseVisualStyleBackColor = true;
            this.bOtevrit.Click += new System.EventHandler(this.bOtevrit_Click);
            // 
            // bKonec
            // 
            this.bKonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.bKonec.Location = new System.Drawing.Point(39, 365);
            this.bKonec.Name = "bKonec";
            this.bKonec.Size = new System.Drawing.Size(119, 38);
            this.bKonec.TabIndex = 1;
            this.bKonec.Text = "Konec";
            this.bKonec.UseVisualStyleBackColor = true;
            this.bKonec.Click += new System.EventHandler(this.bKonec_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(505, 130);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(436, 20);
            this.tbText.TabIndex = 2;
            // 
            // nacitaniZeSouboru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 443);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.bKonec);
            this.Controls.Add(this.bOtevrit);
            this.Name = "nacitaniZeSouboru";
            this.Text = "nacitaniZeSouboru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bOtevrit;
        private System.Windows.Forms.Button bKonec;
        private System.Windows.Forms.TextBox tbText;
    }
}