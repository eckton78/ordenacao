namespace ordenacao
{
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAtemp = new System.Windows.Forms.Label();
            this.lblAfim = new System.Windows.Forms.Label();
            this.lblAini = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBtemp = new System.Windows.Forms.Label();
            this.lblBfim = new System.Windows.Forms.Label();
            this.lblBini = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCtemp = new System.Windows.Forms.Label();
            this.lblCfim = new System.Windows.Forms.Label();
            this.lblCini = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 11);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 31);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Bubble";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(90, 11);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(78, 31);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Selection";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(174, 11);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(78, 31);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Insertion";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(258, 11);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(78, 31);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Quick";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(342, 11);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 31);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "Merge";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAtemp);
            this.groupBox1.Controls.Add(this.lblAfim);
            this.groupBox1.Controls.Add(this.lblAini);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vetor A";
            // 
            // lblAtemp
            // 
            this.lblAtemp.AutoSize = true;
            this.lblAtemp.Location = new System.Drawing.Point(56, 75);
            this.lblAtemp.Name = "lblAtemp";
            this.lblAtemp.Size = new System.Drawing.Size(13, 13);
            this.lblAtemp.TabIndex = 5;
            this.lblAtemp.Text = "--";
            // 
            // lblAfim
            // 
            this.lblAfim.AutoSize = true;
            this.lblAfim.Location = new System.Drawing.Point(56, 62);
            this.lblAfim.Name = "lblAfim";
            this.lblAfim.Size = new System.Drawing.Size(13, 13);
            this.lblAfim.TabIndex = 4;
            this.lblAfim.Text = "--";
            // 
            // lblAini
            // 
            this.lblAini.AutoSize = true;
            this.lblAini.Location = new System.Drawing.Point(56, 47);
            this.lblAini.Name = "lblAini";
            this.lblAini.Size = new System.Drawing.Size(13, 13);
            this.lblAini.TabIndex = 3;
            this.lblAini.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBtemp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblBfim);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblBini);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(149, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 143);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VetorB";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCtemp);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblCfim);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblCini);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(293, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 143);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vetor C";
            // 
            // lblBtemp
            // 
            this.lblBtemp.AutoSize = true;
            this.lblBtemp.Location = new System.Drawing.Point(56, 75);
            this.lblBtemp.Name = "lblBtemp";
            this.lblBtemp.Size = new System.Drawing.Size(13, 13);
            this.lblBtemp.TabIndex = 11;
            this.lblBtemp.Text = "--";
            // 
            // lblBfim
            // 
            this.lblBfim.AutoSize = true;
            this.lblBfim.Location = new System.Drawing.Point(56, 62);
            this.lblBfim.Name = "lblBfim";
            this.lblBfim.Size = new System.Drawing.Size(13, 13);
            this.lblBfim.TabIndex = 10;
            this.lblBfim.Text = "--";
            // 
            // lblBini
            // 
            this.lblBini.AutoSize = true;
            this.lblBini.Location = new System.Drawing.Point(56, 47);
            this.lblBini.Name = "lblBini";
            this.lblBini.Size = new System.Drawing.Size(13, 13);
            this.lblBini.TabIndex = 9;
            this.lblBini.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tempo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fim:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Inicio:";
            // 
            // lblCtemp
            // 
            this.lblCtemp.AutoSize = true;
            this.lblCtemp.Location = new System.Drawing.Point(56, 75);
            this.lblCtemp.Name = "lblCtemp";
            this.lblCtemp.Size = new System.Drawing.Size(13, 13);
            this.lblCtemp.TabIndex = 17;
            this.lblCtemp.Text = "--";
            // 
            // lblCfim
            // 
            this.lblCfim.AutoSize = true;
            this.lblCfim.Location = new System.Drawing.Point(56, 62);
            this.lblCfim.Name = "lblCfim";
            this.lblCfim.Size = new System.Drawing.Size(13, 13);
            this.lblCfim.TabIndex = 16;
            this.lblCfim.Text = "--";
            // 
            // lblCini
            // 
            this.lblCini.AutoSize = true;
            this.lblCini.Location = new System.Drawing.Point(56, 47);
            this.lblCini.Name = "lblCini";
            this.lblCini.Size = new System.Drawing.Size(13, 13);
            this.lblCini.TabIndex = 15;
            this.lblCini.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tempo :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Fim:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Inicio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 276);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Metodos de Ordenacao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAtemp;
        private System.Windows.Forms.Label lblAfim;
        private System.Windows.Forms.Label lblAini;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBtemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBfim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBini;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCtemp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCfim;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCini;
        private System.Windows.Forms.Label label13;
    }
}

