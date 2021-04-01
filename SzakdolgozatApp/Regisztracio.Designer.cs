namespace SzakdolgozatApp
{
    partial class Regisztracio
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
            this.txtEmailR = new System.Windows.Forms.TextBox();
            this.txtJelszoR2 = new System.Windows.Forms.TextBox();
            this.btnRegisztracio = new System.Windows.Forms.Button();
            this.lnkBejelentkezes = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtJelszoR = new System.Windows.Forms.TextBox();
            this.txtKernev = new System.Windows.Forms.TextBox();
            this.txtVeznev = new System.Windows.Forms.TextBox();
            this.lblKilepRegisztracio = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblHibasRegisztracio = new System.Windows.Forms.Label();
            this.lblSikeresReg = new System.Windows.Forms.Label();
            this.radioAjanl = new System.Windows.Forms.RadioButton();
            this.radioVallal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtEmailR
            // 
            this.txtEmailR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txtEmailR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmailR.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmailR.Location = new System.Drawing.Point(143, 175);
            this.txtEmailR.Name = "txtEmailR";
            this.txtEmailR.Size = new System.Drawing.Size(203, 19);
            this.txtEmailR.TabIndex = 3;
            this.txtEmailR.Text = "*E-mail";
            this.txtEmailR.Enter += new System.EventHandler(this.txtEmailR_Enter);
            this.txtEmailR.Leave += new System.EventHandler(this.txtEmailR_Leave);
            // 
            // txtJelszoR2
            // 
            this.txtJelszoR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txtJelszoR2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJelszoR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtJelszoR2.ForeColor = System.Drawing.Color.DarkGray;
            this.txtJelszoR2.Location = new System.Drawing.Point(143, 267);
            this.txtJelszoR2.Name = "txtJelszoR2";
            this.txtJelszoR2.Size = new System.Drawing.Size(203, 19);
            this.txtJelszoR2.TabIndex = 5;
            this.txtJelszoR2.Text = "*Jelszó ismétlés";
            this.txtJelszoR2.Enter += new System.EventHandler(this.txtJelszoR2_Enter);
            this.txtJelszoR2.Leave += new System.EventHandler(this.txtJelszoR2_Leave);
            // 
            // btnRegisztracio
            // 
            this.btnRegisztracio.BackColor = System.Drawing.Color.Teal;
            this.btnRegisztracio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisztracio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegisztracio.ForeColor = System.Drawing.Color.White;
            this.btnRegisztracio.Location = new System.Drawing.Point(143, 364);
            this.btnRegisztracio.Name = "btnRegisztracio";
            this.btnRegisztracio.Size = new System.Drawing.Size(203, 30);
            this.btnRegisztracio.TabIndex = 7;
            this.btnRegisztracio.Text = "Regisztráció";
            this.btnRegisztracio.UseVisualStyleBackColor = false;
            this.btnRegisztracio.Click += new System.EventHandler(this.btnRegisztracio_Click);
            // 
            // lnkBejelentkezes
            // 
            this.lnkBejelentkezes.AutoSize = true;
            this.lnkBejelentkezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnkBejelentkezes.Location = new System.Drawing.Point(156, 440);
            this.lnkBejelentkezes.Name = "lnkBejelentkezes";
            this.lnkBejelentkezes.Size = new System.Drawing.Size(168, 20);
            this.lnkBejelentkezes.TabIndex = 0;
            this.lnkBejelentkezes.TabStop = true;
            this.lnkBejelentkezes.Text = "Már van felhasználód?";
            this.lnkBejelentkezes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBejelentkezes_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regisztráció";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(143, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(143, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(143, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(143, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(143, 285);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 1);
            this.panel5.TabIndex = 10;
            // 
            // txtJelszoR
            // 
            this.txtJelszoR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txtJelszoR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJelszoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtJelszoR.ForeColor = System.Drawing.Color.DarkGray;
            this.txtJelszoR.Location = new System.Drawing.Point(143, 222);
            this.txtJelszoR.Name = "txtJelszoR";
            this.txtJelszoR.Size = new System.Drawing.Size(203, 19);
            this.txtJelszoR.TabIndex = 4;
            this.txtJelszoR.Text = "*Jelszó";
            this.txtJelszoR.Enter += new System.EventHandler(this.txtJelszoR_Enter);
            this.txtJelszoR.Leave += new System.EventHandler(this.txtJelszoR_Leave);
            // 
            // txtKernev
            // 
            this.txtKernev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txtKernev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKernev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKernev.ForeColor = System.Drawing.Color.DarkGray;
            this.txtKernev.Location = new System.Drawing.Point(143, 128);
            this.txtKernev.Name = "txtKernev";
            this.txtKernev.Size = new System.Drawing.Size(100, 19);
            this.txtKernev.TabIndex = 2;
            this.txtKernev.Text = "*Kereszt név";
            this.txtKernev.Enter += new System.EventHandler(this.txtKernev_Enter);
            this.txtKernev.Leave += new System.EventHandler(this.txtKernev_Leave);
            // 
            // txtVeznev
            // 
            this.txtVeznev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txtVeznev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVeznev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtVeznev.ForeColor = System.Drawing.Color.DarkGray;
            this.txtVeznev.Location = new System.Drawing.Point(143, 86);
            this.txtVeznev.Name = "txtVeznev";
            this.txtVeznev.Size = new System.Drawing.Size(100, 19);
            this.txtVeznev.TabIndex = 1;
            this.txtVeznev.Text = "*Vezeték név";
            this.txtVeznev.Enter += new System.EventHandler(this.txtVeznev_Enter);
            this.txtVeznev.Leave += new System.EventHandler(this.txtVeznev_Leave);
            // 
            // lblKilepRegisztracio
            // 
            this.lblKilepRegisztracio.AutoSize = true;
            this.lblKilepRegisztracio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKilepRegisztracio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKilepRegisztracio.ForeColor = System.Drawing.Color.White;
            this.lblKilepRegisztracio.Location = new System.Drawing.Point(448, 9);
            this.lblKilepRegisztracio.Name = "lblKilepRegisztracio";
            this.lblKilepRegisztracio.Size = new System.Drawing.Size(24, 24);
            this.lblKilepRegisztracio.TabIndex = 15;
            this.lblKilepRegisztracio.Text = "X";
            this.lblKilepRegisztracio.Click += new System.EventHandler(this.lblKilepRegisztracio_Click);
            this.lblKilepRegisztracio.MouseEnter += new System.EventHandler(this.lblKilepRegisztracio_MouseEnter);
            this.lblKilepRegisztracio.MouseLeave += new System.EventHandler(this.lblKilepRegisztracio_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel6.Location = new System.Drawing.Point(-1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(501, 43);
            this.panel6.TabIndex = 16;
            // 
            // lblHibasRegisztracio
            // 
            this.lblHibasRegisztracio.AutoSize = true;
            this.lblHibasRegisztracio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHibasRegisztracio.ForeColor = System.Drawing.Color.Red;
            this.lblHibasRegisztracio.Location = new System.Drawing.Point(161, 411);
            this.lblHibasRegisztracio.Name = "lblHibasRegisztracio";
            this.lblHibasRegisztracio.Size = new System.Drawing.Size(0, 20);
            this.lblHibasRegisztracio.TabIndex = 7;
            // 
            // lblSikeresReg
            // 
            this.lblSikeresReg.AutoSize = true;
            this.lblSikeresReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSikeresReg.ForeColor = System.Drawing.Color.Red;
            this.lblSikeresReg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSikeresReg.Location = new System.Drawing.Point(161, 411);
            this.lblSikeresReg.Name = "lblSikeresReg";
            this.lblSikeresReg.Size = new System.Drawing.Size(0, 20);
            this.lblSikeresReg.TabIndex = 14;
            this.lblSikeresReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioAjanl
            // 
            this.radioAjanl.AutoSize = true;
            this.radioAjanl.ForeColor = System.Drawing.Color.White;
            this.radioAjanl.Location = new System.Drawing.Point(247, 318);
            this.radioAjanl.Name = "radioAjanl";
            this.radioAjanl.Size = new System.Drawing.Size(98, 17);
            this.radioAjanl.TabIndex = 17;
            this.radioAjanl.TabStop = true;
            this.radioAjanl.Text = "Munkát ajánlok";
            this.radioAjanl.UseVisualStyleBackColor = true;
            // 
            // radioVallal
            // 
            this.radioVallal.AutoSize = true;
            this.radioVallal.ForeColor = System.Drawing.Color.White;
            this.radioVallal.Location = new System.Drawing.Point(143, 318);
            this.radioVallal.Name = "radioVallal";
            this.radioVallal.Size = new System.Drawing.Size(100, 17);
            this.radioVallal.TabIndex = 18;
            this.radioVallal.TabStop = true;
            this.radioVallal.Text = "Munkát vállalok";
            this.radioVallal.UseVisualStyleBackColor = true;
            // 
            // Regisztracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.radioVallal);
            this.Controls.Add(this.radioAjanl);
            this.Controls.Add(this.lblKilepRegisztracio);
            this.Controls.Add(this.txtVeznev);
            this.Controls.Add(this.txtKernev);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSikeresReg);
            this.Controls.Add(this.lblHibasRegisztracio);
            this.Controls.Add(this.lnkBejelentkezes);
            this.Controls.Add(this.btnRegisztracio);
            this.Controls.Add(this.txtJelszoR2);
            this.Controls.Add(this.txtJelszoR);
            this.Controls.Add(this.txtEmailR);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 480);
            this.Name = "Regisztracio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regisztracio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.LinkLabel lnkBejelentkezes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtVeznev;
        private System.Windows.Forms.TextBox txtKernev;
        private System.Windows.Forms.TextBox txtEmailR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtJelszoR;
        private System.Windows.Forms.TextBox txtJelszoR2;
        private System.Windows.Forms.Button btnRegisztracio;
        private System.Windows.Forms.Label lblKilepRegisztracio;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblHibasRegisztracio;
        private System.Windows.Forms.Label lblSikeresReg;
        private System.Windows.Forms.RadioButton radioAjanl;
        private System.Windows.Forms.RadioButton radioVallal;
    }
}