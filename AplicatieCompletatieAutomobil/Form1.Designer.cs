namespace AplicatieCompletatieAutomobil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLocuri = new System.Windows.Forms.CheckBox();
            this.cbMotor = new System.Windows.Forms.CheckBox();
            this.cbTire = new System.Windows.Forms.CheckBox();
            this.cbSecuritate = new System.Windows.Forms.CheckBox();
            this.cbParctronic = new System.Windows.Forms.CheckBox();
            this.cbAbs = new System.Windows.Forms.CheckBox();
            this.btCalculeaza = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dacia Jogger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pretul de baza: 240000 Lei ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.cbLocuri);
            this.groupBox1.Controls.Add(this.cbMotor);
            this.groupBox1.Controls.Add(this.cbTire);
            this.groupBox1.Controls.Add(this.cbSecuritate);
            this.groupBox1.Controls.Add(this.cbParctronic);
            this.groupBox1.Controls.Add(this.cbAbs);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facilitati suplimentare: ";
            // 
            // cbLocuri
            // 
            this.cbLocuri.AutoSize = true;
            this.cbLocuri.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLocuri.Location = new System.Drawing.Point(128, 104);
            this.cbLocuri.Name = "cbLocuri";
            this.cbLocuri.Size = new System.Drawing.Size(111, 29);
            this.cbLocuri.TabIndex = 5;
            this.cbLocuri.Text = "+2 Locuri";
            this.cbLocuri.UseVisualStyleBackColor = true;
            this.cbLocuri.CheckedChanged += new System.EventHandler(this.modcheckbox_CheckedChanged);
            // 
            // cbMotor
            // 
            this.cbMotor.AutoSize = true;
            this.cbMotor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMotor.Location = new System.Drawing.Point(128, 69);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(83, 29);
            this.cbMotor.TabIndex = 4;
            this.cbMotor.Text = "Motor";
            this.cbMotor.UseVisualStyleBackColor = true;
            this.cbMotor.CheckedChanged += new System.EventHandler(this.modcheckbox_CheckedChanged);
            // 
            // cbTire
            // 
            this.cbTire.AutoSize = true;
            this.cbTire.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTire.Location = new System.Drawing.Point(128, 34);
            this.cbTire.Name = "cbTire";
            this.cbTire.Size = new System.Drawing.Size(148, 29);
            this.cbTire.TabIndex = 3;
            this.cbTire.Text = "Roata Rezerva";
            this.cbTire.UseVisualStyleBackColor = true;
            this.cbTire.CheckedChanged += new System.EventHandler(this.modcheckbox_CheckedChanged);
            // 
            // cbSecuritate
            // 
            this.cbSecuritate.AutoSize = true;
            this.cbSecuritate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSecuritate.Location = new System.Drawing.Point(6, 104);
            this.cbSecuritate.Name = "cbSecuritate";
            this.cbSecuritate.Size = new System.Drawing.Size(115, 29);
            this.cbSecuritate.TabIndex = 2;
            this.cbSecuritate.Text = "Securitate";
            this.cbSecuritate.UseVisualStyleBackColor = true;
            this.cbSecuritate.CheckedChanged += new System.EventHandler(this.modcheckbox_CheckedChanged);
            // 
            // cbParctronic
            // 
            this.cbParctronic.AutoSize = true;
            this.cbParctronic.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbParctronic.Location = new System.Drawing.Point(6, 69);
            this.cbParctronic.Name = "cbParctronic";
            this.cbParctronic.Size = new System.Drawing.Size(116, 29);
            this.cbParctronic.TabIndex = 1;
            this.cbParctronic.Text = "Parctronic";
            this.cbParctronic.UseVisualStyleBackColor = true;
            this.cbParctronic.CheckedChanged += new System.EventHandler(this.modcheckbox_CheckedChanged);
            // 
            // cbAbs
            // 
            this.cbAbs.AutoSize = true;
            this.cbAbs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAbs.Location = new System.Drawing.Point(6, 34);
            this.cbAbs.Name = "cbAbs";
            this.cbAbs.Size = new System.Drawing.Size(64, 29);
            this.cbAbs.TabIndex = 0;
            this.cbAbs.Text = "ABS";
            this.cbAbs.UseVisualStyleBackColor = true;
            this.cbAbs.CheckedChanged += new System.EventHandler(this.modcheckbox_CheckedChanged);
            // 
            // btCalculeaza
            // 
            this.btCalculeaza.Location = new System.Drawing.Point(12, 247);
            this.btCalculeaza.Name = "btCalculeaza";
            this.btCalculeaza.Size = new System.Drawing.Size(288, 40);
            this.btCalculeaza.TabIndex = 3;
            this.btCalculeaza.Text = "Calculeaza";
            this.btCalculeaza.UseVisualStyleBackColor = true;
            this.btCalculeaza.Click += new System.EventHandler(this.btCalculeaza_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicatieCompletatieAutomobil.Properties.Resources.dacia;
            this.pictureBox1.Location = new System.Drawing.Point(306, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(12, 290);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(690, 67);
            this.labelResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 366);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCalculeaza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private CheckBox cbSecuritate;
        private CheckBox cbParctronic;
        private CheckBox cbAbs;
        private Button btCalculeaza;
        private PictureBox pictureBox1;
        private Label labelResult;
        private CheckBox cbLocuri;
        private CheckBox cbMotor;
        private CheckBox cbTire;
    }
}