namespace WindowsFormsApplication1
{
    partial class _Stopky
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lStopky = new System.Windows.Forms.Label();
            this.lCas = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // lStopky
            // 
            this.lStopky.AutoSize = true;
            this.lStopky.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lStopky.Location = new System.Drawing.Point(154, 140);
            this.lStopky.Name = "lStopky";
            this.lStopky.Size = new System.Drawing.Size(0, 46);
            this.lStopky.TabIndex = 0;
            this.lStopky.Click += new System.EventHandler(this.lStopky_Click);
            // 
            // lCas
            // 
            this.lCas.AutoSize = true;
            this.lCas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lCas.Location = new System.Drawing.Point(166, 49);
            this.lCas.Name = "lCas";
            this.lCas.Size = new System.Drawing.Size(0, 46);
            this.lCas.TabIndex = 1;
            this.lCas.Click += new System.EventHandler(this.lCas_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // _Stopky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 374);
            this.Controls.Add(this.lCas);
            this.Controls.Add(this.lStopky);
            this.Name = "_Stopky";
            this.Text = "_Stopky";
            this.Load += new System.EventHandler(this._Stopky_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lStopky;
        private System.Windows.Forms.Label lCas;
        private System.Windows.Forms.Timer timer2;
    }
}