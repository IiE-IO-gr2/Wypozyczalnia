namespace Aplikacja_wypożyczalnia
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.rezerwacje = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(292, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID rezerwacji";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(422, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(148, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data planowanego wypożyczenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(198, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Data planowanego zwrotu";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(422, 198);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 51);
            this.button3.TabIndex = 23;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // rezerwacje
            // 
            this.rezerwacje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.rezerwacje.Location = new System.Drawing.Point(334, 28);
            this.rezerwacje.Name = "rezerwacje";
            this.rezerwacje.Size = new System.Drawing.Size(235, 73);
            this.rezerwacje.TabIndex = 25;
            this.rezerwacje.Text = "Dodaj rezerwacje";
            this.rezerwacje.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(374, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 51);
            this.button5.TabIndex = 26;
            this.button5.Text = "Menu główne";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 27;
            this.button1.Text = "Wybierz klienta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 51);
            this.button2.TabIndex = 28;
            this.button2.Text = "Wybierz samochód";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackgroundImage = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o1;
            this.ClientSize = new System.Drawing.Size(888, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.rezerwacje);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rezerwacje;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}