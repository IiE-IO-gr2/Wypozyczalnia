namespace Aplikacja_wypożyczalnia
{
    partial class EdytujKlienta
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ZatwierdźWS = new System.Windows.Forms.Button();
            this.WsteczWS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(305, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(336, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Edytuj Klienta";
            // 
            // ZatwierdźWS
            // 
            this.ZatwierdźWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZatwierdźWS.Location = new System.Drawing.Point(523, 385);
            this.ZatwierdźWS.Name = "ZatwierdźWS";
            this.ZatwierdźWS.Size = new System.Drawing.Size(125, 65);
            this.ZatwierdźWS.TabIndex = 56;
            this.ZatwierdźWS.Text = "Zatwierdź";
            this.ZatwierdźWS.UseVisualStyleBackColor = true;
            // 
            // WsteczWS
            // 
            this.WsteczWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WsteczWS.Location = new System.Drawing.Point(268, 385);
            this.WsteczWS.Name = "WsteczWS";
            this.WsteczWS.Size = new System.Drawing.Size(125, 65);
            this.WsteczWS.TabIndex = 57;
            this.WsteczWS.Text = "Wstecz";
            this.WsteczWS.UseVisualStyleBackColor = true;
            // 
            // EdytujKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikacja_wypożyczalnia.Properties.Resources._26653464_1222776397822724_926715336_o1;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.WsteczWS);
            this.Controls.Add(this.ZatwierdźWS);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdytujKlienta";
            this.Text = "EdytujKlienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ZatwierdźWS;
        private System.Windows.Forms.Button WsteczWS;
    }
}