namespace Aplikacja_wypożyczalnia
{
    partial class WyszukajSamochód
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WsteczWS = new System.Windows.Forms.Button();
            this.ZatwierdźWS = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(243, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID samochodu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Image = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o1;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Wyszukaj samochód";
            // 
            // WsteczWS
            // 
            this.WsteczWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WsteczWS.Location = new System.Drawing.Point(243, 384);
            this.WsteczWS.Name = "WsteczWS";
            this.WsteczWS.Size = new System.Drawing.Size(125, 65);
            this.WsteczWS.TabIndex = 34;
            this.WsteczWS.Text = "Wstecz";
            this.WsteczWS.UseVisualStyleBackColor = true;
            this.WsteczWS.Click += new System.EventHandler(this.WsteczWS_Click);
            // 
            // ZatwierdźWS
            // 
            this.ZatwierdźWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZatwierdźWS.Location = new System.Drawing.Point(496, 384);
            this.ZatwierdźWS.Name = "ZatwierdźWS";
            this.ZatwierdźWS.Size = new System.Drawing.Size(125, 65);
            this.ZatwierdźWS.TabIndex = 35;
            this.ZatwierdźWS.Text = "Wyszukaj";
            this.ZatwierdźWS.UseVisualStyleBackColor = true;
            this.ZatwierdźWS.Click += new System.EventHandler(this.ZatwierdźWS_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 92);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // WyszukajSamochód
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ZatwierdźWS);
            this.Controls.Add(this.WsteczWS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "WyszukajSamochód";
            this.Text = "WyszukajSamochód";
            this.Load += new System.EventHandler(this.WyszukajSamochód_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WsteczWS;
        private System.Windows.Forms.Button ZatwierdźWS;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}