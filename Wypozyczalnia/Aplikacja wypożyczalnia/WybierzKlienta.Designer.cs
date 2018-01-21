namespace Aplikacja_wypożyczalnia
{
    partial class WybierzKlienta
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
            this.idklienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaklienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nipklienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonklienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklienta,
            this.nazwaklienta,
            this.Nipklienta,
            this.Telefonklienta});
            this.dataGridView1.Location = new System.Drawing.Point(99, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 195);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idklienta
            // 
            this.idklienta.HeaderText = "ID";
            this.idklienta.Name = "idklienta";
            // 
            // nazwaklienta
            // 
            this.nazwaklienta.HeaderText = "Nazwa ";
            this.nazwaklienta.Name = "nazwaklienta";
            // 
            // Nipklienta
            // 
            this.Nipklienta.HeaderText = "NIP";
            this.Nipklienta.Name = "Nipklienta";
            // 
            // Telefonklienta
            // 
            this.Telefonklienta.HeaderText = "Telefon";
            this.Telefonklienta.Name = "Telefonklienta";
            // 
            // WybierzKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 486);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WybierzKlienta";
            this.Text = "WybierzKlienta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaklienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nipklienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonklienta;
    }
}