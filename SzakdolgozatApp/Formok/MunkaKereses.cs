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
    public partial class MunkaKereses : Form
    {
        SqlDataReader reader;       
        SqlConnection kapcsolat;  //Kapcsolat létrehozás
        string kapcsolatString;   //Adatbázis helye
        List<int> idk = new List<int>();
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

        public MunkaKereses()
        {
            InitializeComponent();
            Adatok();
        }

        private void MunkaKereses_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            AdatFrissites();
        }

        public void Adatok()
        {

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Cég Név", 100);
            listView1.Columns.Add("Munkakor", 100);
            listView1.Columns.Add("Kezdes", 100);
            listView1.Columns.Add("Helyiség", 100);
            listView1.Columns.Add("leiras", 100);
            listView1.Columns.Add("Fizetés", 100);

            try
            {

                Kapcsolodas();
                string belepesParancs = "SELECT Id, ceg_neve, munkakor, kezdes, helyiseg, fizetes, leiras FROM feltoltott_munkak";  //ha mind a ketto jó, akkor enged belépni  Őket vizsgáljuk előszőr, amikor SELECTET * használsz, mindent ami létezik kivesz
                SqlCommand parancs = new SqlCommand(belepesParancs, kapcsolat);
                reader = parancs.ExecuteReader();
                while (reader.Read())
                {
                    idk.Add(Convert.ToInt32(reader["Id"].ToString()));
                    ListViewItem elem = new ListViewItem(reader["ceg_neve"].ToString());
                    elem.SubItems.Add(reader["munkakor"].ToString());
                    elem.SubItems.Add(reader["kezdes"].ToString());
                    elem.SubItems.Add(reader["helyiseg"].ToString());
                    elem.SubItems.Add(reader["leiras"].ToString());
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
        public void AdatFrissites()
        {
            try
            {
                string id = Belepes.id;
                string cegnev = listView1.SelectedItems[0].SubItems[0].Text;
                string munkakor = listView1.SelectedItems[0].SubItems[1].Text;
                string helyiseg = listView1.SelectedItems[0].SubItems[3].Text;
                string leiras = listView1.SelectedItems[0].SubItems[4].Text;
                double fizetes = Convert.ToDouble(listView1.SelectedItems[0].SubItems[5].Text);

                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {

                    if (listView1.Items[i].Selected)
                    {

                        try
                        {
                            Kapcsolodas();
                            //SQL INSERT parancs, majd beágyazása
                            string insertParancs = "INSERT INTO elvallalt_munkak(ceg_neve,munkakor,helyiseg, leiras, fizetes,szemelyes_adatok_id) VALUES " +
                                "                                                                       (@cegnev,@munkakor,@helyiseg,@leiras,@fizetes,@id)";
                            SqlCommand parancs = new SqlCommand(insertParancs, kapcsolat);

                            //Adat átvitel, PRIVATE környezetben!
                            parancs.Parameters.AddWithValue("@cegnev", cegnev);
                            parancs.Parameters.AddWithValue("@munkakor", munkakor);
                            parancs.Parameters.AddWithValue("@helyiseg", helyiseg);
                            parancs.Parameters.AddWithValue("@leiras", leiras);
                            parancs.Parameters.AddWithValue("@fizetes", fizetes);
                            parancs.Parameters.AddWithValue("@id", id);

                            int sor = parancs.ExecuteNonQuery();

                            if (sor == 1)
                            {
                                MessageBox.Show("Munka elvállalva!");
                            }
                            else
                            {
                                MessageBox.Show("Nem sikerült munkát vállalni");
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

                        string query = "";
                        try
                        {
                            Kapcsolodas();

                            foreach (int elem in idk)
                            {
                                query = "DELETE FROM feltoltott_munkak WHERE Id = '" + elem.ToString() + "'";
                            }
                            SqlCommand parancs = new SqlCommand(query, kapcsolat);
                            int sor = parancs.ExecuteNonQuery();

                            listView1.SelectedItems[0].Remove();
                           

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Frissítse újra az oldalt!");
                        }
                        finally
                        {
                            KapcsolatLezaras();
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Válasszon egy munkát, ha található!");
            }
        }

    }
}

