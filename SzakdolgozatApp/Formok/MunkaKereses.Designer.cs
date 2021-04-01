namespace SzakdolgozatApp
{
    partial class MunkaKereses
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
            this.btnKeres = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnKeres
            // 
            this.btnKeres.BackColor = System.Drawing.Color.Teal;
            this.btnKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKeres.ForeColor = System.Drawing.Color.White;
            this.btnKeres.Location = new System.Drawing.Point(197, 34);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(144, 31);
            this.btnKeres.TabIndex = 3;
            this.btnKeres.Text = "Kiválaszt";
            this.btnKeres.UseVisualStyleBackColor = false;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 285);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MunkaKereses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(537, 368);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnKeres);
            this.Name = "MunkaKereses";
            this.Text = "MunkaKereses";
            this.Load += new System.EventHandler(this.MunkaKereses_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.ListView listView1;
    }
}