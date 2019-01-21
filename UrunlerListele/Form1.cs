using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace UrunlerListele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
            }
            catch (System.ApplicationException ex)
            {
                Console.WriteLine("Error reading from {0}.Message= {1}", ex.Source, ex.Message);
            }

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Products";
            komut.Connection = baglanti;

            baglanti.Open();

            SqlDataReader rdr = komut.ExecuteReader();

            while (rdr.Read())
            {

                object ProductName = rdr["ProductName"];
                object Price = rdr["UnitPrice"];
                object Stok = rdr["UnitsInStock"];

                listKategori.Items.Add(ProductName + " - " + Price + "--" + Stok);
                
                //object ProductName = rdr[1];
                //object Price = rdr[5];
                //object Stok = rdr[6];


            }
            // rdr.Close();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategori ktgr = new kategori();
            ktgr.Show();

            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "SELECT * FROM Categories";
            baglanti.Open();
            komut2.Connection = baglanti;
            
            SqlDataReader rdr2 = komut2.ExecuteReader();

            while (rdr2.Read())
            {

                object CategoriName = rdr2["CategoryName"];
                object Description = rdr2["Description"];
                

               ktgr.listKategori1.Items.Add(CategoriName + " - " + Description );

                //object ProductName = rdr[1];
                //object Price = rdr[5];
                //object Stok = rdr[6];


            }
            baglanti.Close();
        }
    }
}
