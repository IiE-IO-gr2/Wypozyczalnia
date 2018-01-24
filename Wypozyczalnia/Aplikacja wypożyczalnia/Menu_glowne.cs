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
    public partial class Menu_glowne : Form
    {
        public Menu_glowne()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk, który przekierowuje do formularza zalogowania się do systemu
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_administratora pa = new Panel_administratora();
            pa.Show();
        }

        /// <summary>
        /// Przycisk kończący działanie aplikacji
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_po_zalogowaniu mpz = new Menu_po_zalogowaniu();
            mpz.Show();
        }
    }
}
