namespace Aplikacja_wypożyczalnia
{
    partial class UsuńSamochód
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WsteczUS = new System.Windows.Forms.Button();
            this.ZatwierdźUS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Image = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o;
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuń Samochód";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Image = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o;
            this.label2.Location = new System.Drawing.Point(243, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID samochodu";
            // 
            // WsteczUS
            // 
            this.WsteczUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WsteczUS.Location = new System.Drawing.Point(243, 384);
            this.WsteczUS.Name = "WsteczUS";
            this.WsteczUS.Size = new System.Drawing.Size(125, 65);
            this.WsteczUS.TabIndex = 34;
            this.WsteczUS.Text = "Wstecz";
            this.WsteczUS.UseVisualStyleBackColor = true;
            this.WsteczUS.Click += new System.EventHandler(this.WsteczUS_Click);
            // 
            // ZatwierdźUS
            // 
            this.ZatwierdźUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZatwierdźUS.Location = new System.Drawing.Point(496, 384);
            this.ZatwierdźUS.Name = "ZatwierdźUS";
            this.ZatwierdźUS.Size = new System.Drawing.Size(125, 65);
            this.ZatwierdźUS.TabIndex = 35;
            this.ZatwierdźUS.Text = "Zatwierdź";
            this.ZatwierdźUS.UseVisualStyleBackColor = true;
            this.ZatwierdźUS.Click += new System.EventHandler(this.ZatwierdźUS_Click_1);
            // 
            // UsuńSamochód
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ZatwierdźUS);
            this.Controls.Add(this.WsteczUS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "UsuńSamochód";
            this.Text = "UsuńSamochód";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button WsteczUS;
        private System.Windows.Forms.Button ZatwierdźUS;
    }
}