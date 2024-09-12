namespace WindowsFormsApplication1
{
    partial class RadioButton
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
            this.rbAno = new System.Windows.Forms.RadioButton();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1nebo2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAno
            // 
            this.rbAno.AutoSize = true;
            this.rbAno.Location = new System.Drawing.Point(92, 52);
            this.rbAno.Name = "rbAno";
            this.rbAno.Size = new System.Drawing.Size(44, 17);
            this.rbAno.TabIndex = 0;
            this.rbAno.TabStop = true;
            this.rbAno.Text = "Ano";
            this.rbAno.UseVisualStyleBackColor = true;
            this.rbAno.CheckedChanged += new System.EventHandler(this.rbAno_CheckedChanged);
            // 
            // rbNe
            // 
            this.rbNe.AutoSize = true;
            this.rbNe.Location = new System.Drawing.Point(92, 101);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(39, 17);
            this.rbNe.TabIndex = 1;
            this.rbNe.TabStop = true;
            this.rbNe.Text = "Ńe";
            this.rbNe.UseVisualStyleBackColor = true;
            this.rbNe.CheckedChanged += new System.EventHandler(this.rbNe_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(33, 75);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(59, 17);
            this.rb2.TabIndex = 4;
            this.rb2.TabStop = true;
            this.rb2.Text = "Dvojka";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(33, 26);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(68, 17);
            this.rb1.TabIndex = 3;
            this.rb1.TabStop = true;
            this.rb1.Text = "Jednička";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(292, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1nebo2
            // 
            this.button1nebo2.Location = new System.Drawing.Point(262, 172);
            this.button1nebo2.Name = "button1nebo2";
            this.button1nebo2.Size = new System.Drawing.Size(159, 23);
            this.button1nebo2.TabIndex = 6;
            this.button1nebo2.Text = "Jednička nebo Dvojka";
            this.button1nebo2.UseVisualStyleBackColor = true;
            this.button1nebo2.Click += new System.EventHandler(this.button1nebo2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // RadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1nebo2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbNe);
            this.Controls.Add(this.rbAno);
            this.Name = "RadioButton";
            this.Text = "RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAno;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1nebo2;
        private System.Windows.Forms.Label label2;
    }
}