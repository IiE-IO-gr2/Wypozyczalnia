namespace Aplikacja_wypożyczalnia
{
    partial class Klienci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klienci));
            this.label1 = new System.Windows.Forms.Label();
            this.dodaj = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.wyszukaj = new System.Windows.Forms.Button();
            this.edytuj = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(376, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klienci";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dodaj.Location = new System.Drawing.Point(280, 125);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 40);
            this.dodaj.TabIndex = 1;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // usun
            // 
            this.usun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.usun.Location = new System.Drawing.Point(489, 125);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(75, 40);
            this.usun.TabIndex = 2;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // wyszukaj
            // 
            this.wyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.wyszukaj.Location = new System.Drawing.Point(280, 226);
            this.wyszukaj.Name = "wyszukaj";
            this.wyszukaj.Size = new System.Drawing.Size(75, 40);
            this.wyszukaj.TabIndex = 3;
            this.wyszukaj.Text = "Wyszukaj";
            this.wyszukaj.UseVisualStyleBackColor = true;
            this.wyszukaj.Click += new System.EventHandler(this.wyszukaj_Click);
            // 
            // edytuj
            // 
            this.edytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.edytuj.Location = new System.Drawing.Point(489, 226);
            this.edytuj.Name = "edytuj";
            this.edytuj.Size = new System.Drawing.Size(75, 40);
            this.edytuj.TabIndex = 4;
            this.edytuj.Text = "Edytuj";
            this.edytuj.UseVisualStyleBackColor = true;
            this.edytuj.Click += new System.EventHandler(this.edytuj_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button5.Location = new System.Drawing.Point(61, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "Wstecz";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Klienci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.edytuj);
            this.Controls.Add(this.wyszukaj);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.label1);
            this.Name = "Klienci";
            this.Text = "Klienci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button wyszukaj;
        private System.Windows.Forms.Button edytuj;
        private System.Windows.Forms.Button button5;
    }
}