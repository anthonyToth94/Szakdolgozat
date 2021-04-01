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
using System.Text.RegularExpressions;   //Ha nem hívom be nem fog lefutni a Reguláris kifejezés

namespace SzakdolgozatApp
{
    public partial class AdatokMegadasa : Form
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
        public AdatokMegadasa()
        {
            InitializeComponent();  
        }

           private void AdatokMegadasa_Load(object sender, EventArgs e) //mit akarsz, hogy betöltsön
             {
                 txtTelefonszam.Text = Belepes.telefonszam;
                 cBoxLakhely.Text = Belepes.lakhely;
                 cBoxMunkakor.Text = Belepes.munkaterulet;
                 labelNeme.Text = Belepes.neme;
             }

        private void btnFrissites_Click(object sender, EventArgs e)
        {

            string ujTelefonszam = txtTelefonszam.Text;
            string ujLakhely = cBoxLakhely.Text;
            string ujMunkaterulet = cBoxMunkakor.Text;
            int ujNeme = 0;
            int szamolo = 0;


            if (Regex.Match(ujTelefonszam, "^[0-9]{11}$").Success) //Vizsgálom, hogy a telefonszám 0-9 között lévő számokat tartalmaz és összesen 11 karaktert.Success, hogy csak ezzel mehet tovább
            {
                lblsikeresFrissites.Text = "";
                if (radioFerfi.Checked)
                {

                    ujNeme = 1;
                    szamolo++;

                }
                if (radioNo.Checked)
                {

                    ujNeme = 0;
                    szamolo++;
                }

                if (szamolo >= 1)
                {
                    try
                    {
                        Kapcsolodas();
                        string frissitesQuery = "UPDATE szemelyes_adatok SET Telefonszam = '" + @ujTelefonszam + "', lakhely = '" + @ujLakhely + "', munkaterulet = '" + @ujMunkaterulet + "', neme = '" + @ujNeme + "' WHERE Id = '" + Belepes.id + "'";

                        SqlCommand modositasParancs = new SqlCommand(frissitesQuery, kapcsolat);

                        modositasParancs.Parameters.AddWithValue("@ujTelefonszam", @ujTelefonszam);//ezek privátok senkisem látja őket
                        modositasParancs.Parameters.AddWithValue("@ujLakhely", @ujLakhely);      //DropDownStyle: DropDownList megadásával tettem lehetővé, hogy csak ezek legyenek elérhetőek
                        modositasParancs.Parameters.AddWithValue("@ujMunkakor", @ujMunkaterulet);  //DropDownStyle: DropDownList megadásával tettem lehetővé, hogy csak ezek legyenek elérhetőek
                        modositasParancs.Parameters.AddWithValue("@ujNeme", @ujNeme);

                        int row = modositasParancs.ExecuteNonQuery();  //ha 1 akkor van sor sikerült, ha 0 nincs sor nem sikerült

                        if (row == 1)
                        {
                            lblsikeresFrissites.Text = "";
                            lblsikeresFrissites.Text = "  Sikeres frissítés!";
                        }
                        else
                        {
                            lblsikeresFrissites.Text = "";
                            lblsikeresFrissites.Text = "Nem sikerült a frissítés!";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    lblsikeresFrissites.Text = "";
                    lblsikeresFrissites.Text = "Kérem töltse ki az adatokat!";
                }


            }
            else
            {
                lblsikeresFrissites.Text = "";
                lblsikeresFrissites.Text = "Helytelen a telefonszám!";
            }

        }
      
    }
}
