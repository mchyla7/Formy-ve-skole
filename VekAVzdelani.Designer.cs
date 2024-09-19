namespace WindowsFormsApplication1
{
    partial class Kalkulacka2
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
            this.lVek = new System.Windows.Forms.Label();
            this.nudVek = new System.Windows.Forms.NumericUpDown();
            this.bVypis = new System.Windows.Forms.Button();
            this.tbVypis = new System.Windows.Forms.TextBox();
            this.cbVzdelani = new System.Windows.Forms.ComboBox();
            this.lVzdelani = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudVek)).BeginInit();
            this.SuspendLayout();
            // 
            // lVek
            // 
            this.lVek.AutoSize = true;
            this.lVek.Location = new System.Drawing.Point(47, 54);
            this.lVek.Name = "lVek";
            this.lVek.Size = new System.Drawing.Size(29, 13);
            this.lVek.TabIndex = 0;
            this.lVek.Text = "Věk:";
            this.lVek.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudVek
            // 
            this.nudVek.Location = new System.Drawing.Point(111, 47);
            this.nudVek.Name = "nudVek";
            this.nudVek.Size = new System.Drawing.Size(120, 20);
            this.nudVek.TabIndex = 1;
            this.nudVek.ValueChanged += new System.EventHandler(this.nudVek_ValueChanged);
            // 
            // bVypis
            // 
            this.bVypis.Location = new System.Drawing.Point(81, 214);
            this.bVypis.Name = "bVypis";
            this.bVypis.Size = new System.Drawing.Size(126, 83);
            this.bVypis.TabIndex = 2;
            this.bVypis.Text = "Výpis";
            this.bVypis.UseVisualStyleBackColor = true;
            this.bVypis.Click += new System.EventHandler(this.bVypis_Click);
            // 
            // tbVypis
            // 
            this.tbVypis.Location = new System.Drawing.Point(287, 193);
            this.tbVypis.Multiline = true;
            this.tbVypis.Name = "tbVypis";
            this.tbVypis.Size = new System.Drawing.Size(314, 115);
            this.tbVypis.TabIndex = 3;
            this.tbVypis.TextChanged += new System.EventHandler(this.tbVypis_TextChanged);
            // 
            // cbVzdelani
            // 
            this.cbVzdelani.Items.AddRange(new object[] {
            "Základní",
            "Střední",
            "Střední s Maturitou",
            "Vysokoškolské"});
            this.cbVzdelani.Location = new System.Drawing.Point(111, 124);
            this.cbVzdelani.Name = "cbVzdelani";
            this.cbVzdelani.Size = new System.Drawing.Size(121, 21);
            this.cbVzdelani.TabIndex = 4;
            this.cbVzdelani.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lVzdelani
            // 
            this.lVzdelani.AutoSize = true;
            this.lVzdelani.Location = new System.Drawing.Point(47, 127);
            this.lVzdelani.Name = "lVzdelani";
            this.lVzdelani.Size = new System.Drawing.Size(49, 13);
            this.lVzdelani.TabIndex = 5;
            this.lVzdelani.Text = "Vzdělání";
            // 
            // VekAVzdelani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 403);
            this.Controls.Add(this.lVzdelani);
            this.Controls.Add(this.cbVzdelani);
            this.Controls.Add(this.tbVypis);
            this.Controls.Add(this.bVypis);
            this.Controls.Add(this.nudVek);
            this.Controls.Add(this.lVek);
            this.Name = "VekAVzdelani";
            this.Text = "VekAVzdelani";
            ((System.ComponentModel.ISupportInitialize)(this.nudVek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lVek;
        private System.Windows.Forms.NumericUpDown nudVek;
        private System.Windows.Forms.Button bVypis;
        private System.Windows.Forms.TextBox tbVypis;
        private System.Windows.Forms.ComboBox cbVzdelani;
        private System.Windows.Forms.Label lVzdelani;
    }
}