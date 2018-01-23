using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logika_biznesowa;

namespace Aplikacja_wypożyczalnia
{
    public partial class WybierzSamoch : Form
    {
        public WybierzSamoch()
        {
            InitializeComponent();
        }
        
        private void WybierzSamochod_Load(object sender, EventArgs e)
        {
            string zapytanie = @"select [Id_samochodu],[Marka],[Model],[Cena_za_dobę],[Kaucja],[Pojemnosc],[Rodzaj_paliwa],[Rocznik],[Kolor],[Dostepnosc]" +
                @"from [dbo].[Samochód]";

            string exmsg = "";

            DataTable dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            if (!string.IsNullOrWhiteSpace(exmsg))
            {
                MessageBox.Show("Wystąpił błąd: " + exmsg);
            }
            else
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                string id = dr.ItemArray[0].ToString();
                MessageBox.Show("ID wybranego samochodu " + id);
                PobraneIDSam.Text = id;
                string cena = dr.ItemArray[4].ToString();
                Kwota.Text = cena;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano klienta");
            }
        }

        public string PobraneIDSamWartosc
        {
            get { return PobraneIDSam.Text; }
        }

    
        public string KwotaWart 
        {
            get { return Kwota.Text; }
        }


        
        //private void pobraneIDKlienta_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
    

