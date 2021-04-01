using System;
using System.Collections;
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
    public partial class Munkaim : Form
    {
        SqlDataReader reader;
        DataTable tabla = new DataTable();
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
        public Munkaim()
        {
            InitializeComponent();
            LabelNeve();
        }

        private void Munkaim_Load(object sender, EventArgs e)
        { 
            try
            {
                Kapcsolodas();
                if(Convert.ToInt32(Belepes.munkatvallal) == 1)
                {
                    ElvallaltMunkakCount();
                    ElvallaltMunkak();
                }
                else if(Convert.ToInt32(Belepes.munkatvallal) == 0)
                {
                    FeltoltottMunkakCount();
                    FeltoltottMunkak();
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
        public void FeltoltottMunkakCount()
        {
            string query = "SELECT COUNT(*) FROM feltoltott_munkak WHERE szemelyes_adatok_id =" + Belepes.id;
            SqlCommand parancs = new SqlCommand(query, kapcsolat);

            //olvasás az adatbázisból
            Int32 rows_count = Convert.ToInt32(parancs.ExecuteScalar());
            parancs.Dispose();
            //Mutassa / írja ki az adatot számunkra
            lblFeltoltottMunka.Text = rows_count.ToString();
        }
        public void ElvallaltMunkakCount()
        {
            string query3 = "SELECT COUNT(*) FROM elvallalt_munkak WHERE szemelyes_adatok_id =" + Belepes.id;
            SqlCommand parancs3 = new SqlCommand(query3, kapcsolat);

            //olvasás az adatbázisból
            Int32 rows_count2 = Convert.ToInt32(parancs3.ExecuteScalar());
            parancs3.Dispose();
            //Mutassa / írja ki az adatot számunkra
            lblFeltoltottMunka.Text = rows_count2.ToString();
        }
        public void FeltoltottMunkak()
        {    
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Cég Név", 100);
            listView1.Columns.Add("Munkakor", 100);
            listView1.Columns.Add("Kezdes", 100);
            listView1.Columns.Add("Helyiség", 100);
            listView1.Columns.Add("Fizetés", 100);

            try
            {
                Kapcsolodas();
                string belepesParancs = "SELECT ceg_neve, munkakor, kezdes, helyiseg, fizetes FROM feltoltott_munkak WHERE szemelyes_adatok_id =" + Belepes.id;  //ha mind a ketto jó, akkor enged belépni  Őket vizsgáljuk előszőe, amikor SELECTET * használsz, mindent ami létezik kivesz
                SqlCommand parancs = new SqlCommand(belepesParancs, kapcsolat);
                reader = parancs.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem elem = new ListViewItem(reader["ceg_neve"].ToString());
                    elem.SubItems.Add(reader["munkakor"].ToString());
                    elem.SubItems.Add(reader["kezdes"].ToString());
                    elem.SubItems.Add(reader["helyiseg"].ToString());
                    elem.SubItems.Add(reader["fizetes"].ToString());
                    listView1.Items.Add(elem);
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
        public void ElvallaltMunkak()
        {

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Cég Név", 100);
            listView1.Columns.Add("Munkakor", 100);
            listView1.Columns.Add("Helyiség", 100);
            listView1.Columns.Add("Leiras", 100);
            listView1.Columns.Add("Fizetés", 100);

            try
            {

                Kapcsolodas();
                string belepesParancs = "SELECT ceg_neve, munkakor, helyiseg, leiras, fizetes FROM elvallalt_munkak WHERE szemelyes_adatok_id =" + Belepes.id;  //ha mind a ketto jó, akkor enged belépni  Őket vizsgáljuk előszőe, amikor SELECTET * használsz, mindent ami létezik kivesz
                SqlCommand parancs3 = new SqlCommand(belepesParancs, kapcsolat);
                reader = parancs3.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem elem2 = new ListViewItem(reader["ceg_neve"].ToString());
                    elem2.SubItems.Add(reader["munkakor"].ToString());
                    elem2.SubItems.Add(reader["helyiseg"].ToString());
                    elem2.SubItems.Add(reader["leiras"].ToString());
                    elem2.SubItems.Add(reader["fizetes"].ToString());
                    listView1.Items.Add(elem2);
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
        public void LabelNeve()
        {
            if (Convert.ToInt32(Belepes.munkatvallal) == 1)
            {
                lblFeltoltottMunkak.Text = "Elvállalt munkáim:";
            }else if(Convert.ToInt32(Belepes.munkatvallal) == 0)
            {
                lblFeltoltottMunkak.Text = "Jelenleg feltöltött munkáim:";
            }


        }
    }
 
}
