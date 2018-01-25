using logika_biznesowa;
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
    public partial class Panel_administratora : Form
    {
        public Panel_administratora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk, po którym wychodzimy z panelu logowania się
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        /// <summary>
        /// Przycisk, który umożliwia zalogowanie do systemu
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string l = textBox1.Text;
            string h = textBox2.Text;
            string exmsg = "";
            bool zalogowany = PanelAdministratora.ZalogujSie(l, h, ref exmsg);
            if (zalogowany == true)
            {
                this.Hide();
                Menu_po_zalogowaniu m = new Menu_po_zalogowaniu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Błędne dane.");
                if (!string.IsNullOrEmpty(exmsg))
                {
                    MessageBox.Show(exmsg);
                }
            }
        }
    }
}
