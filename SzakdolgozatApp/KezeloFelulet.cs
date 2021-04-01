using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace SzakdolgozatApp
{
    public partial class KezeloFelulet : Form
    {

    //Aktiv form 
    private Form aktivForm;

        public KezeloFelulet()
        {
            InitializeComponent();
        }
        //Gombok színei, kurzor rávitelre, kiírása
        #region Gombok személyreszabása
        private void btnProfilom_MouseEnter(object sender, EventArgs e)
        {
                this.btnProfilom.BackColor = Color.Teal;
                btnProfilom.Text = "     Profilom";
        }

        private void btnProfilom_MouseLeave(object sender, EventArgs e)
        {
                this.btnProfilom.BackColor = Color.FromArgb(52, 52, 52);
                btnProfilom.Text = "   Profilom";
        }

        private void btnAdatokMegadasa_MouseEnter(object sender, EventArgs e)
        {
                this.btnAdatokMegadasa.BackColor = Color.Teal;
                btnAdatokMegadasa.Text = "     Adatok megadása";
        }

        private void btnAdatokMegadasa_MouseLeave(object sender, EventArgs e)
        {
                this.btnAdatokMegadasa.BackColor = Color.FromArgb(52, 52, 52);
                btnAdatokMegadasa.Text = "   Adatok megadása";
        }

        private void btnMunkaim_MouseEnter(object sender, EventArgs e)
        {
                this.btnMunkaim.BackColor = Color.Teal;
                btnMunkaim.Text = "     Munkáim";
        }

        private void btnMunkaim_MouseLeave(object sender, EventArgs e)
        {
                this.btnMunkaim.BackColor = Color.FromArgb(52, 52, 52);
                btnMunkaim.Text = "   Munkáim";
        }

        private void btnJovedelem_MouseEnter(object sender, EventArgs e)
        {
                this.btnJovedelem.BackColor = Color.Teal;
                btnJovedelem.Text = "     Jövedelem";
        }

        private void btnJovedelem_MouseLeave(object sender, EventArgs e)
        {
                this.btnJovedelem.BackColor = Color.FromArgb(52, 52, 52);
                btnJovedelem.Text = "   Jövedelem";
        }

        private void btnMunkaFeltoltes_MouseEnter(object sender, EventArgs e)
        {
                this.btnMunkaFeltoltes.BackColor = Color.Teal;
                btnMunkaFeltoltes.Text = "     Munka feltöltés";                 
        }

        private void btnMunkaFeltoltes_MouseLeave(object sender, EventArgs e)
        {
                this.btnMunkaFeltoltes.BackColor = Color.FromArgb(52, 52, 52);
                btnMunkaFeltoltes.Text = "   Munka feltöltés";
        }

        private void btnMunkaKereses_MouseEnter(object sender, EventArgs e)
        {
                this.btnMunkaKereses.BackColor = Color.Teal;
                btnMunkaKereses.Text = "     Munka keresés";
        }

        private void btnMunkaKereses_MouseLeave(object sender, EventArgs e)
        {
                this.btnMunkaKereses.BackColor = Color.FromArgb(52, 52, 52);
                btnMunkaKereses.Text = "   Munka keresés";
        }

        private void btnBeallitasok_MouseEnter(object sender, EventArgs e)
        {
                this.btnBeallitasok.BackColor = Color.IndianRed;
                btnBeallitasok.Text = "     Kilépés";
        }

        private void btnBeallitasok_MouseLeave(object sender, EventArgs e)
        {
                this.btnBeallitasok.BackColor = Color.FromArgb(52, 52, 52);
                btnBeallitasok.Text = "   Kilépés";
        }
        #endregion
        //Létrehoztam egy Ablak metódust, ami ha az aktiv form nem null értékű, akkor bezárja és a Gyerekformot nyitja meg ami a paneHatter és ezzel kapcsoltam össze
        #region GyerekForm
        private void Ablak(Form childForm, object btnSender)
        {
            if (aktivForm != null)
            {
                aktivForm.Close();
            }
            aktivForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.paneHatter.Controls.Add(childForm);
            this.paneHatter.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        #endregion
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (aktivForm != null)
                aktivForm.Close();
            labelCim.Text = "    Kezdőlap"; 
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Ablak(new AdatokMegadasa(), sender);
            labelCim.Text = "Adatok megadása";
        }
        private void KezeloFelulet_Load(object sender, EventArgs e)
        {

        }
        //Ha rányomok valamelyik gombra, betölti az Ablak metódusom és átadom neki az aktuális Form nevét, majd írok neki Címet
        #region Gombokra nyomás
        private void btnProfilom_Click(object sender, EventArgs e)
        {
            Ablak(new Profilom(),sender);
            labelCim.Text = "    Profilom";
        }

        private void btnAdatokMegadasa_Click(object sender, EventArgs e)
        {
            Ablak(new AdatokMegadasa(), sender);
            labelCim.Text = "Adatok megadása";
        }
        private void btnMunkaim_Click(object sender, EventArgs e)
        {
            Ablak(new Munkaim(), sender);
            labelCim.Text = "    Munkáim";

        }
        private void btnJovedelem_Click(object sender, EventArgs e)
        {
            Ablak(new Jovedelem(), sender);
            labelCim.Text = "    Jövedelem";
        }
        private void btnMunkaFeltoltes_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Belepes.munkatvallal) == 0)
            {
                Ablak(new MunkaFeltoltes(), sender);
                labelCim.Text = "Munka feltöltés";
            }
            else
            {
                MessageBox.Show("Munka feltöltés csak azoknak elérhető, akik nem munkát vállalnak");
            }

        }
        private void btnMunkaKereses_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Belepes.munkatvallal) == 1)
            {
                Ablak(new MunkaKereses(), sender);
                labelCim.Text = "Munka kereses";
            }
            else
            {
                MessageBox.Show("Munka keresése csak azoknak elérhető, akik munkát vállalnak");
            }
            
        }
        private void btnBeallitasok_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        //[ X ] gombbal kilép az alkalmazásból, illetve szinét változtatja kurzor rávitele esetén
        private void lblKilepKezelofelulet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblKilepKezelofelulet_MouseEnter(object sender, EventArgs e)
        {
            lblKilepKezelofelulet.ForeColor = Color.Black;
        }

        private void lblKilepKezelofelulet_MouseLeave(object sender, EventArgs e)
        {
            lblKilepKezelofelulet.ForeColor = Color.White;
        }

        private void lblKicsinyit_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblKicsinyit_MouseEnter(object sender, EventArgs e)
        {
            lblKicsinyit.ForeColor = Color.Black;
        }

        private void lblKicsinyit_MouseLeave(object sender, EventArgs e)
        {
            lblKicsinyit.ForeColor = Color.White;
        }

    }
}