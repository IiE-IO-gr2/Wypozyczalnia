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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string l = textBox1.Text;
            string h = textBox2.Text;
            string zapytanie = "Select haslo from [dbo].[Panel_administratora] where Login='" + l + "'";
            string exmsg = "";
            DataTable dt = FunkcjeSQL.PobierzDaneSQL(zapytanie, ref exmsg);
            string hasloZBazy = "";
            foreach (DataRow item in dt.Rows)
            {
                hasloZBazy = item[0].ToString();
            }
            if (h == hasloZBazy)
            {
                MessageBox.Show("Zalogowano");
                this.Hide();
                Menu_po_zalogowaniu m = new Menu_po_zalogowaniu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Błędne dane.");
                if (!string.IsNullOrWhiteSpace(exmsg))
                {
                    MessageBox.Show(exmsg);
                }
            }
        }
    }
 }

