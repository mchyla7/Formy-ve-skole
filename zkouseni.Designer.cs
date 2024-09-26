namespace WindowsFormsApplication1
{
    partial class zkouseni
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
            this.pZadavani = new System.Windows.Forms.Panel();
            this.bStart = new System.Windows.Forms.Button();
            this.nudPocetPrikladu = new System.Windows.Forms.NumericUpDown();
            this.lPocetPrikaldu = new System.Windows.Forms.Label();
            this.nudDolniHranice = new System.Windows.Forms.NumericUpDown();
            this.lDolniHranice = new System.Windows.Forms.Label();
            this.nudHorniHranice = new System.Windows.Forms.NumericUpDown();
            this.lHorniHranice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVse = new System.Windows.Forms.RadioButton();
            this.rbNasobeni = new System.Windows.Forms.RadioButton();
            this.rbOdcitani = new System.Windows.Forms.RadioButton();
            this.rbScitani = new System.Windows.Forms.RadioButton();
            this.pPriklady = new System.Windows.Forms.Panel();
            this.lRovnase = new System.Windows.Forms.Label();
            this.bPal = new System.Windows.Forms.Button();
            this.tbVysledek = new System.Windows.Forms.TextBox();
            this.lDruheCislo = new System.Windows.Forms.Label();
            this.lZnamenko = new System.Windows.Forms.Label();
            this.lPrvniCislo = new System.Windows.Forms.Label();
            this.sSpravneSpatne = new System.Windows.Forms.Label();
            this.pZadavani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPocetPrikladu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDolniHranice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorniHranice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pPriklady.SuspendLayout();
            this.SuspendLayout();
            // 
            // pZadavani
            // 
            this.pZadavani.Controls.Add(this.bStart);
            this.pZadavani.Controls.Add(this.nudPocetPrikladu);
            this.pZadavani.Controls.Add(this.lPocetPrikaldu);
            this.pZadavani.Controls.Add(this.nudDolniHranice);
            this.pZadavani.Controls.Add(this.lDolniHranice);
            this.pZadavani.Controls.Add(this.nudHorniHranice);
            this.pZadavani.Controls.Add(this.lHorniHranice);
            this.pZadavani.Controls.Add(this.groupBox1);
            this.pZadavani.Location = new System.Drawing.Point(41, 30);
            this.pZadavani.Name = "pZadavani";
            this.pZadavani.Size = new System.Drawing.Size(670, 391);
            this.pZadavani.TabIndex = 0;
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bStart.Location = new System.Drawing.Point(43, 214);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(192, 122);
            this.bStart.TabIndex = 11;
            this.bStart.Text = "Start!";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // nudPocetPrikladu
            // 
            this.nudPocetPrikladu.Location = new System.Drawing.Point(505, 266);
            this.nudPocetPrikladu.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPocetPrikladu.Name = "nudPocetPrikladu";
            this.nudPocetPrikladu.Size = new System.Drawing.Size(136, 20);
            this.nudPocetPrikladu.TabIndex = 10;
            // 
            // lPocetPrikaldu
            // 
            this.lPocetPrikaldu.AutoSize = true;
            this.lPocetPrikaldu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lPocetPrikaldu.Location = new System.Drawing.Point(257, 248);
            this.lPocetPrikaldu.Name = "lPocetPrikaldu";
            this.lPocetPrikaldu.Size = new System.Drawing.Size(233, 39);
            this.lPocetPrikaldu.TabIndex = 9;
            this.lPocetPrikaldu.Text = "Počet příkladů";
            // 
            // nudDolniHranice
            // 
            this.nudDolniHranice.Location = new System.Drawing.Point(470, 141);
            this.nudDolniHranice.Name = "nudDolniHranice";
            this.nudDolniHranice.Size = new System.Drawing.Size(136, 20);
            this.nudDolniHranice.TabIndex = 8;
            // 
            // lDolniHranice
            // 
            this.lDolniHranice.AutoSize = true;
            this.lDolniHranice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lDolniHranice.Location = new System.Drawing.Point(220, 123);
            this.lDolniHranice.Name = "lDolniHranice";
            this.lDolniHranice.Size = new System.Drawing.Size(223, 39);
            this.lDolniHranice.TabIndex = 7;
            this.lDolniHranice.Text = "Dolní Hranice";

            // 
            // nudHorniHranice
            // 
            this.nudHorniHranice.Location = new System.Drawing.Point(470, 33);
            this.nudHorniHranice.Name = "nudHorniHranice";
            this.nudHorniHranice.Size = new System.Drawing.Size(136, 20);
            this.nudHorniHranice.TabIndex = 6;
            // 
            // lHorniHranice
            // 
            this.lHorniHranice.AutoSize = true;
            this.lHorniHranice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lHorniHranice.Location = new System.Drawing.Point(220, 22);
            this.lHorniHranice.Name = "lHorniHranice";
            this.lHorniHranice.Size = new System.Drawing.Size(226, 39);
            this.lHorniHranice.TabIndex = 5;
            this.lHorniHranice.Text = "Horní Hranice";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVse);
            this.groupBox1.Controls.Add(this.rbNasobeni);
            this.groupBox1.Controls.Add(this.rbOdcitani);
            this.groupBox1.Controls.Add(this.rbScitani);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbVse
            // 
            this.rbVse.AutoSize = true;
            this.rbVse.Location = new System.Drawing.Point(15, 83);
            this.rbVse.Name = "rbVse";
            this.rbVse.Size = new System.Drawing.Size(67, 17);
            this.rbVse.TabIndex = 3;
            this.rbVse.TabStop = true;
            this.rbVse.Text = "Všechno";
            this.rbVse.UseVisualStyleBackColor = true;
            this.rbVse.CheckedChanged += new System.EventHandler(this.rbVse_CheckedChanged);
            // 
            // rbNasobeni
            // 
            this.rbNasobeni.AutoSize = true;
            this.rbNasobeni.Location = new System.Drawing.Point(15, 59);
            this.rbNasobeni.Name = "rbNasobeni";
            this.rbNasobeni.Size = new System.Drawing.Size(72, 17);
            this.rbNasobeni.TabIndex = 2;
            this.rbNasobeni.TabStop = true;
            this.rbNasobeni.Text = "Násobení";
            this.rbNasobeni.UseVisualStyleBackColor = true;
            this.rbNasobeni.CheckedChanged += new System.EventHandler(this.rbNasobeni_CheckedChanged);
            // 
            // rbOdcitani
            // 
            this.rbOdcitani.AutoSize = true;
            this.rbOdcitani.Location = new System.Drawing.Point(15, 35);
            this.rbOdcitani.Name = "rbOdcitani";
            this.rbOdcitani.Size = new System.Drawing.Size(68, 17);
            this.rbOdcitani.TabIndex = 1;
            this.rbOdcitani.TabStop = true;
            this.rbOdcitani.Text = "Odčítání";
            this.rbOdcitani.UseVisualStyleBackColor = true;
            this.rbOdcitani.CheckedChanged += new System.EventHandler(this.rbOdcitani_CheckedChanged);
            // 
            // rbScitani
            // 
            this.rbScitani.AutoSize = true;
            this.rbScitani.Location = new System.Drawing.Point(15, 11);
            this.rbScitani.Name = "rbScitani";
            this.rbScitani.Size = new System.Drawing.Size(61, 17);
            this.rbScitani.TabIndex = 0;
            this.rbScitani.TabStop = true;
            this.rbScitani.Text = "Sčítání";
            this.rbScitani.UseVisualStyleBackColor = true;
            this.rbScitani.CheckedChanged += new System.EventHandler(this.rbScitani_CheckedChanged);
            // 
            // pPriklady
            // 
            this.pPriklady.Controls.Add(this.lRovnase);
            this.pPriklady.Controls.Add(this.bPal);
            this.pPriklady.Controls.Add(this.tbVysledek);
            this.pPriklady.Controls.Add(this.lDruheCislo);
            this.pPriklady.Controls.Add(this.lZnamenko);
            this.pPriklady.Controls.Add(this.lPrvniCislo);
            this.pPriklady.Controls.Add(this.sSpravneSpatne);
            this.pPriklady.Location = new System.Drawing.Point(717, 30);
            this.pPriklady.Name = "pPriklady";
            this.pPriklady.Size = new System.Drawing.Size(667, 386);
            this.pPriklady.TabIndex = 1;
            // 
            // lRovnase
            // 
            this.lRovnase.AutoSize = true;
            this.lRovnase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lRovnase.Location = new System.Drawing.Point(282, 248);
            this.lRovnase.Name = "lRovnase";
            this.lRovnase.Size = new System.Drawing.Size(24, 25);
            this.lRovnase.TabIndex = 13;
            this.lRovnase.Text = "=";
            // 
            // bPal
            // 
            this.bPal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bPal.Location = new System.Drawing.Point(385, 284);
            this.bPal.Name = "bPal";
            this.bPal.Size = new System.Drawing.Size(126, 72);
            this.bPal.TabIndex = 12;
            this.bPal.Text = "Pal!";
            this.bPal.UseVisualStyleBackColor = true;
            // 
            // tbVysledek
            // 
            this.tbVysledek.Location = new System.Drawing.Point(332, 253);
            this.tbVysledek.Name = "tbVysledek";
            this.tbVysledek.Size = new System.Drawing.Size(119, 20);
            this.tbVysledek.TabIndex = 4;
            // 
            // lDruheCislo
            // 
            this.lDruheCislo.AutoSize = true;
            this.lDruheCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lDruheCislo.Location = new System.Drawing.Point(212, 248);
            this.lDruheCislo.Name = "lDruheCislo";
            this.lDruheCislo.Size = new System.Drawing.Size(64, 25);
            this.lDruheCislo.TabIndex = 3;
            this.lDruheCislo.Text = "label1";
            // 
            // lZnamenko
            // 
            this.lZnamenko.AutoSize = true;
            this.lZnamenko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lZnamenko.Location = new System.Drawing.Point(142, 248);
            this.lZnamenko.Name = "lZnamenko";
            this.lZnamenko.Size = new System.Drawing.Size(64, 25);
            this.lZnamenko.TabIndex = 2;
            this.lZnamenko.Text = "label1";
            // 
            // lPrvniCislo
            // 
            this.lPrvniCislo.AutoSize = true;
            this.lPrvniCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lPrvniCislo.Location = new System.Drawing.Point(72, 248);
            this.lPrvniCislo.Name = "lPrvniCislo";
            this.lPrvniCislo.Size = new System.Drawing.Size(64, 25);
            this.lPrvniCislo.TabIndex = 1;
            this.lPrvniCislo.Text = "label1";
            // 
            // sSpravneSpatne
            // 
            this.sSpravneSpatne.AutoSize = true;
            this.sSpravneSpatne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sSpravneSpatne.Location = new System.Drawing.Point(54, 47);
            this.sSpravneSpatne.Name = "sSpravneSpatne";
            this.sSpravneSpatne.Size = new System.Drawing.Size(64, 25);
            this.sSpravneSpatne.TabIndex = 0;
            this.sSpravneSpatne.Text = "label1";
            // 
            // zkouseni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 432);
            this.Controls.Add(this.pPriklady);
            this.Controls.Add(this.pZadavani);
            this.Name = "zkouseni";
            this.Text = "Form1";
            this.pZadavani.ResumeLayout(false);
            this.pZadavani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPocetPrikladu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDolniHranice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorniHranice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pPriklady.ResumeLayout(false);
            this.pPriklady.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pZadavani;
        private System.Windows.Forms.RadioButton rbScitani;
        private System.Windows.Forms.Label lHorniHranice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVse;
        private System.Windows.Forms.RadioButton rbNasobeni;
        private System.Windows.Forms.RadioButton rbOdcitani;
        private System.Windows.Forms.Label lDolniHranice;
        private System.Windows.Forms.NumericUpDown nudHorniHranice;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.NumericUpDown nudPocetPrikladu;
        private System.Windows.Forms.Label lPocetPrikaldu;
        private System.Windows.Forms.NumericUpDown nudDolniHranice;
        private System.Windows.Forms.Panel pPriklady;
        private System.Windows.Forms.Label lDruheCislo;
        private System.Windows.Forms.Label lZnamenko;
        private System.Windows.Forms.Label lPrvniCislo;
        private System.Windows.Forms.Label sSpravneSpatne;
        private System.Windows.Forms.Label lRovnase;
        private System.Windows.Forms.Button bPal;
        private System.Windows.Forms.TextBox tbVysledek;
    }
}