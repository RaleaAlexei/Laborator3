namespace PhotoApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioS3 = new System.Windows.Forms.RadioButton();
            this.radioS2 = new System.Windows.Forms.RadioButton();
            this.radioS1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btCalculeaza = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.radioS6 = new System.Windows.Forms.RadioButton();
            this.radioS5 = new System.Windows.Forms.RadioButton();
            this.radioS4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.radioS6);
            this.groupBox1.Controls.Add(this.radioS5);
            this.groupBox1.Controls.Add(this.radioS4);
            this.groupBox1.Controls.Add(this.radioS3);
            this.groupBox1.Controls.Add(this.radioS2);
            this.groupBox1.Controls.Add(this.radioS1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optiuni fotografii";
            // 
            // radioS3
            // 
            this.radioS3.AutoSize = true;
            this.radioS3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioS3.Location = new System.Drawing.Point(6, 93);
            this.radioS3.Name = "radioS3";
            this.radioS3.Size = new System.Drawing.Size(73, 23);
            this.radioS3.TabIndex = 2;
            this.radioS3.TabStop = true;
            this.radioS3.Text = "18 x 24";
            this.radioS3.UseVisualStyleBackColor = true;
            this.radioS3.Click += new System.EventHandler(this.radioS1_Click);
            // 
            // radioS2
            // 
            this.radioS2.AutoSize = true;
            this.radioS2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioS2.Location = new System.Drawing.Point(6, 64);
            this.radioS2.Name = "radioS2";
            this.radioS2.Size = new System.Drawing.Size(73, 23);
            this.radioS2.TabIndex = 1;
            this.radioS2.TabStop = true;
            this.radioS2.Text = "12 x 15";
            this.radioS2.UseVisualStyleBackColor = true;
            this.radioS2.Click += new System.EventHandler(this.radioS1_Click);
            // 
            // radioS1
            // 
            this.radioS1.AutoSize = true;
            this.radioS1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioS1.Location = new System.Drawing.Point(6, 35);
            this.radioS1.Name = "radioS1";
            this.radioS1.Size = new System.Drawing.Size(65, 23);
            this.radioS1.TabIndex = 0;
            this.radioS1.TabStop = true;
            this.radioS1.Text = "9 x 12";
            this.radioS1.UseVisualStyleBackColor = true;
            this.radioS1.Click += new System.EventHandler(this.radioS1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduceti cantitatea";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmount.Location = new System.Drawing.Point(218, 44);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(217, 32);
            this.tbAmount.TabIndex = 2;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // btCalculeaza
            // 
            this.btCalculeaza.Enabled = false;
            this.btCalculeaza.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCalculeaza.Location = new System.Drawing.Point(218, 82);
            this.btCalculeaza.Name = "btCalculeaza";
            this.btCalculeaza.Size = new System.Drawing.Size(217, 40);
            this.btCalculeaza.TabIndex = 3;
            this.btCalculeaza.Text = "Calculeaza";
            this.btCalculeaza.UseVisualStyleBackColor = true;
            this.btCalculeaza.Click += new System.EventHandler(this.btCalculeaza_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.ForeColor = System.Drawing.Color.Black;
            this.labelResult.Location = new System.Drawing.Point(7, 137);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(423, 98);
            this.labelResult.TabIndex = 4;
            // 
            // radioS6
            // 
            this.radioS6.AutoSize = true;
            this.radioS6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioS6.Location = new System.Drawing.Point(109, 93);
            this.radioS6.Name = "radioS6";
            this.radioS6.Size = new System.Drawing.Size(73, 23);
            this.radioS6.TabIndex = 5;
            this.radioS6.TabStop = true;
            this.radioS6.Text = "24 x 24";
            this.radioS6.UseVisualStyleBackColor = true;
            this.radioS6.Click += new System.EventHandler(this.radioS1_Click);
            // 
            // radioS5
            // 
            this.radioS5.AutoSize = true;
            this.radioS5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioS5.Location = new System.Drawing.Point(109, 64);
            this.radioS5.Name = "radioS5";
            this.radioS5.Size = new System.Drawing.Size(73, 23);
            this.radioS5.TabIndex = 4;
            this.radioS5.TabStop = true;
            this.radioS5.Text = "15 x 15";
            this.radioS5.UseVisualStyleBackColor = true;
            this.radioS5.Click += new System.EventHandler(this.radioS1_Click);
            // 
            // radioS4
            // 
            this.radioS4.AutoSize = true;
            this.radioS4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioS4.Location = new System.Drawing.Point(109, 35);
            this.radioS4.Name = "radioS4";
            this.radioS4.Size = new System.Drawing.Size(73, 23);
            this.radioS4.TabIndex = 3;
            this.radioS4.TabStop = true;
            this.radioS4.Text = "12 x 12";
            this.radioS4.UseVisualStyleBackColor = true;
            this.radioS4.Click += new System.EventHandler(this.radioS1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 244);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btCalculeaza);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioS3;
        private RadioButton radioS2;
        private RadioButton radioS1;
        private Label label1;
        private TextBox tbAmount;
        private Button btCalculeaza;
        private Label labelResult;
        private RadioButton radioS6;
        private RadioButton radioS5;
        private RadioButton radioS4;
    }
}