namespace Aplikacja_wypożyczalnia
{
    partial class Menu_po_zalogowaniu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.samochody = new System.Windows.Forms.Button();
            this.rezerwacje = new System.Windows.Forms.Button();
            this.klienci = new System.Windows.Forms.Button();
            this.wypozyczenia = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.Label();
            this.czas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wylogowanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // samochody
            // 
            this.samochody.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.samochody.Location = new System.Drawing.Point(98, 109);
            this.samochody.Name = "samochody";
            this.samochody.Size = new System.Drawing.Size(235, 73);
            this.samochody.TabIndex = 0;
            this.samochody.Text = "Samochody";
            this.samochody.UseVisualStyleBackColor = true;
            this.samochody.Click += new System.EventHandler(this.samochody_Click);
            // 
            // rezerwacje
            // 
            this.rezerwacje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezerwacje.Location = new System.Drawing.Point(411, 109);
            this.rezerwacje.Name = "rezerwacje";
            this.rezerwacje.Size = new System.Drawing.Size(235, 73);
            this.rezerwacje.TabIndex = 1;
            this.rezerwacje.Text = "Rezerwacje";
            this.rezerwacje.UseVisualStyleBackColor = true;
            this.rezerwacje.Click += new System.EventHandler(this.rezerwacje_Click);
            // 
            // klienci
            // 
            this.klienci.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klienci.Location = new System.Drawing.Point(98, 238);
            this.klienci.Name = "klienci";
            this.klienci.Size = new System.Drawing.Size(235, 73);
            this.klienci.TabIndex = 2;
            this.klienci.Text = "Klienci";
            this.klienci.UseVisualStyleBackColor = true;
            this.klienci.Click += new System.EventHandler(this.klienci_Click);
            // 
            // wypozyczenia
            // 
            this.wypozyczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wypozyczenia.Location = new System.Drawing.Point(411, 238);
            this.wypozyczenia.Name = "wypozyczenia";
            this.wypozyczenia.Size = new System.Drawing.Size(235, 73);
            this.wypozyczenia.TabIndex = 3;
            this.wypozyczenia.Text = "Wypożyczenia";
            this.wypozyczenia.UseVisualStyleBackColor = true;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.data.Location = new System.Drawing.Point(280, 393);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(40, 18);
            this.data.TabIndex = 4;
            this.data.Text = "data";
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas.Location = new System.Drawing.Point(429, 393);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(44, 18);
            this.czas.TabIndex = 5;
            this.czas.Text = "czas";
            this.czas.Click += new System.EventHandler(this.czas_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wylogowanie
            // 
            this.wylogowanie.Location = new System.Drawing.Point(770, 21);
            this.wylogowanie.Name = "wylogowanie";
            this.wylogowanie.Size = new System.Drawing.Size(75, 23);
            this.wylogowanie.TabIndex = 6;
            this.wylogowanie.Text = "Wyloguj się";
            this.wylogowanie.UseVisualStyleBackColor = true;
            this.wylogowanie.Click += new System.EventHandler(this.wylogowanie_Click);
            // 
            // Menu_po_zalogowaniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o1;
            this.ClientSize = new System.Drawing.Size(888, 484);
            this.Controls.Add(this.wylogowanie);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.data);
            this.Controls.Add(this.wypozyczenia);
            this.Controls.Add(this.klienci);
            this.Controls.Add(this.rezerwacje);
            this.Controls.Add(this.samochody);
            this.Name = "Menu_po_zalogowaniu";
            this.Text = "Menu_po_zalogowaniu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Menu_po_zalogowaniu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button samochody;
        private System.Windows.Forms.Button rezerwacje;
        private System.Windows.Forms.Button klienci;
        private System.Windows.Forms.Button wypozyczenia;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button wylogowanie;
    }
}