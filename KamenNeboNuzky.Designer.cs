namespace WindowsFormsApplication1
{
    partial class KamenNeboNuzky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KamenNeboNuzky));
            this.lJá = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bNovaHra = new System.Windows.Forms.Button();
            this.pbKamen = new System.Windows.Forms.PictureBox();
            this.pbNuzky = new System.Windows.Forms.PictureBox();
            this.pbPapir = new System.Windows.Forms.PictureBox();
            this.pbVysledekKamen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lPocetVyherPC = new System.Windows.Forms.Label();
            this.lPocetVyherJA = new System.Windows.Forms.Label();
            this.lKdoVyhral = new System.Windows.Forms.Label();
            this.pbVysledekNuzky = new System.Windows.Forms.PictureBox();
            this.pbVysledekPapir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbKamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuzky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPapir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVysledekKamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVysledekNuzky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVysledekPapir)).BeginInit();
            this.SuspendLayout();
            // 
            // lJá
            // 
            this.lJá.AutoSize = true;
            this.lJá.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.lJá.Location = new System.Drawing.Point(71, 35);
            this.lJá.Name = "lJá";
            this.lJá.Size = new System.Drawing.Size(45, 32);
            this.lJá.TabIndex = 0;
            this.lJá.Text = "Já";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label1.Location = new System.Drawing.Point(605, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Počítač";
            // 
            // bNovaHra
            // 
            this.bNovaHra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.bNovaHra.Location = new System.Drawing.Point(26, 423);
            this.bNovaHra.Name = "bNovaHra";
            this.bNovaHra.Size = new System.Drawing.Size(149, 56);
            this.bNovaHra.TabIndex = 2;
            this.bNovaHra.Text = "Nová hra";
            this.bNovaHra.UseVisualStyleBackColor = true;
            this.bNovaHra.Click += new System.EventHandler(this.bNovaHra_Click);
            // 
            // pbKamen
            // 
            this.pbKamen.Image = ((System.Drawing.Image)(resources.GetObject("pbKamen.Image")));
            this.pbKamen.Location = new System.Drawing.Point(223, 353);
            this.pbKamen.Name = "pbKamen";
            this.pbKamen.Size = new System.Drawing.Size(143, 183);
            this.pbKamen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKamen.TabIndex = 3;
            this.pbKamen.TabStop = false;
            this.pbKamen.Click += new System.EventHandler(this.pbKamen_Click);
            // 
            // pbNuzky
            // 
            this.pbNuzky.Image = ((System.Drawing.Image)(resources.GetObject("pbNuzky.Image")));
            this.pbNuzky.Location = new System.Drawing.Point(415, 353);
            this.pbNuzky.Name = "pbNuzky";
            this.pbNuzky.Size = new System.Drawing.Size(143, 183);
            this.pbNuzky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNuzky.TabIndex = 4;
            this.pbNuzky.TabStop = false;
            this.pbNuzky.Click += new System.EventHandler(this.pbNuzky_Click);
            // 
            // pbPapir
            // 
            this.pbPapir.Image = ((System.Drawing.Image)(resources.GetObject("pbPapir.Image")));
            this.pbPapir.Location = new System.Drawing.Point(611, 353);
            this.pbPapir.Name = "pbPapir";
            this.pbPapir.Size = new System.Drawing.Size(143, 183);
            this.pbPapir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPapir.TabIndex = 5;
            this.pbPapir.TabStop = false;
            this.pbPapir.Click += new System.EventHandler(this.pbPapir_Click);
            // 
            // pbVysledekKamen
            // 
            this.pbVysledekKamen.Image = ((System.Drawing.Image)(resources.GetObject("pbVysledekKamen.Image")));
            this.pbVysledekKamen.Location = new System.Drawing.Point(222, 111);
            this.pbVysledekKamen.Name = "pbVysledekKamen";
            this.pbVysledekKamen.Size = new System.Drawing.Size(311, 153);
            this.pbVysledekKamen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVysledekKamen.TabIndex = 9;
            this.pbVysledekKamen.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(622, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 10;
            // 
            // lPocetVyherPC
            // 
            this.lPocetVyherPC.AutoSize = true;
            this.lPocetVyherPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.lPocetVyherPC.Location = new System.Drawing.Point(647, 111);
            this.lPocetVyherPC.Name = "lPocetVyherPC";
            this.lPocetVyherPC.Size = new System.Drawing.Size(31, 32);
            this.lPocetVyherPC.TabIndex = 11;
            this.lPocetVyherPC.Text = "0";
            // 
            // lPocetVyherJA
            // 
            this.lPocetVyherJA.AutoSize = true;
            this.lPocetVyherJA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.lPocetVyherJA.Location = new System.Drawing.Point(85, 111);
            this.lPocetVyherJA.Name = "lPocetVyherJA";
            this.lPocetVyherJA.Size = new System.Drawing.Size(31, 32);
            this.lPocetVyherJA.TabIndex = 12;
            this.lPocetVyherJA.Text = "0";
            // 
            // lKdoVyhral
            // 
            this.lKdoVyhral.AutoSize = true;
            this.lKdoVyhral.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lKdoVyhral.Location = new System.Drawing.Point(320, 35);
            this.lKdoVyhral.Name = "lKdoVyhral";
            this.lKdoVyhral.Size = new System.Drawing.Size(156, 39);
            this.lKdoVyhral.TabIndex = 13;
            this.lKdoVyhral.Text = "Vysledek";
            // 
            // pbVysledekNuzky
            // 
            this.pbVysledekNuzky.Image = ((System.Drawing.Image)(resources.GetObject("pbVysledekNuzky.Image")));
            this.pbVysledekNuzky.Location = new System.Drawing.Point(275, 111);
            this.pbVysledekNuzky.Name = "pbVysledekNuzky";
            this.pbVysledekNuzky.Size = new System.Drawing.Size(311, 153);
            this.pbVysledekNuzky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVysledekNuzky.TabIndex = 14;
            this.pbVysledekNuzky.TabStop = false;
            // 
            // pbVysledekPapir
            // 
            this.pbVysledekPapir.Image = ((System.Drawing.Image)(resources.GetObject("pbVysledekPapir.Image")));
            this.pbVysledekPapir.Location = new System.Drawing.Point(247, 111);
            this.pbVysledekPapir.Name = "pbVysledekPapir";
            this.pbVysledekPapir.Size = new System.Drawing.Size(311, 153);
            this.pbVysledekPapir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVysledekPapir.TabIndex = 15;
            this.pbVysledekPapir.TabStop = false;
            // 
            // KamenNeboNuzky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 548);
            this.Controls.Add(this.pbVysledekPapir);
            this.Controls.Add(this.pbVysledekNuzky);
            this.Controls.Add(this.lKdoVyhral);
            this.Controls.Add(this.lPocetVyherJA);
            this.Controls.Add(this.lPocetVyherPC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbVysledekKamen);
            this.Controls.Add(this.pbPapir);
            this.Controls.Add(this.pbNuzky);
            this.Controls.Add(this.pbKamen);
            this.Controls.Add(this.bNovaHra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lJá);
            this.Name = "KamenNeboNuzky";
            this.Text = "KamenNeboNuzky";
            this.Load += new System.EventHandler(this.KamenNeboNuzky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKamen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuzky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPapir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVysledekKamen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVysledekNuzky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVysledekPapir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lJá;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bNovaHra;
        private System.Windows.Forms.PictureBox pbKamen;
        private System.Windows.Forms.PictureBox pbNuzky;
        private System.Windows.Forms.PictureBox pbPapir;
        private System.Windows.Forms.PictureBox pbVysledekKamen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lPocetVyherPC;
        private System.Windows.Forms.Label lPocetVyherJA;
        private System.Windows.Forms.Label lKdoVyhral;
        private System.Windows.Forms.PictureBox pbVysledekNuzky;
        private System.Windows.Forms.PictureBox pbVysledekPapir;
    }
}