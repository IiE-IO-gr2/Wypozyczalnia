namespace Aplikacja_wypożyczalnia
{
    partial class WybierzKlientaIndywidualnego
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pobraneIDKlienta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pobranaIloscWypozyczen = new System.Windows.Forms.TextBox();
            this.pobranaZnizkaLojalnosciowa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // pobraneIDKlienta
            // 
            this.pobraneIDKlienta.Location = new System.Drawing.Point(104, 459);
            this.pobraneIDKlienta.Name = "pobraneIDKlienta";
            this.pobraneIDKlienta.Size = new System.Drawing.Size(141, 20);
            this.pobraneIDKlienta.TabIndex = 1;
            this.pobraneIDKlienta.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(533, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "wybierz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pobranaIloscWypozyczen
            // 
            this.pobranaIloscWypozyczen.Location = new System.Drawing.Point(283, 446);
            this.pobranaIloscWypozyczen.Name = "pobranaIloscWypozyczen";
            this.pobranaIloscWypozyczen.Size = new System.Drawing.Size(100, 20);
            this.pobranaIloscWypozyczen.TabIndex = 3;
            this.pobranaIloscWypozyczen.Visible = false;
            // 
            // pobranaZnizkaLojalnosciowa
            // 
            this.pobranaZnizkaLojalnosciowa.Location = new System.Drawing.Point(283, 472);
            this.pobranaZnizkaLojalnosciowa.Name = "pobranaZnizkaLojalnosciowa";
            this.pobranaZnizkaLojalnosciowa.Size = new System.Drawing.Size(100, 20);
            this.pobranaZnizkaLojalnosciowa.TabIndex = 4;
            this.pobranaZnizkaLojalnosciowa.Visible = false;
            // 
            // WybierzKlientaIndywidualnego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 486);
            this.Controls.Add(this.pobranaZnizkaLojalnosciowa);
            this.Controls.Add(this.pobranaIloscWypozyczen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pobraneIDKlienta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WybierzKlientaIndywidualnego";
            this.Text = "WybierzKlientaIndywidualnego";
            this.Load += new System.EventHandler(this.WybierzKlientaIndywidualnego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pobraneIDKlienta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pobranaIloscWypozyczen;
        private System.Windows.Forms.TextBox pobranaZnizkaLojalnosciowa;
    }
}