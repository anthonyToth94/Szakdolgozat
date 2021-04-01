namespace SzakdolgozatApp
{
    partial class AdatokMegadasa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cBoxMunkakor = new System.Windows.Forms.ComboBox();
            this.cBoxLakhely = new System.Windows.Forms.ComboBox();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioFerfi = new System.Windows.Forms.RadioButton();
            this.txtTelefonszam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFrissites = new System.Windows.Forms.Button();
            this.lblsikeresFrissites = new System.Windows.Forms.Label();
            this.labelNeme = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(112, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adja meg az adatokat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefonszám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lakhelye:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Munkakör:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.cBoxMunkakor);
            this.panel2.Controls.Add(this.cBoxLakhely);
            this.panel2.Controls.Add(this.radioNo);
            this.panel2.Controls.Add(this.radioFerfi);
            this.panel2.Controls.Add(this.txtTelefonszam);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(61, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 177);
            this.panel2.TabIndex = 8;
            // 
            // cBoxMunkakor
            // 
            this.cBoxMunkakor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cBoxMunkakor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMunkakor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cBoxMunkakor.ForeColor = System.Drawing.Color.White;
            this.cBoxMunkakor.FormattingEnabled = true;
            this.cBoxMunkakor.Items.AddRange(new object[] {
            "Konyhai kisegítő",
            "Szakács",
            "Pincér",
            "Barista"});
            this.cBoxMunkakor.Location = new System.Drawing.Point(87, 97);
            this.cBoxMunkakor.Name = "cBoxMunkakor";
            this.cBoxMunkakor.Size = new System.Drawing.Size(121, 28);
            this.cBoxMunkakor.TabIndex = 12;
            // 
            // cBoxLakhely
            // 
            this.cBoxLakhely.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cBoxLakhely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLakhely.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cBoxLakhely.ForeColor = System.Drawing.Color.White;
            this.cBoxLakhely.FormattingEnabled = true;
            this.cBoxLakhely.Items.AddRange(new object[] {
            "Békés",
            "Békéscsaba",
            "Szeghalom",
            "Vésztő"});
            this.cBoxLakhely.Location = new System.Drawing.Point(87, 57);
            this.cBoxLakhely.Name = "cBoxLakhely";
            this.cBoxLakhely.Size = new System.Drawing.Size(121, 28);
            this.cBoxLakhely.TabIndex = 12;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.ForeColor = System.Drawing.Color.White;
            this.radioNo.Location = new System.Drawing.Point(129, 136);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 17);
            this.radioNo.TabIndex = 6;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "Nő";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // radioFerfi
            // 
            this.radioFerfi.AutoSize = true;
            this.radioFerfi.ForeColor = System.Drawing.Color.White;
            this.radioFerfi.Location = new System.Drawing.Point(87, 136);
            this.radioFerfi.Name = "radioFerfi";
            this.radioFerfi.Size = new System.Drawing.Size(45, 17);
            this.radioFerfi.TabIndex = 6;
            this.radioFerfi.TabStop = true;
            this.radioFerfi.Text = "Férfi";
            this.radioFerfi.UseVisualStyleBackColor = true;
            // 
            // txtTelefonszam
            // 
            this.txtTelefonszam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txtTelefonszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTelefonszam.ForeColor = System.Drawing.Color.White;
            this.txtTelefonszam.Location = new System.Drawing.Point(87, 17);
            this.txtTelefonszam.Name = "txtTelefonszam";
            this.txtTelefonszam.Size = new System.Drawing.Size(138, 26);
            this.txtTelefonszam.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(33, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 37);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neme";
            // 
            // btnFrissites
            // 
            this.btnFrissites.BackColor = System.Drawing.Color.Teal;
            this.btnFrissites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrissites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFrissites.ForeColor = System.Drawing.Color.White;
            this.btnFrissites.Location = new System.Drawing.Point(145, 273);
            this.btnFrissites.Name = "btnFrissites";
            this.btnFrissites.Size = new System.Drawing.Size(140, 28);
            this.btnFrissites.TabIndex = 11;
            this.btnFrissites.Text = "Frissites";
            this.btnFrissites.UseVisualStyleBackColor = false;
            this.btnFrissites.Click += new System.EventHandler(this.btnFrissites_Click);
            // 
            // lblsikeresFrissites
            // 
            this.lblsikeresFrissites.AutoSize = true;
            this.lblsikeresFrissites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblsikeresFrissites.ForeColor = System.Drawing.Color.Red;
            this.lblsikeresFrissites.Location = new System.Drawing.Point(149, 322);
            this.lblsikeresFrissites.Name = "lblsikeresFrissites";
            this.lblsikeresFrissites.Size = new System.Drawing.Size(0, 20);
            this.lblsikeresFrissites.TabIndex = 12;
            // 
            // labelNeme
            // 
            this.labelNeme.AutoSize = true;
            this.labelNeme.Location = new System.Drawing.Point(383, 273);
            this.labelNeme.Name = "labelNeme";
            this.labelNeme.Size = new System.Drawing.Size(0, 13);
            this.labelNeme.TabIndex = 13;
            this.labelNeme.Visible = false;
            // 
            // AdatokMegadasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(537, 368);
            this.Controls.Add(this.labelNeme);
            this.Controls.Add(this.lblsikeresFrissites);
            this.Controls.Add(this.btnFrissites);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "AdatokMegadasa";
            this.Text = "AdatokMegadasa";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTelefonszam;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioFerfi;
        private System.Windows.Forms.Button btnFrissites;
        private System.Windows.Forms.ComboBox cBoxMunkakor;
        private System.Windows.Forms.ComboBox cBoxLakhely;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsikeresFrissites;
        private System.Windows.Forms.Label labelNeme;
    }
}