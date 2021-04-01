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
using System.Data;

namespace SzakdolgozatApp
{
    public partial class Belepes : Form
    {   //le kell menteni az adatokat, hogy tudjuk használni később a kezelőfelületen, módosítani lehessen
        public static string id, vezeteknev, keresztnev, email, jelszo, telefonszam, neme, lakhely, munkaterulet, munkatvallal; 
        
        DataTable adattabla = new DataTable(); //Adat tábla, hogy tudjuk menteni a dolgokat

        SqlConnection kapcsolat;  //Kapcsolat létrehozás
        string kapcsolatString;   //Adatbázis helye
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
                MessageBox.Show(kivetel.Message);        //bármi kivétel van írja ki
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
        public Belepes()
        {
          
            InitializeComponent();
        }

        //Email és Jelszo beviteli mezőn kattintásra eltünik az írás
        #region Email és Jelszo
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text == "E-mail")
            {
                txtEmail.Text = null;

                txtEmail.ForeColor = Color.White;
            }
        }

 

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "E-mail";

                txtEmail.ForeColor = Color.DarkGray;

            }
        }
        private void txtJelszo_Enter(object sender, EventArgs e)
        {
            if (txtJelszo.Text == "Jelszó")
            {
                txtJelszo.Text = null;

                txtJelszo.UseSystemPasswordChar = true;

                txtJelszo.ForeColor = Color.White;
            }
        }
  
        private void txtJelszo_Leave(object sender, EventArgs e)
        {
            if (txtJelszo.Text == "")
            {
                txtJelszo.Text = "Jelszó";

                txtJelszo.ForeColor = Color.DarkGray;

               txtJelszo.UseSystemPasswordChar = false;

            }
        }
        #endregion
        //Nincs még Felhasználód? Gomb átirányít a Regisztrációs Formra
        #region Átirányít a Regisztrációs form-ra 
        private void lnkRegisztracio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Regisztracio r = new Regisztracio();
            r.Show();
            this.Hide();
        }
        #endregion
        //Belépés a Kezelő felületre, Sql kapcsolat, Select parancs és vizsgálat, nem egyező email cím vagy jelszó esetén HIBÁT jelez
        #region Belepes, SQL kapcsolat 
        private void btnBelepes_Click(object sender, EventArgs e)
        {
            Belepeshez();
        }
        #endregion
        //X label megnyomásával kilép az alkalmazás, ha a kurzort ráviszed a színét megváltoztatja
        #region[ X ]
        private void lblKilepes_MouseEnter(object sender, EventArgs e)
        {
            lblKilepes.ForeColor = Color.Black;
        }

        private void lblKilepes_MouseLeave(object sender, EventArgs e)
        {
            lblKilepes.ForeColor = Color.White;
        }

        private void lblKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        public void Belepeshez()
        {
            string emailB = txtEmail.Text;
            string jelszoB = txtJelszo.Text;

            if (emailB.Equals("") || emailB == "E-mail")
            {
                lblHibasBelepes.Text = "Írja be az Email címét!";
            }
            else if (jelszoB.Equals("") || jelszoB == "Jelszó")
            {
                lblHibasBelepes.Text = "Írja be a jelszavát!";
            }
            else
            {
                try
                {
                    Kapcsolodas();
                    string belepesParancs = "SELECT * FROM szemelyes_adatok WHERE email ='" + emailB + "' and Jelszo = '" + jelszoB + "'";  //ha mind a ketto jó, akkor enged belépni  Őket vizsgáljuk előszőe, amikor SELECTET * használsz, mindent ami létezik kivesz
                    SqlCommand parancs = new SqlCommand(belepesParancs, kapcsolat);
                    SqlDataAdapter adapter = new SqlDataAdapter(parancs);
                    int sor = adapter.Fill(adattabla);
                    //első a parancs a második az adattabla(tarolja az adatokat )   elolvassa az adatokat az adatbázisban sor / sor-ra 
                    if (sor == 1)  //adattablanak van 1 sora, akkor behelyezte az adattablaba RAM-ban tárolja az adatot
                    {
                        id = adattabla.Rows[0]["Id"].ToString(); //lementjük, mert megkapjuk az adatokat az adattáblából   0.index Id
                        vezeteknev = adattabla.Rows[0]["vezetek_nev"].ToString();
                        keresztnev = adattabla.Rows[0]["kereszt_nev"].ToString();
                        email = adattabla.Rows[0]["email"].ToString();
                        jelszo = adattabla.Rows[0]["jelszo"].ToString();
                        telefonszam = adattabla.Rows[0]["telefonszam"].ToString();
                        lakhely = adattabla.Rows[0]["lakhely"].ToString();
                        munkaterulet = adattabla.Rows[0]["munkaterulet"].ToString();
                        neme = adattabla.Rows[0]["neme"].ToString();
                        munkatvallal = adattabla.Rows[0]["munkatvallal"].ToString();
                        this.Hide();
                        KezeloFelulet k = new KezeloFelulet();
                        k.Show();
                    }
                    else
                    {
                        lblHibasBelepes.Text = "Hibás Email cím vagy jelszó!";
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
        }
    }
}
