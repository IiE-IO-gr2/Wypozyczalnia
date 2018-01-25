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
    public partial class SamochodNaprawa : Form
    {
        public SamochodNaprawa()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przycisk, który cofa do poprzedniej sekcji czyli Samochody
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WsteczES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody es = new Samochody();
            es.Show();
        }
        /// <summary>
        /// Przycisk wyszukuje samochodu do edycji oraz pojawia się okno, w którym można edytować wszystkie, bądź wybrane parametry samochodu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
            // Sprawdzenie poprawności danych w textboxie
            
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[0-9]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ID";
                poprawneTextboxy = false;
            }
            if (poprawneTextboxy == true)
            {
                /// <summary>
                /// Pobranie danych z TextBoxa
                /// </summary>
                int id = int.Parse(textBox1.Text);
                string inne = textBox2.Text;
                if (string.IsNullOrEmpty(inne))
                    inne = "brak";
                string exmsg = "";
                string zapytanie = "update [dbo].[Samochód] set [Dostepnosc] = 0, [Inne] = '" + inne + "' where [Id_samochodu] = " + id;
                FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
                if (!string.IsNullOrEmpty(exmsg))
                    MessageBox.Show("Wystąpił błąd:\n\t-" + exmsg);
                else
                    MessageBox.Show("Oddano samochód do naprawy");
            }
            else
            {
                MessageBox.Show("Wystąpił błąd w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }
        }
        /// <summary>
        /// Przycisk który zatwierdza wprowadzone zmiany
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZatwierdźES_Click(object sender, EventArgs e)
        {
            
            // Sprawdzenie poprawności danych w textboxie
           
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[0-9]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ID";
                poprawneTextboxy = false;
            }
            if (poprawneTextboxy == true)
            {
                
                // Pobranie danych z TextBoxa
                
                int id = int.Parse(textBox1.Text);
                string inne = textBox2.Text;
                if (string.IsNullOrEmpty(inne))
                    inne = "brak";
                string exmsg = "";
                string zapytanie = "update [dbo].[Samochód] set [Dostepnosc] = 1, [Inne] = '" + inne + "' where [Id_samochodu] = " + id;
                FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
                if (!string.IsNullOrEmpty(exmsg))
                    MessageBox.Show("Wystąpił błąd:\n\t-" + exmsg);
                else
                    MessageBox.Show("Przyjęto samochód z naprawy");
            }
            else
            {
                MessageBox.Show("Wystąpił błąd w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }
        }

        private void SamochodNaprawa_Load(object sender, EventArgs e)
        {

        }
    }
}