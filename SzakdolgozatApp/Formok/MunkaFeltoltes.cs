using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzakdolgozatApp
{
    public partial class MunkaFeltoltes : Form
    {
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
        public MunkaFeltoltes()
        {
            InitializeComponent();
        }



        private void btnFeltoltes_Click(object sender, EventArgs e)
        {
            MunkaFeltoltese();
        }
        public void MunkaFeltoltese()
        {
            string id = Belepes.id;
            string fizetes = txtBoxFizetes.Text;
            string leiras = txtLeiras.Text;
            string helyszin = cBoxHelyszin.Text;
            string munkakor = cBoxMunkakor1.Text;
            string cegneve = txtCegNev.Text;
            var datum = maskedTextBox1.Text; /*dateTimePicker1.Text;*/

            //Vizsgálom a különböző problémákat, de majd csak, ha ELFOGADTA a felhasználási feltételeket Engedi Belépni!
            if (cegneve != "" & leiras != "" && helyszin != "" && munkakor != "" && datum != "" && fizetes != "")
            {
                lblHiba.Text = null;

                double fizetes2;
                bool vizsgalszam = double.TryParse(fizetes, out fizetes2);
                if (vizsgalszam)
                {
                    fizetes2.ToString();
                    try
                    {
                        Kapcsolodas();
                        //SQL INSERT parancs, majd beágyazása
                        string insertParancs = "INSERT INTO feltoltott_munkak(ceg_neve,munkakor,kezdes,helyiseg,leiras,fizetes,szemelyes_adatok_id) VALUES (@cegneve,@munkakor,@datum,@helyszin,@leiras,@fizetes2,@id)";
                        SqlCommand parancs = new SqlCommand(insertParancs, kapcsolat);

                        //Adat átvitel, PRIVATE környezetben!
                        parancs.Parameters.AddWithValue("@cegneve", cegneve);
                        parancs.Parameters.AddWithValue("@munkakor", munkakor);
                        parancs.Parameters.AddWithValue("@datum", datum);
                        parancs.Parameters.AddWithValue("@helyszin", helyszin);
                        parancs.Parameters.AddWithValue("@leiras", leiras);
                        parancs.Parameters.AddWithValue("@fizetes2", fizetes2);
                        parancs.Parameters.AddWithValue("@id", id);


                        int sor = parancs.ExecuteNonQuery();

                        if (sor == 1)
                        {
                            lblHiba.Text = null;
                            lblHiba.Text = "Sikeres feltöltés!";
                        }
                        else
                        {
                            MessageBox.Show("Nem sikerült a feltöltés");
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
                    lblHiba.Text = "Számként adja meg az összeget";
                }
            }
            else
            {
                lblHiba.Text = "Kérem töltse ki a mezőket";
            }
        }
    }  
} 
