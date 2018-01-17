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
    public partial class WybierzKlienta : Form
    {
        int id = 0;
        string nazwa;
        string nip = "31312";
        string tl = "733014523";

       
        
        public WybierzKlienta()
        {
           
            InitializeComponent();
            System.Data.DataTable exmsg_kl = FunkcjeSQL.PobierzDaneSQL("use wypozyczalnia" +
                "select Nazwa_firmy from dbo.Klient_firmy", ref nazwa);
            //Klient_firmy klientwyswietl = new Klient_firmy(nazwa, nip);
            dataGridView1.Rows.Add(id,nazwa,nip,tl);
        }
        
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
