namespace SzakdolgozatApp
{
    partial class Belepes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Belepes));
            this.btnBelepes = new System.Windows.Forms.Button();
            this.lnkRegisztracio = new System.Windows.Forms.LinkLabel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtJelszo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblHibasBelepes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblKilepes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBelepes
            // 
            this.btnBelepes.BackColor = System.Drawing.Color.Teal;
            this.btnBelepes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBelepes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBelepes.ForeColor = System.Drawing.Color.White;
            this.btnBelepes.Location = new System.Drawing.Point(26, 205);
            this.btnBelepes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBelepes.Name = "btnBelepes";
            this.btnBelepes.Size = new System.Drawing.Size(200, 35);
            this.btnBelepes.TabIndex = 3;
            this.btnBelepes.Text = "Belépés";
            this.btnBelepes.UseVisualStyleBackColor = false;
            this.btnBelepes.Click += new System.EventHandler(this.btnBelepes_Click);
            // 
            // lnkRegisztracio
            // 
            this.lnkRegisztracio.AutoSize = true;
            this.lnkRegisztracio.Location = new System.Drawing.Point(24, 269);
            this.lnkRegisztracio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRegisztracio.Name = "lnkRegisztracio";
            this.lnkRegisztracio.Size = new System.Drawing.Size(204, 20);
            this.lnkRegisztracio.TabIndex = 0;
            this.lnkRegisztracio.TabStop = true;
            this.lnkRegisztracio.Text = "Még nem vagy regisztrálva?";
            this.lnkRegisztracio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegisztracio_LinkClicked);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Location = new System.Drawing.Point(26, 93);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.Size = new System.Drawing.Size(219, 19);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "E-mail";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtJelszo
            // 
            this.txtJelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txtJelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtJelszo.ForeColor = System.Drawing.Color.DarkGray;
            this.txtJelszo.Location = new System.Drawing.Point(26, 141);
            this.txtJelszo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJelszo.Name = "txtJelszo";
            this.txtJelszo.Size = new System.Drawing.Size(219, 19);
            this.txtJelszo.TabIndex = 2;
            this.txtJelszo.Text = "Jelszó";
            this.txtJelszo.Enter += new System.EventHandler(this.txtJelszo_Enter);
            this.txtJelszo.Leave += new System.EventHandler(this.txtJelszo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bejelentkezés";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Location = new System.Drawing.Point(252, 45);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(336, 283);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblHibasBelepes
            // 
            this.lblHibasBelepes.AutoSize = true;
            this.lblHibasBelepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblHibasBelepes.ForeColor = System.Drawing.Color.Red;
            this.lblHibasBelepes.Location = new System.Drawing.Point(24, 174);
            this.lblHibasBelepes.Name = "lblHibasBelepes";
            this.lblHibasBelepes.Size = new System.Drawing.Size(0, 20);
            this.lblHibasBelepes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(26, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(26, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.lblKilepes);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(604, 38);
            this.panel3.TabIndex = 4;
            // 
            // lblKilepes
            // 
            this.lblKilepes.AutoSize = true;
            this.lblKilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblKilepes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKilepes.ForeColor = System.Drawing.Color.White;
            this.lblKilepes.Location = new System.Drawing.Point(567, 8);
            this.lblKilepes.Name = "lblKilepes";
            this.lblKilepes.Size = new System.Drawing.Size(24, 24);
            this.lblKilepes.TabIndex = 0;
            this.lblKilepes.Text = "X";
            this.lblKilepes.Click += new System.EventHandler(this.lblKilepes_Click);
            this.lblKilepes.MouseEnter += new System.EventHandler(this.lblKilepes_MouseEnter);
            this.lblKilepes.MouseLeave += new System.EventHandler(this.lblKilepes_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // Belepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHibasBelepes);
            this.Controls.Add(this.txtJelszo);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.lnkRegisztracio);
            this.Controls.Add(this.btnBelepes);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "Belepes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBelepes;
        private System.Windows.Forms.LinkLabel lnkRegisztracio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtJelszo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblHibasBelepes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblKilepes;
        private System.Windows.Forms.Label label1;
    }
}

