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
    public partial class WyszukajSamochód : Form
    {
        public WyszukajSamochód()
        {
            InitializeComponent();
        }

        private void WsteczWS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody ws = new Samochody();
            ws.Show();
        }

        private void ZatwierdźWS_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                string exmsg = "";
                Samochód znaleziony = Samochód.WyszukajSamochod(ref exmsg);
                if (!string.IsNullOrWhiteSpace(exmsg))
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg);
                else
                {
                    
                    PokazSamochod pokazSamochod = new PokazSamochod();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd:\nNiepoprawny lub pusty numer identyfikacyjny");
            }
        }
    }
}
