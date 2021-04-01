namespace SzakdolgozatApp
{
    partial class Munkaim
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
            this.lblFeltoltottMunkak = new System.Windows.Forms.Label();
            this.lblFeltoltottMunka = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblFeltoltottMunkak
            // 
            this.lblFeltoltottMunkak.AutoSize = true;
            this.lblFeltoltottMunkak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFeltoltottMunkak.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblFeltoltottMunkak.Location = new System.Drawing.Point(150, 38);
            this.lblFeltoltottMunkak.Name = "lblFeltoltottMunkak";
            this.lblFeltoltottMunkak.Size = new System.Drawing.Size(0, 20);
            this.lblFeltoltottMunkak.TabIndex = 0;
            // 
            // lblFeltoltottMunka
            // 
            this.lblFeltoltottMunka.AutoSize = true;
            this.lblFeltoltottMunka.BackColor = System.Drawing.Color.Teal;
            this.lblFeltoltottMunka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFeltoltottMunka.ForeColor = System.Drawing.Color.White;
            this.lblFeltoltottMunka.Location = new System.Drawing.Point(330, 38);
            this.lblFeltoltottMunka.Name = "lblFeltoltottMunka";
            this.lblFeltoltottMunka.Size = new System.Drawing.Size(25, 25);
            this.lblFeltoltottMunka.TabIndex = 1;
            this.lblFeltoltottMunka.Text = "0";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(68, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(412, 251);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Munkaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(537, 368);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblFeltoltottMunka);
            this.Controls.Add(this.lblFeltoltottMunkak);
            this.Name = "Munkaim";
            this.Text = "Munkaim";
            this.Load += new System.EventHandler(this.Munkaim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeltoltottMunkak;
        private System.Windows.Forms.Label lblFeltoltottMunka;
        private System.Windows.Forms.ListView listView1;
    }
}