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
    public partial class Edytuj_rezerwacje : Form
    {
        public Edytuj_rezerwacje()
        {
            InitializeComponent();
        }

        private void rezerwacje_Click(object sender, EventArgs e)
        {

        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacja re = new Rezerwacja();
            re.Show();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
