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
    public partial class UsuńKlienta : Form
    {
        public UsuńKlienta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci k = new Klienci();
            k.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string exmsg = Klient.UsunKlienta(id);
            if (!string.IsNullOrWhiteSpace(exmsg))
                MessageBox.Show("Wystąpił błąd:\n" + exmsg);
            else
            {
                MessageBox.Show("Usunięto klienta z bazy");
                this.Hide();
                UsuńKlienta uk = new UsuńKlienta();
                uk.Show();
            }
        }
    }
}
