using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;


namespace WypTest1
{
    public partial class Form1 : Form
    {
        // stworzenie na razie pustej bazy samochodow
        Samochody bazaSamochodow = new Samochody();

        public Form1()
        {
            InitializeComponent();
        }

        // przycisk testowania połączenia z bazą
        private void Button1_Click(object sender, EventArgs e)
        {
            // kod ściągnięty z internetów
            try
            {
                String str = Funkcje.connString;
            //    String query = "select * from data";
                SqlConnection con = new SqlConnection(str);
            //    SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
            //    DataSet ds = new DataSet();
                MessageBox.Show("connected with sql server");
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        // Przycisk pobrania danych z bazy
        private void button2_Click(object sender, EventArgs e)
        {
            string exmsg = "";
            bazaSamochodow.PobierzSamochodyZBazy(ref exmsg);
            // wyrzucenia na textBox1 ew. błędow zapytania sql
            textBox1.Text = exmsg;
        }

        // wyświetlenie na richTextBox1 stringa z całą bazą
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = bazaSamochodow.WyswietlListeSamochodow();
        }
    }
}
