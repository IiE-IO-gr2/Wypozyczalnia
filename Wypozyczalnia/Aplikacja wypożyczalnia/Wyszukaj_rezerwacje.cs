﻿using System;
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
    public partial class Wyszukaj_rezerwacje : Form
    {
        public Wyszukaj_rezerwacje()
        {
            InitializeComponent();
        }

        private void wstecz_Click(object sender, EventArgs e)
        {

            this.Hide();
            Rezerwacja es = new Rezerwacja();
            es.Show();

        }
    }
}
