namespace Programko
{
    partial class hadani
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonkonec = new System.Windows.Forms.Button();
            this.spustitznovu = new System.Windows.Forms.RadioButton();
            this.ukoncit = new System.Windows.Forms.RadioButton();
            this.vyslednytext = new System.Windows.Forms.Label();
            this.buttonhadani = new System.Windows.Forms.Button();
            this.hadaciokenko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainbutton = new System.Windows.Forms.Button();
            this.dolnihranice = new System.Windows.Forms.NumericUpDown();
            this.hornihranice = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dolnihranice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hornihranice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mainbutton);
            this.panel1.Controls.Add(this.dolnihranice);
            this.panel1.Controls.Add(this.hornihranice);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(121, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 275);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "dolní hranice";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonhadani);
            this.panel2.Controls.Add(this.hadaciokenko);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 275);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonkonec);
            this.panel3.Controls.Add(this.spustitznovu);
            this.panel3.Controls.Add(this.ukoncit);
            this.panel3.Controls.Add(this.vyslednytext);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 275);
            this.panel3.TabIndex = 2;
            // 
            // buttonkonec
            // 
            this.buttonkonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonkonec.Location = new System.Drawing.Point(45, 210);
            this.buttonkonec.Name = "buttonkonec";
            this.buttonkonec.Size = new System.Drawing.Size(319, 45);
            this.buttonkonec.TabIndex = 5;
            this.buttonkonec.Text = "potvrdit";
            this.buttonkonec.UseVisualStyleBackColor = true;
            this.buttonkonec.Click += new System.EventHandler(this.buttonkonec_Click);
            // 
            // spustitznovu
            // 
            this.spustitznovu.AutoSize = true;
            this.spustitznovu.Location = new System.Drawing.Point(117, 166);
            this.spustitznovu.Name = "spustitznovu";
            this.spustitznovu.Size = new System.Drawing.Size(144, 29);
            this.spustitznovu.TabIndex = 5;
            this.spustitznovu.TabStop = true;
            this.spustitznovu.Text = "spustit znovu";
            this.spustitznovu.UseVisualStyleBackColor = true;
            // 
            // ukoncit
            // 
            this.ukoncit.AutoSize = true;
            this.ukoncit.Location = new System.Drawing.Point(117, 119);
            this.ukoncit.Name = "ukoncit";
            this.ukoncit.Size = new System.Drawing.Size(92, 29);
            this.ukoncit.TabIndex = 4;
            this.ukoncit.TabStop = true;
            this.ukoncit.Text = "ukončit";
            this.ukoncit.UseVisualStyleBackColor = false;
            // 
            // vyslednytext
            // 
            this.vyslednytext.AutoSize = true;
            this.vyslednytext.Location = new System.Drawing.Point(112, 41);
            this.vyslednytext.Name = "vyslednytext";
            this.vyslednytext.Size = new System.Drawing.Size(194, 25);
            this.vyslednytext.TabIndex = 3;
            this.vyslednytext.Text = "uhodl jsi na x pokusů";
            // 
            // buttonhadani
            // 
            this.buttonhadani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonhadani.Location = new System.Drawing.Point(45, 200);
            this.buttonhadani.Name = "buttonhadani";
            this.buttonhadani.Size = new System.Drawing.Size(319, 45);
            this.buttonhadani.TabIndex = 4;
            this.buttonhadani.Text = "hádat";
            this.buttonhadani.UseVisualStyleBackColor = true;
            this.buttonhadani.Click += new System.EventHandler(this.buttonhadani_Click);
            // 
            // hadaciokenko
            // 
            this.hadaciokenko.Location = new System.Drawing.Point(66, 101);
            this.hadaciokenko.Name = "hadaciokenko";
            this.hadaciokenko.Size = new System.Drawing.Size(283, 30);
            this.hadaciokenko.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hádej";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "horní hranice";
            // 
            // mainbutton
            // 
            this.mainbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainbutton.Location = new System.Drawing.Point(45, 204);
            this.mainbutton.Name = "mainbutton";
            this.mainbutton.Size = new System.Drawing.Size(319, 45);
            this.mainbutton.TabIndex = 0;
            this.mainbutton.Text = "potvrdit";
            this.mainbutton.UseVisualStyleBackColor = true;
            this.mainbutton.Click += new System.EventHandler(this.mainbutton_Click);
            // 
            // dolnihranice
            // 
            this.dolnihranice.Location = new System.Drawing.Point(141, 122);
            this.dolnihranice.Name = "dolnihranice";
            this.dolnihranice.Size = new System.Drawing.Size(223, 30);
            this.dolnihranice.TabIndex = 1;
            // 
            // hornihranice
            // 
            this.hornihranice.Location = new System.Drawing.Point(141, 34);
            this.hornihranice.Name = "hornihranice";
            this.hornihranice.Size = new System.Drawing.Size(223, 30);
            this.hornihranice.TabIndex = 0;
            // 
            // hadani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 367);
            this.Controls.Add(this.panel1);
            this.Name = "hadani";
            this.Text = "hadani";
            this.Load += new System.EventHandler(this.hadani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dolnihranice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hornihranice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown hornihranice;
        private System.Windows.Forms.Button mainbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dolnihranice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox hadaciokenko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton spustitznovu;
        private System.Windows.Forms.RadioButton ukoncit;
        private System.Windows.Forms.Label vyslednytext;
        private System.Windows.Forms.Button buttonhadani;
        private System.Windows.Forms.Button buttonkonec;
    }
}