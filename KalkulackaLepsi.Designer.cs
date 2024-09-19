namespace WindowsFormsApplication1
{
    partial class KalkulackaLepsi
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
            this.bVypocitej = new System.Windows.Forms.Button();
            this.cbZnak = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lVysledek = new System.Windows.Forms.Label();
            this.nudCislo1 = new System.Windows.Forms.NumericUpDown();
            this.nudCislo2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCislo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCislo2)).BeginInit();
            this.SuspendLayout();
            // 
            // bVypocitej
            // 
            this.bVypocitej.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.bVypocitej.Location = new System.Drawing.Point(126, 119);
            this.bVypocitej.Name = "bVypocitej";
            this.bVypocitej.Size = new System.Drawing.Size(300, 128);
            this.bVypocitej.TabIndex = 0;
            this.bVypocitej.Text = "Vypočítej";
            this.bVypocitej.UseVisualStyleBackColor = true;
            this.bVypocitej.Click += new System.EventHandler(this.bVypocitej_Click);
            // 
            // cbZnak
            // 
            this.cbZnak.FormattingEnabled = true;
            this.cbZnak.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbZnak.Location = new System.Drawing.Point(158, 45);
            this.cbZnak.Name = "cbZnak";
            this.cbZnak.Size = new System.Drawing.Size(67, 21);
            this.cbZnak.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // lVysledek
            // 
            this.lVysledek.AutoSize = true;
            this.lVysledek.Location = new System.Drawing.Point(426, 48);
            this.lVysledek.Name = "lVysledek";
            this.lVysledek.Size = new System.Drawing.Size(50, 13);
            this.lVysledek.TabIndex = 3;
            this.lVysledek.Text = "Výsledek";
            // 
            // nudCislo1
            // 
            this.nudCislo1.Location = new System.Drawing.Point(27, 46);
            this.nudCislo1.Name = "nudCislo1";
            this.nudCislo1.Size = new System.Drawing.Size(98, 20);
            this.nudCislo1.TabIndex = 4;
            // 
            // nudCislo2
            // 
            this.nudCislo2.Location = new System.Drawing.Point(256, 46);
            this.nudCislo2.Name = "nudCislo2";
            this.nudCislo2.Size = new System.Drawing.Size(120, 20);
            this.nudCislo2.TabIndex = 5;
            // 
            // KalkulackaLepsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 270);
            this.Controls.Add(this.nudCislo2);
            this.Controls.Add(this.nudCislo1);
            this.Controls.Add(this.lVysledek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbZnak);
            this.Controls.Add(this.bVypocitej);
            this.Name = "KalkulackaLepsi";
            this.Text = "KalkulackaLepsi";
            this.Load += new System.EventHandler(this.KalkulackaLepsi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCislo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCislo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bVypocitej;
        private System.Windows.Forms.ComboBox cbZnak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lVysledek;
        private System.Windows.Forms.NumericUpDown nudCislo1;
        private System.Windows.Forms.NumericUpDown nudCislo2;
    }
}