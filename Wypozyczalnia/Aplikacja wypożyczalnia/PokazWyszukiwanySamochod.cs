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
    public partial class PokazWyszukiwanySamochod : Form
    {
        /// <summary>
        ///Pokazuje dane przed edycją
        /// </summary>
        public PokazWyszukiwanySamochod(DataTable dt)
        {
            InitializeComponent();
            foreach (DataRow item in dt.Rows)
            {
                textBox1.Text = item[0].ToString();
                textBox2.Text = item[1].ToString();
                textBox3.Text = item[2].ToString();
                textBox4.Text = item[3].ToString();
                textBox5.Text = item[4].ToString();
                textBox6.Text = item[5].ToString();
                textBox7.Text = item[6].ToString();
                textBox8.Text = item[7].ToString();
                textBox9.Text = item[18].ToString();
                textBox10.Text = item[8].ToString();
                textBox11.Text = item[9].ToString();
                textBox12.Text = item[10].ToString();
                textBox13.Text = item[11].ToString();
                textBox14.Text = item[12].ToString();
                textBox15.Text = item[13].ToString();
                textBox16.Text = item[14].ToString();
                textBox17.Text = item[15].ToString();
                textBox18.Text = item[16].ToString();
            }
        }
        /// <summary>
        ///Przycisk zamknij okno zamyka okno edycji samochodu
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PokazWyszukiwanySamochod_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///Przycisk, który zatwierdza wprowadzone zmiany (w polu Dostępność zawsze trzeba zmienić odpowiednio z true na 1, a false na 0
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            /// <summary>
            /// Sprawdzenie poprawności danych w textboxach
            /// </summary>
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;

            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^([A-Za-z0-9\-ąćęłńóśźżĄĘŁŃŚŻŹĆÓ]){2,30}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu marka";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^([A-Za-z0-9\-ąćęłńóśźżĄĘŁŃŚŻŹĆÓ ]){2,30}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu model";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, @"^[0-9,.]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu pojemność";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox5.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^([A-Za-z0-9\-ąćęłńóśźżĄĘŁŃŚŻŹĆÓ]){2,20}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu rodzaj paliwa";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, @"^([A-Za-z0-9\-ąćęłńóśźżĄĘŁŃŚŻŹĆÓ]){2,30}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu typ nadwozia";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox7.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, @"^[0-9]{1,4}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ilość koni";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox8.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, @"^([A-Za-z0-9\-ąćęłńóśźżĄĘŁŃŚŻŹĆÓ]){2,30}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu skrzynia biegów";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox9.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, @"^([0-9]){1}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ilość biegów";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox10.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, @"^[0-9,.]{1,4}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu zużycie paliwa";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox11.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox11.Text, @"^([0-9]){1,2}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ilość miejsc";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox12.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox12.Text, @"^([0-9]){1}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ilość drzwi";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox13.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox13.Text, @"^([0-9]){4}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu rocznik";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox14.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox14.Text, @"^([A-Za-ząćęłńóśźżĄĘŁŃŚŻŹĆÓ]){2,20}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu kolor";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox15.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox15.Text, @"^([0-9,.]){2,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu cena za dobę";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox16.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox16.Text, @"^([0-1]){1}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu dostępność";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox18.Text) ||
                  !System.Text.RegularExpressions.Regex.IsMatch(textBox18.Text, @"^([0-9]){2,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu kaucja";
                poprawneTextboxy = false;
            }
            if (poprawneTextboxy == true)
            {
                int id = int.Parse(textBox1.Text);
                string mar = textBox2.Text;
                string mod = textBox3.Text;
                double poj = double.Parse(textBox4.Text);
                string rp = textBox5.Text;
                string tn = textBox6.Text;
                int ik = int.Parse(textBox7.Text);
                string sk = textBox8.Text;
                int ib = int.Parse(textBox9.Text);
                double zp = double.Parse(textBox10.Text);
                int im = int.Parse(textBox11.Text);
                int ilodr = int.Parse(textBox12.Text);
                int roc = int.Parse(textBox13.Text);
                string kol = textBox14.Text;
                double czd = double.Parse(textBox15.Text);
                bool dostep = false;
                if (textBox16.Text == "1")
                    dostep = true;
                string inne = textBox17.Text;
                int ka = int.Parse(textBox18.Text);
                /// <summary>
                /// Stworzenie obiektów reprezentujących podane dane
                /// </summary>
                Samochód samochod = new Samochód(id, mar, mod, poj, rp, tn, ik, sk, ib, zp, im, ilodr, roc, kol, czd, dostep, inne, ka);
                string exmsg_sm = samochod.EdytujSamochod();
                if (string.IsNullOrWhiteSpace(exmsg_sm))
                    MessageBox.Show("Zaktualizowano samochód w bazie");
                else
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg_sm);
            }
            else
            {
                /// <summary>
                ///Pokazuje, w którym textboxie jest błąd wprowadzonych danych
                /// </summary>
                MessageBox.Show("Wystąpiły błędy w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }
        }
    }
}

