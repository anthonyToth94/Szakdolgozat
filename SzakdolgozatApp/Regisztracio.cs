using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SzakdolgozatApp
{
    public partial class Regisztracio : Form
    {
        SqlConnection kapcsolat;  //Kapcsolat létrehozás
        string kapcsolatString;   //Adatbázis helye
        byte pozicio;
        public void Kapcsolodas()   //kapcsolódunk az adatbázisra
        {
            try
            {
                kapcsolatString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SzakdolgozatDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                kapcsolat = new SqlConnection(kapcsolatString);  //Adatbázis helye
                KapcsolatEllenorzes();//Van kapcsolat?
            }
            catch (Exception kivetel)
            {
                throw kivetel;        //bármi kivétel van írja ki
            }
        }
        public void KapcsolatEllenorzes() //Leellenőrízzük a kapcsolatot
        {
            if (kapcsolat.State != ConnectionState.Open) //Hogyha nincs nyitva a kapcsolat, akkor Open legyen (nyissa ki)
            {
                kapcsolat.Open();
            }
        }

        public void KapcsolatLezaras() //Leellenőrízzük a kapcsolatot
        {
            if (kapcsolat.State == ConnectionState.Open) //Hogyha van kapcsolat, akkor Close (zárja le)
            {
                kapcsolat.Close();
            }
        }
        public Regisztracio()
        {
            Kapcsolodas();
            InitializeComponent();
        }
        //Beviteli mező adott mezőre kattintás, eltünteti a feliratot majd visszarakja
        #region Beviteli mező
        private void txtVeznev_Enter(object sender, EventArgs e)
        {

            if (txtVeznev.Text == "*Vezeték név")
            {
                txtVeznev.Text = null;

                txtVeznev.ForeColor = Color.White;
            }
        }

        private void txtVeznev_Leave(object sender, EventArgs e)
        {
            if (txtVeznev.Text == "")
            {
                txtVeznev.Text = "*Vezeték név";

                txtVeznev.ForeColor = Color.DarkGray;
            }
        }
        private void txtKernev_Enter(object sender, EventArgs e)
        {
            if (txtKernev.Text == "*Kereszt név")
            {
                txtKernev.Text = null;

                txtKernev.ForeColor = Color.White;
            }
        }

        private void txtKernev_Leave(object sender, EventArgs e)
        {
            if (txtKernev.Text == "")
            {
                txtKernev.Text = "*Kereszt név";

                txtKernev.ForeColor = Color.DarkGray;
            }
        }
        private void txtEmailR_Enter(object sender, EventArgs e)
        {
            if (txtEmailR.Text == "*E-mail")
            {
                txtEmailR.Text = null;

                txtEmailR.ForeColor = Color.White;
            }
        }

        private void txtEmailR_Leave(object sender, EventArgs e)
        {
            if (txtEmailR.Text == "")
            {
                txtEmailR.Text = "*E-mail";

                txtEmailR.ForeColor = Color.DarkGray;
            }
        }

        private void txtJelszoR_Enter(object sender, EventArgs e)
        {
            if (txtJelszoR.Text == "*Jelszó")
            {
                txtJelszoR.Text = null;

                txtJelszoR.UseSystemPasswordChar = true;

                txtJelszoR.ForeColor = Color.White;
            }
        }

        private void txtJelszoR_Leave(object sender, EventArgs e)
        {
            if (txtJelszoR.Text == "")
            {
                txtJelszoR.Text = "*Jelszó";

                txtJelszoR.UseSystemPasswordChar = false;

                txtJelszoR.ForeColor = Color.DarkGray;
            }
        }

        private void txtJelszoR2_Enter(object sender, EventArgs e)
        {
            if (txtJelszoR2.Text == "*Jelszó ismétlés")
            {
                txtJelszoR2.Text = null;

                txtJelszoR2.UseSystemPasswordChar = true;

                txtJelszoR2.ForeColor = Color.White;
            }
        }

        private void txtJelszoR2_Leave(object sender, EventArgs e)
        {
            if (txtJelszoR2.Text == "")
            {
                txtJelszoR2.Text = "*Jelszó ismétlés";

                txtJelszoR2.UseSystemPasswordChar = false;

                txtJelszoR2.ForeColor = Color.DarkGray;
            }
        }
        #endregion

        //Már van felhasználód? Gomb átirányít a Regisztrációs Formra
        #region Átirányít a bejelentkező Formra
        private void lnkBejelentkezes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Belepes b = new Belepes();
            b.Show();
            this.Hide();
        }
        #endregion

        //Regisztrációs gomb megnyomása esetén adat felvétele, nem egyező jelszónál, nem tartalmazott @nál, nem pipált Feltételnél,nem kitöltött adatnál HIBA
        #region Regisztráció
        private void btnRegisztracio_Click(object sender, EventArgs e)
        {
            Regisztralas();
        }
        #endregion//Regisztrációs gomb megnyomása esetén adat felvétele, nem egyező jelszónál, nem tartalmazott @nál, nem pipált Feltételnél,nem kitöltött adatnál HIBA //Regisztrációs gomb megnyomása esetén adat felvétele, nem egyező jelszónál, nem tartalmazott @nál, nem pipált Feltételnél,nem kitöltött adatnál HIBA


        //[ X ] gombbal kilép az alkalmazásból, illetve szinét változtatja kurzor rávitele esetén
        #region [ X ]
        private void lblKilepRegisztracio_MouseEnter(object sender, EventArgs e)
        {
            lblKilepRegisztracio.ForeColor = Color.Black;
        }

        private void lblKilepRegisztracio_MouseLeave(object sender, EventArgs e)
        {
            lblKilepRegisztracio.ForeColor = Color.White;
        }

        private void lblKilepRegisztracio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        public void Regisztralas()
        {
            //Textbox mentése string-be.   Egyszerűbb kezelés,  Trim(), ha valaki véletlen szóközt írt volna.   
            string vezeteknev = txtVeznev.Text.Trim();
            string keresztnev = txtKernev.Text.Trim();
            string email = txtEmailR.Text.Trim();
            string jelszo = txtJelszoR.Text.Trim();
            string jelszo2 = txtJelszoR2.Text;
            //Vizsgálom a különböző problémákat, de majd csak, ha ELFOGADTA a felhasználási feltételeket Engedi Belépni!
            if (vezeteknev != "*Vezeték név" && keresztnev != "*Kereszt név" && email != "*E-mail" && jelszo != "*Jelszó" && jelszo2 != "*Jelszó ismétés")
            {


                lblSikeresReg.Text = null;
                if (jelszo == jelszo2)
                {
                    lblSikeresReg.Text = null;

                    if (email.Contains("@"))
                    {
                        lblSikeresReg.Text = null;

                        if ( radioAjanl.Checked || radioVallal.Checked)
                        {


                            if (radioAjanl.Checked)
                            {

                                pozicio = 0;

                            }
                            if (radioVallal.Checked)
                            {

                                pozicio = 1;
                            }
                            try
                            {
                                Kapcsolodas();
                                //SQL INSERT parancs, majd beágyazása
                                string insertParancs = "INSERT INTO szemelyes_adatok(vezetek_nev,kereszt_nev,email,jelszo,munkatvallal) VALUES (@vezeteknev,@keresztnev,@email,@jelszo,@pozicio)";
                                SqlCommand parancs = new SqlCommand(insertParancs, kapcsolat);

                                //Adat átvitel, PRIVATE környezetben!
                                parancs.Parameters.AddWithValue("@vezeteknev", vezeteknev);
                                parancs.Parameters.AddWithValue("@keresztnev", keresztnev);
                                parancs.Parameters.AddWithValue("@email", email);
                                parancs.Parameters.AddWithValue("@jelszo", jelszo);
                                parancs.Parameters.AddWithValue("@pozicio", pozicio);

                                int sor = parancs.ExecuteNonQuery();

                                if (sor == 1)
                                {
                                    lblHibasRegisztracio.Text = null;
                                    lblSikeresReg.Text = "Sikeres Regisztráció!";
                                }
                                else
                                {
                                    MessageBox.Show("Nem sikerült új fiókot létrehozni");
                                }
                            }
                            catch (Exception kivetel)
                            {
                                MessageBox.Show(kivetel.ToString());
                            }
                            finally
                            {
                                KapcsolatLezaras();
                            }
                        }
                        else
                        {
                            lblHibasRegisztracio.Text = "Válasszon az opciók közül";
                        }

                    }
                    else
                    {
                        lblHibasRegisztracio.Text = "Helytelen email cím";
                    }

                }
                else
                {
                    lblHibasRegisztracio.Text = "Nem egyezik a jelszó";
                }
            }
            else
            {
                lblHibasRegisztracio.Text = "Töltse ki a mezőket";
            }
        }
    }
}
