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
            this.components = new System.ComponentModel.Container();
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
            this.lSpravneSpatne = new System.Windows.Forms.Label();
            this.pVysledky = new System.Windows.Forms.Panel();
            this.lTrvaloTiTo = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.bLetsGoBack = new System.Windows.Forms.Button();
            this.lPocetDobre = new System.Windows.Forms.Label();
            this.lPocetSpatne = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pZadavani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPocetPrikladu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDolniHranice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorniHranice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pPriklady.SuspendLayout();
            this.pVysledky.SuspendLayout();
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
            this.nudPocetPrikladu.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            this.nudDolniHranice.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
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
            this.nudHorniHranice.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nudHorniHranice.Name = "nudHorniHranice";
            this.nudHorniHranice.Size = new System.Drawing.Size(136, 20);
            this.nudHorniHranice.TabIndex = 6;
            this.nudHorniHranice.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            this.pPriklady.Controls.Add(this.lSpravneSpatne);
            this.pPriklady.Location = new System.Drawing.Point(566, 12);
            this.pPriklady.Name = "pPriklady";
            this.pPriklady.Size = new System.Drawing.Size(610, 388);
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
            this.bPal.Click += new System.EventHandler(this.bPal_Click);
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
            // lSpravneSpatne
            // 
            this.lSpravneSpatne.AutoSize = true;
            this.lSpravneSpatne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lSpravneSpatne.Location = new System.Drawing.Point(56, 38);
            this.lSpravneSpatne.Name = "lSpravneSpatne";
            this.lSpravneSpatne.Size = new System.Drawing.Size(64, 25);
            this.lSpravneSpatne.TabIndex = 0;
            this.lSpravneSpatne.Text = "label1";
            // 
            // pVysledky
            // 
            this.pVysledky.Controls.Add(this.lTrvaloTiTo);
            this.pVysledky.Controls.Add(this.bExit);
            this.pVysledky.Controls.Add(this.bLetsGoBack);
            this.pVysledky.Controls.Add(this.lPocetDobre);
            this.pVysledky.Controls.Add(this.lPocetSpatne);
            this.pVysledky.Location = new System.Drawing.Point(236, -1);
            this.pVysledky.Name = "pVysledky";
            this.pVysledky.Size = new System.Drawing.Size(636, 401);
            this.pVysledky.TabIndex = 2;
            // 
            // lTrvaloTiTo
            // 
            this.lTrvaloTiTo.AutoSize = true;
            this.lTrvaloTiTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lTrvaloTiTo.Location = new System.Drawing.Point(76, 28);
            this.lTrvaloTiTo.Name = "lTrvaloTiTo";
            this.lTrvaloTiTo.Size = new System.Drawing.Size(64, 25);
            this.lTrvaloTiTo.TabIndex = 14;
            this.lTrvaloTiTo.Text = "label1";
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bExit.Location = new System.Drawing.Point(33, 323);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(107, 53);
            this.bExit.TabIndex = 13;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bLetsGoBack
            // 
            this.bLetsGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.bLetsGoBack.Location = new System.Drawing.Point(158, 178);
            this.bLetsGoBack.Name = "bLetsGoBack";
            this.bLetsGoBack.Size = new System.Drawing.Size(449, 198);
            this.bLetsGoBack.TabIndex = 12;
            this.bLetsGoBack.Text = "Let\'s go back!";
            this.bLetsGoBack.UseVisualStyleBackColor = true;
            this.bLetsGoBack.Click += new System.EventHandler(this.bLetsGoBack_Click);
            // 
            // lPocetDobre
            // 
            this.lPocetDobre.AutoSize = true;
            this.lPocetDobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lPocetDobre.Location = new System.Drawing.Point(76, 68);
            this.lPocetDobre.Name = "lPocetDobre";
            this.lPocetDobre.Size = new System.Drawing.Size(64, 25);
            this.lPocetDobre.TabIndex = 1;
            this.lPocetDobre.Text = "label1";
            // 
            // lPocetSpatne
            // 
            this.lPocetSpatne.AutoSize = true;
            this.lPocetSpatne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lPocetSpatne.Location = new System.Drawing.Point(76, 134);
            this.lPocetSpatne.Name = "lPocetSpatne";
            this.lPocetSpatne.Size = new System.Drawing.Size(64, 25);
            this.lPocetSpatne.TabIndex = 0;
            this.lPocetSpatne.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zkouseni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 432);
            this.Controls.Add(this.pPriklady);
            this.Controls.Add(this.pVysledky);
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
            this.pVysledky.ResumeLayout(false);
            this.pVysledky.PerformLayout();
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
        private System.Windows.Forms.Label lSpravneSpatne;
        private System.Windows.Forms.Label lRovnase;
        private System.Windows.Forms.Button bPal;
        private System.Windows.Forms.TextBox tbVysledek;
        private System.Windows.Forms.Panel pVysledky;
        private System.Windows.Forms.Label lPocetDobre;
        private System.Windows.Forms.Label lPocetSpatne;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bLetsGoBack;
        private System.Windows.Forms.Label lTrvaloTiTo;
        private System.Windows.Forms.Timer timer1;
    }
}