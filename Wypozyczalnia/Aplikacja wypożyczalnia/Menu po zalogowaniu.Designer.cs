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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // samochody
            // 
            this.samochody.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.samochody.Location = new System.Drawing.Point(66, 109);
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
            this.rezerwacje.Location = new System.Drawing.Point(387, 109);
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
            this.klienci.Location = new System.Drawing.Point(66, 227);
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
            this.wypozyczenia.Location = new System.Drawing.Point(387, 227);
            this.wypozyczenia.Name = "wypozyczenia";
            this.wypozyczenia.Size = new System.Drawing.Size(235, 73);
            this.wypozyczenia.TabIndex = 3;
            this.wypozyczenia.Text = "Wypożyczenia";
            this.wypozyczenia.UseVisualStyleBackColor = true;
            this.wypozyczenia.Click += new System.EventHandler(this.wypozyczenia_Click);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.data.Location = new System.Drawing.Point(217, 417);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(40, 18);
            this.data.TabIndex = 4;
            this.data.Text = "data";
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas.Location = new System.Drawing.Point(413, 417);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(44, 18);
            this.czas.TabIndex = 5;
            this.czas.Text = "czas";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wylogowanie
            // 
            this.wylogowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.wylogowanie.Location = new System.Drawing.Point(269, 331);
            this.wylogowanie.Name = "wylogowanie";
            this.wylogowanie.Size = new System.Drawing.Size(147, 49);
            this.wylogowanie.TabIndex = 6;
            this.wylogowanie.Text = "Wyloguj się";
            this.wylogowanie.UseVisualStyleBackColor = true;
            this.wylogowanie.Click += new System.EventHandler(this.wylogowanie_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(688, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "e-mail: zapłata";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button3.Location = new System.Drawing.Point(688, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "e-mail: opóźnienia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button4.Location = new System.Drawing.Point(688, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "e-mail: kaucja";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(693, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "E-maile do klientów";
            // 
            // Menu_po_zalogowaniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o1;
            this.ClientSize = new System.Drawing.Size(888, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}