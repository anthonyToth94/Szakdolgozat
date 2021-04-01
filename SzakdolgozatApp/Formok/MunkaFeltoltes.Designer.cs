namespace SzakdolgozatApp
{
    partial class MunkaFeltoltes
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
            this.cBoxMunkakor1 = new System.Windows.Forms.ComboBox();
            this.cBoxHelyszin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeiras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFeltoltes = new System.Windows.Forms.Button();
            this.lblHiba = new System.Windows.Forms.Label();
            this.txtCegNev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxFizetes = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cBoxMunkakor1
            // 
            this.cBoxMunkakor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cBoxMunkakor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMunkakor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cBoxMunkakor1.ForeColor = System.Drawing.Color.White;
            this.cBoxMunkakor1.FormattingEnabled = true;
            this.cBoxMunkakor1.Items.AddRange(new object[] {
            "Konyhai kisegítő",
            "Szakács",
            "Pincér",
            "Barista"});
            this.cBoxMunkakor1.Location = new System.Drawing.Point(86, 153);
            this.cBoxMunkakor1.Name = "cBoxMunkakor1";
            this.cBoxMunkakor1.Size = new System.Drawing.Size(121, 28);
            this.cBoxMunkakor1.TabIndex = 15;
            // 
            // cBoxHelyszin
            // 
            this.cBoxHelyszin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cBoxHelyszin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxHelyszin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cBoxHelyszin.ForeColor = System.Drawing.Color.White;
            this.cBoxHelyszin.FormattingEnabled = true;
            this.cBoxHelyszin.Items.AddRange(new object[] {
            "Békés",
            "Békéscsaba",
            "Szeghalom",
            "Vésztő"});
            this.cBoxHelyszin.Location = new System.Drawing.Point(86, 203);
            this.cBoxHelyszin.Name = "cBoxHelyszin";
            this.cBoxHelyszin.Size = new System.Drawing.Size(121, 28);
            this.cBoxHelyszin.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Helyszín:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Munkakör:";
            // 
            // txtLeiras
            // 
            this.txtLeiras.Location = new System.Drawing.Point(247, 58);
            this.txtLeiras.Multiline = true;
            this.txtLeiras.Name = "txtLeiras";
            this.txtLeiras.Size = new System.Drawing.Size(263, 268);
            this.txtLeiras.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(340, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Leírás:";
            // 
            // btnFeltoltes
            // 
            this.btnFeltoltes.BackColor = System.Drawing.Color.Teal;
            this.btnFeltoltes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeltoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFeltoltes.ForeColor = System.Drawing.Color.White;
            this.btnFeltoltes.Location = new System.Drawing.Point(67, 300);
            this.btnFeltoltes.Name = "btnFeltoltes";
            this.btnFeltoltes.Size = new System.Drawing.Size(140, 28);
            this.btnFeltoltes.TabIndex = 20;
            this.btnFeltoltes.Text = "Feltöltés";
            this.btnFeltoltes.UseVisualStyleBackColor = false;
            this.btnFeltoltes.Click += new System.EventHandler(this.btnFeltoltes_Click);
            // 
            // lblHiba
            // 
            this.lblHiba.AutoSize = true;
            this.lblHiba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHiba.ForeColor = System.Drawing.Color.Red;
            this.lblHiba.Location = new System.Drawing.Point(78, 273);
            this.lblHiba.Name = "lblHiba";
            this.lblHiba.Size = new System.Drawing.Size(0, 18);
            this.lblHiba.TabIndex = 21;
            // 
            // txtCegNev
            // 
            this.txtCegNev.Location = new System.Drawing.Point(31, 63);
            this.txtCegNev.Name = "txtCegNev";
            this.txtCegNev.Size = new System.Drawing.Size(200, 20);
            this.txtCegNev.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(96, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cég neve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dátum és időpont:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fizetés:";
            // 
            // txtBoxFizetes
            // 
            this.txtBoxFizetes.Location = new System.Drawing.Point(85, 242);
            this.txtBoxFizetes.Name = "txtBoxFizetes";
            this.txtBoxFizetes.Size = new System.Drawing.Size(120, 20);
            this.txtBoxFizetes.TabIndex = 25;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(94, 116);
            this.maskedTextBox1.Mask = "0000/00/00 90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 26;
            // 
            // MunkaFeltoltes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(537, 368);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtBoxFizetes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCegNev);
            this.Controls.Add(this.lblHiba);
            this.Controls.Add(this.btnFeltoltes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLeiras);
            this.Controls.Add(this.cBoxMunkakor1);
            this.Controls.Add(this.cBoxHelyszin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MunkaFeltoltes";
            this.Text = "MunkaFeltoltes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxMunkakor1;
        private System.Windows.Forms.ComboBox cBoxHelyszin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeiras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFeltoltes;
        private System.Windows.Forms.Label lblHiba;
        private System.Windows.Forms.TextBox txtCegNev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxFizetes;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}