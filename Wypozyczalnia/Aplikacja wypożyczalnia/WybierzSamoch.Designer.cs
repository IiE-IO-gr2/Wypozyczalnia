﻿namespace Aplikacja_wypożyczalnia
{
    partial class WybierzSamoch
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
            this.button1 = new System.Windows.Forms.Button();
            this.PobraneIDSam = new System.Windows.Forms.TextBox();
            this.Kwota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "wybierz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PobraneIDSam
            // 
            this.PobraneIDSam.Location = new System.Drawing.Point(107, 424);
            this.PobraneIDSam.Name = "PobraneIDSam";
            this.PobraneIDSam.Size = new System.Drawing.Size(107, 20);
            this.PobraneIDSam.TabIndex = 2;
            this.PobraneIDSam.Visible = false;
            // 
            // Kwota
            // 
            this.Kwota.Location = new System.Drawing.Point(261, 424);
            this.Kwota.Name = "Kwota";
            this.Kwota.Size = new System.Drawing.Size(107, 20);
            this.Kwota.TabIndex = 3;
            this.Kwota.Visible = false;
            // 
            // WybierzSamoch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 472);
            this.Controls.Add(this.Kwota);
            this.Controls.Add(this.PobraneIDSam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WybierzSamoch";
            this.Text = "WybierzSamoch";
            this.Load += new System.EventHandler(this.WybierzSamochod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PobraneIDSam;
        private System.Windows.Forms.TextBox Kwota;
    }
}