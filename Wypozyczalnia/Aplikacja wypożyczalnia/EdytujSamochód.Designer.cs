namespace Aplikacja_wypożyczalnia
{
    partial class EdytujSamochód
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WsteczES = new System.Windows.Forms.Button();
            this.ZatwierdźES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Image = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edytuj Samochód";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Image = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o;
            this.label2.Location = new System.Drawing.Point(235, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID samochodu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WsteczES
            // 
            this.WsteczES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WsteczES.Location = new System.Drawing.Point(235, 384);
            this.WsteczES.Name = "WsteczES";
            this.WsteczES.Size = new System.Drawing.Size(125, 65);
            this.WsteczES.TabIndex = 36;
            this.WsteczES.Text = "Wstecz";
            this.WsteczES.UseVisualStyleBackColor = true;
            this.WsteczES.Click += new System.EventHandler(this.WsteczES_Click);
            // 
            // ZatwierdźES
            // 
            this.ZatwierdźES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZatwierdźES.Location = new System.Drawing.Point(500, 384);
            this.ZatwierdźES.Name = "ZatwierdźES";
            this.ZatwierdźES.Size = new System.Drawing.Size(125, 65);
            this.ZatwierdźES.TabIndex = 37;
            this.ZatwierdźES.Text = "Zatwierdź";
            this.ZatwierdźES.UseVisualStyleBackColor = true;
            // 
            // EdytujSamochód
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ZatwierdźES);
            this.Controls.Add(this.WsteczES);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdytujSamochód";
            this.Text = "EdytujSamochód";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button WsteczES;
        private System.Windows.Forms.Button ZatwierdźES;
    }
}