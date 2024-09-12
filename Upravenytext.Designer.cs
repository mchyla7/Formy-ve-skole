namespace WindowsFormsApplication1
{
    partial class Upravenytext
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
            this.lZadejText = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lUpravenyText = new System.Windows.Forms.Label();
            this.bZadani = new System.Windows.Forms.Button();
            this.bKonec = new System.Windows.Forms.Button();
            this.tbVysledek = new System.Windows.Forms.TextBox();
            this.bPal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lZadejText
            // 
            this.lZadejText.AutoSize = true;
            this.lZadejText.Location = new System.Drawing.Point(27, 73);
            this.lZadejText.Name = "lZadejText";
            this.lZadejText.Size = new System.Drawing.Size(63, 13);
            this.lZadejText.TabIndex = 0;
            this.lZadejText.Text = "Zadejte text";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(114, 66);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(284, 20);
            this.tbText.TabIndex = 1;
            // 
            // lUpravenyText
            // 
            this.lUpravenyText.AutoSize = true;
            this.lUpravenyText.Location = new System.Drawing.Point(30, 135);
            this.lUpravenyText.Name = "lUpravenyText";
            this.lUpravenyText.Size = new System.Drawing.Size(73, 13);
            this.lUpravenyText.TabIndex = 2;
            this.lUpravenyText.Text = "Upravený text";
            // 
            // bZadani
            // 
            this.bZadani.Location = new System.Drawing.Point(395, 200);
            this.bZadani.Name = "bZadani";
            this.bZadani.Size = new System.Drawing.Size(75, 23);
            this.bZadani.TabIndex = 3;
            this.bZadani.Text = "Zadání";
            this.bZadani.UseVisualStyleBackColor = true;
            this.bZadani.Click += new System.EventHandler(this.button1_Click);
            // 
            // bKonec
            // 
            this.bKonec.Location = new System.Drawing.Point(30, 199);
            this.bKonec.Name = "bKonec";
            this.bKonec.Size = new System.Drawing.Size(75, 23);
            this.bKonec.TabIndex = 4;
            this.bKonec.Text = "Konec";
            this.bKonec.UseVisualStyleBackColor = true;
            this.bKonec.Click += new System.EventHandler(this.bKonec_Click);
            // 
            // tbVysledek
            // 
            this.tbVysledek.Location = new System.Drawing.Point(139, 127);
            this.tbVysledek.Name = "tbVysledek";
            this.tbVysledek.Size = new System.Drawing.Size(219, 20);
            this.tbVysledek.TabIndex = 5;
            this.tbVysledek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bPal
            // 
            this.bPal.Location = new System.Drawing.Point(219, 199);
            this.bPal.Name = "bPal";
            this.bPal.Size = new System.Drawing.Size(75, 23);
            this.bPal.TabIndex = 6;
            this.bPal.Text = "PAL!";
            this.bPal.UseVisualStyleBackColor = true;
            this.bPal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Upravenytext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(510, 261);
            this.Controls.Add(this.bPal);
            this.Controls.Add(this.tbVysledek);
            this.Controls.Add(this.bKonec);
            this.Controls.Add(this.bZadani);
            this.Controls.Add(this.lUpravenyText);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lZadejText);
            this.Name = "Upravenytext";
            this.Text = "Upravenytext";
            this.Load += new System.EventHandler(this.Upravenytext_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lZadejText;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lUpravenyText;
        private System.Windows.Forms.Button bZadani;
        private System.Windows.Forms.Button bKonec;
        private System.Windows.Forms.TextBox tbVysledek;
        private System.Windows.Forms.Button bPal;
    }
}