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
            string zapytanie = @"select [Id_samochodu],[Marka],[Model],[Cena_za_dobę],[Kaucja],[Pojemnosc],[Rodzaj_paliwa],[Rocznik],[Kolor]" +
                @"from [dbo].[Samochód] WHERE (([CzyUsuniete] = 0 or [CzyUsuniete] is null) and Dostepnosc = 1 and [Id_samochodu] not in (" + IdSamochodowKtorychNieMoznaWypozyczyc() + "))";
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

        private string IdSamochodowKtorychNieMoznaWypozyczyc()
        {
            string zapytanie = @"select [Id_samochodu] from [dbo].[Wypożyczenie] where (CzyRozliczone=0 or CzyRozliczone is null)";
            string exmsg = "";
            DataTable dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            if (!string.IsNullOrEmpty(exmsg))
            {
                return "Wystąpił błąd podczas sprawdzania niedostępnych samochodów\n\t-" + exmsg;
            }
            else
            {
                string listaID = "";
                foreach (DataRow item in dt.Rows)
                    listaID += "," + item[0].ToString();
                string listaIDCzysta = listaID.Substring(2);
                return listaIDCzysta;
            }
        }
        /// <summary>
        ///Przycisk umożliwiający zatwierdzenie wybranego samochodu
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                string id = dr.ItemArray[0].ToString();
                PobraneIDSam.Text = id;
                string cena = dr.ItemArray[3].ToString();
                Kwota.Text = cena;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano samochodu");
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
    }
}
    

