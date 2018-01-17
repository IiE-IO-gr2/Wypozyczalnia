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
    public partial class UsuńSamochód : Form
    {
        public UsuńSamochód()
        {
            InitializeComponent();
        }

        private void WsteczUS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody us = new Samochody();
            us.Show();
        }

        private void ZatwierdźUS_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                string exmsg = Samochód.UsunSamochod(id);
                if (!string.IsNullOrWhiteSpace(exmsg))
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg);
                else
                {
                    MessageBox.Show("Usunięto samochód z bazy");
                    textBox1.Clear();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd:\nNiepoprawny lub pusty numer identyfikacyjny");
            }
        }
    }
}
