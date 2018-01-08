using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_wypożyczalnia
{
    public partial class Samochody : Form
    {
        public Samochody()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajSamochód ds = new DodajSamochód();
            ds.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DodajSamochód_Click(object sender, EventArgs e)
        {
            DodajSamochód ds = new DodajSamochód();
            ds.Show();
        }

        private void EdytujSamochód_Click(object sender, EventArgs e)
        {
            EdytujSamochód es = new EdytujSamochód();
            es.Show();
        }

        private void UsuńSamochód_Click(object sender, EventArgs e)
        {
            UsuńSamochód us = new UsuńSamochód();
            us.Show();
        }

        private void WyszukajSamochód_Click(object sender, EventArgs e)
        {
            WyszukajSamochód ws = new WyszukajSamochód();
            ws.Show();
        }

        private void MenuGłówne_Click(object sender, EventArgs e)
        {
            Menu_po_zalogowaniu mn = new Menu_po_zalogowaniu();
            mn.Show();
        }
    }
}
