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
    public partial class Profilom : Form
    {
        DataTable adattabla = new DataTable();
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
        public Profilom()
        {
            InitializeComponent();   
        }

        private void Profilom_Load(object sender, EventArgs e)
        {
            ProfileBetoltese();
        }
        public void ProfileBetoltese()
        {
            lblTeljesNev.Text = Belepes.vezeteknev + " " + Belepes.keresztnev;
            lblEmailCim.Text = Belepes.email;
            //lblTelefon.Text = Belepes.telefonszam;
            //lblNeme.Text = Belepes.neme;
            //lblMunkaterulet.Text = Belepes.munkaterulet;
            //lblLakhely.Text = Belepes.lakhely;
            try
            {
                Kapcsolodas();
                string belepesParancs = "SELECT telefonszam, lakhely, munkaterulet, neme FROM szemelyes_adatok WHERE email ='" + Belepes.email + "' and Jelszo = '" + Belepes.jelszo + "'";  //ha mind a ketto jó, akkor enged belépni  Őket vizsgáljuk előszőe, amikor SELECTET * használsz, mindent ami létezik kivesz
                SqlCommand parancs = new SqlCommand(belepesParancs, kapcsolat);
                SqlDataAdapter adapter = new SqlDataAdapter(parancs);
                adapter.Fill(adattabla);
                //első a parancs a második az adattabla(tarolja az adatokat )   elolvassa az adatokat az adatbázisban sor / sor-ra 
                if (adattabla.Rows.Count == 1)  //adattablanak van 1 sora, akkor behelyezte az adattablaba RAM-ban tárolja az adatot
                {
                    lblTelefon.Text = adattabla.Rows[0]["telefonszam"].ToString(); //lementjük, mert megkapjuk az adatokat az adattáblából   0.index Id
                    lblLakhely.Text = adattabla.Rows[0]["lakhely"].ToString();
                    lblMunkaterulet.Text = adattabla.Rows[0]["munkaterulet"].ToString();
                    lblNeme.Text = adattabla.Rows[0]["neme"].ToString();

                    if (lblNeme.Text == "0")
                    {
                        lblNeme.Text = "Nő";
                    }
                    else if (lblNeme.Text == "1")
                    {
                        lblNeme.Text = "Férfi";
                    }

                }
                else
                {

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
