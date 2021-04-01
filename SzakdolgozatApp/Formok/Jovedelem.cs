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
using System.Windows.Forms.DataVisualization.Charting;

namespace SzakdolgozatApp
{
    public partial class Jovedelem : Form
    {
        double kiadas1;
        double bevetel1;
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
        public Jovedelem()
        {
            InitializeComponent();
            Levizsgal();
            //Osszesen();
            Grafikon();
        }

        public void FeltoltottPenz()
        {
          
            try
                {
                    Kapcsolodas();
                    string query = "SELECT SUM (fizetes) FROM feltoltott_munkak WHERE szemelyes_adatok_id =" + Belepes.id;
                    SqlCommand parancs = new SqlCommand(query, kapcsolat);

                    //olvasás az adatbázisból
                    int eredmeny = Convert.ToInt32(parancs.ExecuteScalar());
                    parancs.Dispose();

                    if(eredmeny >= 0)
                    {
                        //Mutassa / írja ki az adatot számunkra
                        lblKiad.Text = eredmeny.ToString() + "Ft";
                        kiadas1 = eredmeny;
                    }
                    else
                    {
                        lblKiad.Text = "0Ft";
                    }

                }
                catch (Exception)
                {
                    lblKiad.Text = "0Ft";    //bármi kivétel van írja ki
                }

        }
        public void ElvallaltPenz()
        {
            try
            {
                Kapcsolodas();
                string query2 = "SELECT SUM (fizetes) FROM elvallalt_munkak WHERE szemelyes_adatok_id =" + Belepes.id;
                SqlCommand parancs2 = new SqlCommand(query2, kapcsolat);

                //olvasás az adatbázisból
                Int32 eredmeny2 = Convert.ToInt32(parancs2.ExecuteScalar());
                parancs2.Dispose();

                if (eredmeny2 >= 0)
                {
                    //Mutassa / írja ki az adatot számunkra
                    lblKiad.Text = eredmeny2.ToString() + "Ft";
                    bevetel1 = eredmeny2;
                }
                else
                {
                    lblKiad.Text = "0Ft";
                }

            }
            catch (Exception)
            {
                lblKiad.Text = "0Ft";    //bármi kivétel van írja ki
            }
        }
        public void Grafikon()
        {
            chart1.Titles.Add("Pénz menedzsment");

           if(Convert.ToInt32(Belepes.munkatvallal) == 1)
           {
              chart1.Series["Összeg"].Points.AddXY("Bevetel", bevetel1);
           }
           else if (Convert.ToInt32(Belepes.munkatvallal) == 0)
           {
              chart1.Series["Összeg"].Points.AddXY("Kiadas", kiadas1);
           }

        } 
        public void Levizsgal()
        {
            if(Convert.ToInt32(Belepes.munkatvallal) == 0)
            {
                FeltoltottPenz();
                label4.Location = new Point(150, 92);
                label4.Text = "Aktuális kiadás:";
                lblKiad.ForeColor = Color.Red;
            }else if(Convert.ToInt32(Belepes.munkatvallal) == 1)
            {
                ElvallaltPenz();
                label4.Text = "Jövedelem:";
                lblKiad.ForeColor = Color.Green;
            }
        }
    }
}
