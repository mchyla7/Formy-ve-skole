namespace oopPracovnici
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bDalsi = new System.Windows.Forms.Button();
            this.bKonec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 121);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 154);
            this.textBox1.TabIndex = 0;
            // 
            // bDalsi
            // 
            this.bDalsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDalsi.Location = new System.Drawing.Point(40, 321);
            this.bDalsi.Name = "bDalsi";
            this.bDalsi.Size = new System.Drawing.Size(100, 44);
            this.bDalsi.TabIndex = 8;
            this.bDalsi.Text = "Další";
            this.bDalsi.UseVisualStyleBackColor = true;
            // 
            // bKonec
            // 
            this.bKonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bKonec.Location = new System.Drawing.Point(282, 321);
            this.bKonec.Name = "bKonec";
            this.bKonec.Size = new System.Drawing.Size(100, 44);
            this.bKonec.TabIndex = 9;
            this.bKonec.Text = "Konec";
            this.bKonec.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 410);
            this.Controls.Add(this.bKonec);
            this.Controls.Add(this.bDalsi);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bDalsi;
        private System.Windows.Forms.Button bKonec;
    }
}