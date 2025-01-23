namespace WindowsFormsApplication1
{
    partial class mailsss
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bOpen = new System.Windows.Forms.Button();
            this.bUlozit = new System.Windows.Forms.Button();
            this.tbJmenoSouboru = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(391, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 200);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // bOpen
            // 
            this.bOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.bOpen.Location = new System.Drawing.Point(75, 56);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(108, 36);
            this.bOpen.TabIndex = 1;
            this.bOpen.Text = "Otevřít";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bUlozit
            // 
            this.bUlozit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.bUlozit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bUlozit.Location = new System.Drawing.Point(75, 220);
            this.bUlozit.Name = "bUlozit";
            this.bUlozit.Size = new System.Drawing.Size(108, 36);
            this.bUlozit.TabIndex = 2;
            this.bUlozit.Text = "Uložit";
            this.bUlozit.UseVisualStyleBackColor = true;
            this.bUlozit.Click += new System.EventHandler(this.bUlozit_Click);
            // 
            // tbJmenoSouboru
            // 
            this.tbJmenoSouboru.Location = new System.Drawing.Point(75, 277);
            this.tbJmenoSouboru.Name = "tbJmenoSouboru";
            this.tbJmenoSouboru.Size = new System.Drawing.Size(209, 20);
            this.tbJmenoSouboru.TabIndex = 3;
            // 
            // mailsss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.tbJmenoSouboru);
            this.Controls.Add(this.bUlozit);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.richTextBox1);
            this.Name = "mailsss";
            this.Text = "mailsss";
            this.Load += new System.EventHandler(this.mailsss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button bUlozit;

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.TextBox tbJmenoSouboru;
    }
}