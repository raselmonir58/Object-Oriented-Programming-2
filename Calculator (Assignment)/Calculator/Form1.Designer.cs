namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bce = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bpoint = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lcurrentOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b7.Location = new System.Drawing.Point(12, 118);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(50, 50);
            this.b7.TabIndex = 0;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b_click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b8.Location = new System.Drawing.Point(68, 118);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(50, 50);
            this.b8.TabIndex = 1;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b_click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b9.Location = new System.Drawing.Point(124, 118);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(50, 50);
            this.b9.TabIndex = 2;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b_click);
            // 
            // bdiv
            // 
            this.bdiv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bdiv.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bdiv.Location = new System.Drawing.Point(180, 118);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(50, 50);
            this.bdiv.TabIndex = 3;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = false;
            this.bdiv.Click += new System.EventHandler(this.op_click);
            // 
            // bce
            // 
            this.bce.BackColor = System.Drawing.Color.Red;
            this.bce.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bce.Location = new System.Drawing.Point(236, 118);
            this.bce.Name = "bce";
            this.bce.Size = new System.Drawing.Size(50, 50);
            this.bce.TabIndex = 4;
            this.bce.Text = "CE";
            this.bce.UseVisualStyleBackColor = false;
            this.bce.Click += new System.EventHandler(this.bce_Click);
            // 
            // bsub
            // 
            this.bsub.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bsub.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bsub.Location = new System.Drawing.Point(180, 230);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(50, 50);
            this.bsub.TabIndex = 8;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = false;
            this.bsub.Click += new System.EventHandler(this.op_click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b3.Location = new System.Drawing.Point(124, 230);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(50, 50);
            this.b3.TabIndex = 7;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b_click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b2.Location = new System.Drawing.Point(68, 230);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(50, 50);
            this.b2.TabIndex = 6;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b_click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b1.Location = new System.Drawing.Point(12, 230);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(50, 50);
            this.b1.TabIndex = 5;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b_click);
            // 
            // bc
            // 
            this.bc.BackColor = System.Drawing.Color.Red;
            this.bc.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bc.Location = new System.Drawing.Point(236, 169);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(50, 50);
            this.bc.TabIndex = 14;
            this.bc.Text = "C";
            this.bc.UseVisualStyleBackColor = false;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // bmul
            // 
            this.bmul.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bmul.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bmul.Location = new System.Drawing.Point(180, 174);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(50, 50);
            this.bmul.TabIndex = 13;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = false;
            this.bmul.Click += new System.EventHandler(this.op_click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b6.Location = new System.Drawing.Point(124, 174);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(50, 50);
            this.b6.TabIndex = 12;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b_click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b5.Location = new System.Drawing.Point(68, 174);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(50, 50);
            this.b5.TabIndex = 11;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b_click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b4.Location = new System.Drawing.Point(12, 174);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(50, 50);
            this.b4.TabIndex = 10;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b_click);
            // 
            // bequal
            // 
            this.bequal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bequal.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bequal.Location = new System.Drawing.Point(236, 230);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(50, 106);
            this.bequal.TabIndex = 19;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = false;
            this.bequal.Click += new System.EventHandler(this.bequal_click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.badd.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.badd.Location = new System.Drawing.Point(180, 286);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(50, 50);
            this.badd.TabIndex = 18;
            this.badd.Text = "+";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.op_click);
            // 
            // bpoint
            // 
            this.bpoint.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bpoint.Location = new System.Drawing.Point(124, 286);
            this.bpoint.Name = "bpoint";
            this.bpoint.Size = new System.Drawing.Size(50, 50);
            this.bpoint.TabIndex = 17;
            this.bpoint.Text = ".";
            this.bpoint.UseVisualStyleBackColor = true;
            this.bpoint.Click += new System.EventHandler(this.b_click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b0.Location = new System.Drawing.Point(12, 286);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(106, 50);
            this.b0.TabIndex = 15;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b_click);
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(12, 52);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(274, 38);
            this.textBox.TabIndex = 20;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lcurrentOp
            // 
            this.lcurrentOp.AutoSize = true;
            this.lcurrentOp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lcurrentOp.Location = new System.Drawing.Point(12, 9);
            this.lcurrentOp.Name = "lcurrentOp";
            this.lcurrentOp.Size = new System.Drawing.Size(0, 31);
            this.lcurrentOp.TabIndex = 21;
            this.lcurrentOp.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 360);
            this.Controls.Add(this.lcurrentOp);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.bpoint);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bce);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button b7;
        private Button b8;
        private Button b9;
        private Button bdiv;
        private Button bce;
        private Button bsub;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button bc;
        private Button bmul;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button bequal;
        private Button badd;
        private Button bpoint;
        private Button b0;
        private TextBox textBox;
        private Label lcurrentOp;
    }
}