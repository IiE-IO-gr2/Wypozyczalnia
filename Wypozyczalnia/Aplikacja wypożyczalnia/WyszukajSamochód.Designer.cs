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
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(246, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID samochodu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Image = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o1;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Wyszukaj samochód";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button5.Location = new System.Drawing.Point(250, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 54;
            this.button5.Text = "Wstecz";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Location = new System.Drawing.Point(560, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 55;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WyszukajSamochód
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "WyszukajSamochód";
            this.Text = "WyszukajSamochód";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}