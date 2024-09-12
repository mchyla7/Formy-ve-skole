namespace WindowsFormsApplication1
{
    partial class Kalkulacka
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
            this.a = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.tbVysledek = new System.Windows.Forms.TextBox();
            this.rbSoucet = new System.Windows.Forms.RadioButton();
            this.rbSoucin = new System.Windows.Forms.RadioButton();
            this.bVysledek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(66, 86);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(14, 13);
            this.a.TabIndex = 0;
            this.a.Text = "A";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(110, 86);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 1;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(110, 125);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 2;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(66, 128);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(14, 13);
            this.b.TabIndex = 3;
            this.b.Text = "B";
            // 
            // tbVysledek
            // 
            this.tbVysledek.Location = new System.Drawing.Point(69, 190);
            this.tbVysledek.Name = "tbVysledek";
            this.tbVysledek.Size = new System.Drawing.Size(141, 20);
            this.tbVysledek.TabIndex = 4;
            // 
            // rbSoucet
            // 
            this.rbSoucet.AutoSize = true;
            this.rbSoucet.Location = new System.Drawing.Point(322, 86);
            this.rbSoucet.Name = "rbSoucet";
            this.rbSoucet.Size = new System.Drawing.Size(59, 17);
            this.rbSoucet.TabIndex = 5;
            this.rbSoucet.TabStop = true;
            this.rbSoucet.Text = "Součet";
            this.rbSoucet.UseVisualStyleBackColor = true;
            this.rbSoucet.CheckedChanged += new System.EventHandler(this.rbSoucet_CheckedChanged);
            // 
            // rbSoucin
            // 
            this.rbSoucin.AutoSize = true;
            this.rbSoucin.Location = new System.Drawing.Point(322, 128);
            this.rbSoucin.Name = "rbSoucin";
            this.rbSoucin.Size = new System.Drawing.Size(58, 17);
            this.rbSoucin.TabIndex = 6;
            this.rbSoucin.TabStop = true;
            this.rbSoucin.Text = "Součin";
            this.rbSoucin.UseVisualStyleBackColor = true;
            this.rbSoucin.CheckedChanged += new System.EventHandler(this.rbSoucin_CheckedChanged);
            // 
            // bVysledek
            // 
            this.bVysledek.Location = new System.Drawing.Point(69, 280);
            this.bVysledek.Name = "bVysledek";
            this.bVysledek.Size = new System.Drawing.Size(75, 23);
            this.bVysledek.TabIndex = 7;
            this.bVysledek.Text = "Výsledek";
            this.bVysledek.UseVisualStyleBackColor = true;
            this.bVysledek.Click += new System.EventHandler(this.bVysledek_Click);
            // 
            // Kalkulacka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 452);
            this.Controls.Add(this.bVysledek);
            this.Controls.Add(this.rbSoucin);
            this.Controls.Add(this.rbSoucet);
            this.Controls.Add(this.tbVysledek);
            this.Controls.Add(this.b);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.a);
            this.Name = "Kalkulacka";
            this.Text = "Kalkulačka";
            this.Load += new System.EventHandler(this.Kalkulacka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox tbVysledek;
        private System.Windows.Forms.RadioButton rbSoucet;
        private System.Windows.Forms.RadioButton rbSoucin;
        private System.Windows.Forms.Button bVysledek;
    }
}