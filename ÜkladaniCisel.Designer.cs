﻿namespace WindowsFormsApplication1
{
    partial class ÜkladaniCisel
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
            this.lZadejCislo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lPocetCisel = new System.Windows.Forms.Label();
            this.lPocetCiselReal = new System.Windows.Forms.Label();
            this.bPridatCislo = new System.Windows.Forms.Button();
            this.bVymazatCisla = new System.Windows.Forms.Button();
            this.pUlozitDoFormatu = new System.Windows.Forms.Panel();
            this.rbPodSebou = new System.Windows.Forms.RadioButton();
            this.rbOddelenoTab = new System.Windows.Forms.RadioButton();
            this.rbOddelenoDvojteckou = new System.Windows.Forms.RadioButton();
            this.lUlozitDoFormatu = new System.Windows.Forms.Label();
            this.pUlozitDoFormatu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lZadejCislo
            // 
            this.lZadejCislo.AutoSize = true;
            this.lZadejCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lZadejCislo.Location = new System.Drawing.Point(42, 65);
            this.lZadejCislo.Name = "lZadejCislo";
            this.lZadejCislo.Size = new System.Drawing.Size(199, 39);
            this.lZadejCislo.TabIndex = 0;
            this.lZadejCislo.Text = "Zadej číslo :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lPocetCisel
            // 
            this.lPocetCisel.AutoSize = true;
            this.lPocetCisel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lPocetCisel.Location = new System.Drawing.Point(569, 65);
            this.lPocetCisel.Name = "lPocetCisel";
            this.lPocetCisel.Size = new System.Drawing.Size(200, 39);
            this.lPocetCisel.TabIndex = 2;
            this.lPocetCisel.Text = "Počet čísel :";
            // 
            // lPocetCiselReal
            // 
            this.lPocetCiselReal.AutoSize = true;
            this.lPocetCiselReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lPocetCiselReal.Location = new System.Drawing.Point(775, 65);
            this.lPocetCiselReal.Name = "lPocetCiselReal";
            this.lPocetCiselReal.Size = new System.Drawing.Size(36, 39);
            this.lPocetCiselReal.TabIndex = 3;
            this.lPocetCiselReal.Text = "0";
            // 
            // bPridatCislo
            // 
            this.bPridatCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bPridatCislo.Location = new System.Drawing.Point(273, 161);
            this.bPridatCislo.Name = "bPridatCislo";
            this.bPridatCislo.Size = new System.Drawing.Size(151, 51);
            this.bPridatCislo.TabIndex = 4;
            this.bPridatCislo.Text = "Přidat číslo";
            this.bPridatCislo.UseVisualStyleBackColor = true;
            // 
            // bVymazatCisla
            // 
            this.bVymazatCisla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bVymazatCisla.Location = new System.Drawing.Point(626, 161);
            this.bVymazatCisla.Name = "bVymazatCisla";
            this.bVymazatCisla.Size = new System.Drawing.Size(220, 51);
            this.bVymazatCisla.TabIndex = 5;
            this.bVymazatCisla.Text = "Vymazat zadaná čísla";
            this.bVymazatCisla.UseVisualStyleBackColor = true;
            // 
            // pUlozitDoFormatu
            // 
            this.pUlozitDoFormatu.Controls.Add(this.rbPodSebou);
            this.pUlozitDoFormatu.Controls.Add(this.rbOddelenoTab);
            this.pUlozitDoFormatu.Controls.Add(this.rbOddelenoDvojteckou);
            this.pUlozitDoFormatu.Location = new System.Drawing.Point(78, 286);
            this.pUlozitDoFormatu.Name = "pUlozitDoFormatu";
            this.pUlozitDoFormatu.Size = new System.Drawing.Size(246, 199);
            this.pUlozitDoFormatu.TabIndex = 6;
            // 
            // rbPodSebou
            // 
            this.rbPodSebou.AutoSize = true;
            this.rbPodSebou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbPodSebou.Location = new System.Drawing.Point(20, 103);
            this.rbPodSebou.Name = "rbPodSebou";
            this.rbPodSebou.Size = new System.Drawing.Size(103, 24);
            this.rbPodSebou.TabIndex = 2;
            this.rbPodSebou.TabStop = true;
            this.rbPodSebou.Text = "Pod sebou";
            this.rbPodSebou.UseVisualStyleBackColor = true;
            // 
            // rbOddelenoTab
            // 
            this.rbOddelenoTab.AutoSize = true;
            this.rbOddelenoTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbOddelenoTab.Location = new System.Drawing.Point(20, 63);
            this.rbOddelenoTab.Name = "rbOddelenoTab";
            this.rbOddelenoTab.Size = new System.Drawing.Size(149, 24);
            this.rbOddelenoTab.TabIndex = 1;
            this.rbOddelenoTab.TabStop = true;
            this.rbOddelenoTab.Text = "Odděleno Tabem";
            this.rbOddelenoTab.UseVisualStyleBackColor = true;
            // 
            // rbOddelenoDvojteckou
            // 
            this.rbOddelenoDvojteckou.AutoSize = true;
            this.rbOddelenoDvojteckou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbOddelenoDvojteckou.Location = new System.Drawing.Point(20, 18);
            this.rbOddelenoDvojteckou.Name = "rbOddelenoDvojteckou";
            this.rbOddelenoDvojteckou.Size = new System.Drawing.Size(104, 24);
            this.rbOddelenoDvojteckou.TabIndex = 0;
            this.rbOddelenoDvojteckou.TabStop = true;
            this.rbOddelenoDvojteckou.Text = "Odděleno :";
            this.rbOddelenoDvojteckou.UseVisualStyleBackColor = true;
            // 
            // lUlozitDoFormatu
            // 
            this.lUlozitDoFormatu.AutoSize = true;
            this.lUlozitDoFormatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lUlozitDoFormatu.Location = new System.Drawing.Point(81, 258);
            this.lUlozitDoFormatu.Name = "lUlozitDoFormatu";
            this.lUlozitDoFormatu.Size = new System.Drawing.Size(163, 25);
            this.lUlozitDoFormatu.TabIndex = 7;
            this.lUlozitDoFormatu.Text = "Uložit do formatu:";
            // 
            // ÜkladaniCisel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 534);
            this.Controls.Add(this.lUlozitDoFormatu);
            this.Controls.Add(this.bVymazatCisla);
            this.Controls.Add(this.bPridatCislo);
            this.Controls.Add(this.lPocetCiselReal);
            this.Controls.Add(this.lPocetCisel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lZadejCislo);
            this.Controls.Add(this.pUlozitDoFormatu);
            this.Name = "ÜkladaniCisel";
            this.Text = "ÜkladaniCisel";
            this.pUlozitDoFormatu.ResumeLayout(false);
            this.pUlozitDoFormatu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lZadejCislo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lPocetCisel;
        private System.Windows.Forms.Label lPocetCiselReal;
        private System.Windows.Forms.Button bPridatCislo;
        private System.Windows.Forms.Button bVymazatCisla;
        private System.Windows.Forms.Panel pUlozitDoFormatu;
        private System.Windows.Forms.Label lUlozitDoFormatu;
        private System.Windows.Forms.RadioButton rbPodSebou;
        private System.Windows.Forms.RadioButton rbOddelenoTab;
        private System.Windows.Forms.RadioButton rbOddelenoDvojteckou;
    }
}