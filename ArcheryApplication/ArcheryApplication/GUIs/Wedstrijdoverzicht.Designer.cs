﻿namespace ArcheryApplication.GUIs
{
    partial class Wedstrijdoverzicht
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
            this.lbBanen = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbDatum = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbAantalSchutters = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbSoort = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbWedstrijdnaam = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btNieuweBaan = new System.Windows.Forms.Button();
            this.btBewerkSchutter = new System.Windows.Forms.Button();
            this.btNieuweSchutter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBanen
            // 
            this.lbBanen.FormattingEnabled = true;
            this.lbBanen.Location = new System.Drawing.Point(6, 19);
            this.lbBanen.Name = "lbBanen";
            this.lbBanen.Size = new System.Drawing.Size(531, 433);
            this.lbBanen.TabIndex = 0;
            this.lbBanen.SelectedIndexChanged += new System.EventHandler(this.lbBanen_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBanen);
            this.groupBox1.Location = new System.Drawing.Point(268, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wedstrijd Informatie";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbDatum);
            this.groupBox6.Location = new System.Drawing.Point(6, 166);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(237, 43);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datum";
            // 
            // lbDatum
            // 
            this.lbDatum.AutoSize = true;
            this.lbDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDatum.Location = new System.Drawing.Point(6, 16);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.Size = new System.Drawing.Size(51, 20);
            this.lbDatum.TabIndex = 2;
            this.lbDatum.Text = "label1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbAantalSchutters);
            this.groupBox5.Location = new System.Drawing.Point(6, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 43);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Aantal aangemelde schutters";
            // 
            // lbAantalSchutters
            // 
            this.lbAantalSchutters.AutoSize = true;
            this.lbAantalSchutters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAantalSchutters.Location = new System.Drawing.Point(6, 16);
            this.lbAantalSchutters.Name = "lbAantalSchutters";
            this.lbAantalSchutters.Size = new System.Drawing.Size(51, 20);
            this.lbAantalSchutters.TabIndex = 2;
            this.lbAantalSchutters.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbSoort);
            this.groupBox4.Location = new System.Drawing.Point(6, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 43);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Soort";
            // 
            // lbSoort
            // 
            this.lbSoort.AutoSize = true;
            this.lbSoort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSoort.Location = new System.Drawing.Point(6, 16);
            this.lbSoort.Name = "lbSoort";
            this.lbSoort.Size = new System.Drawing.Size(51, 20);
            this.lbSoort.TabIndex = 1;
            this.lbSoort.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbWedstrijdnaam);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 43);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Naam";
            // 
            // lbWedstrijdnaam
            // 
            this.lbWedstrijdnaam.AutoSize = true;
            this.lbWedstrijdnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbWedstrijdnaam.Location = new System.Drawing.Point(6, 16);
            this.lbWedstrijdnaam.Name = "lbWedstrijdnaam";
            this.lbWedstrijdnaam.Size = new System.Drawing.Size(51, 20);
            this.lbWedstrijdnaam.TabIndex = 0;
            this.lbWedstrijdnaam.Text = "label1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btNieuweBaan);
            this.groupBox7.Controls.Add(this.btBewerkSchutter);
            this.groupBox7.Controls.Add(this.btNieuweSchutter);
            this.groupBox7.Location = new System.Drawing.Point(13, 234);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(249, 107);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Schutter informatie";
            // 
            // btNieuweBaan
            // 
            this.btNieuweBaan.Location = new System.Drawing.Point(101, 20);
            this.btNieuweBaan.Name = "btNieuweBaan";
            this.btNieuweBaan.Size = new System.Drawing.Size(88, 36);
            this.btNieuweBaan.TabIndex = 2;
            this.btNieuweBaan.Text = "Geef nieuwe baan";
            this.btNieuweBaan.UseVisualStyleBackColor = true;
            // 
            // btBewerkSchutter
            // 
            this.btBewerkSchutter.Location = new System.Drawing.Point(7, 65);
            this.btBewerkSchutter.Name = "btBewerkSchutter";
            this.btBewerkSchutter.Size = new System.Drawing.Size(88, 36);
            this.btBewerkSchutter.TabIndex = 1;
            this.btBewerkSchutter.Text = "Bewerk schutter";
            this.btBewerkSchutter.UseVisualStyleBackColor = true;
            this.btBewerkSchutter.Click += new System.EventHandler(this.btBewerkSchutter_Click);
            // 
            // btNieuweSchutter
            // 
            this.btNieuweSchutter.Location = new System.Drawing.Point(7, 20);
            this.btNieuweSchutter.Name = "btNieuweSchutter";
            this.btNieuweSchutter.Size = new System.Drawing.Size(88, 36);
            this.btNieuweSchutter.TabIndex = 0;
            this.btNieuweSchutter.Text = "Nieuwe schutter";
            this.btNieuweSchutter.UseVisualStyleBackColor = true;
            this.btNieuweSchutter.Click += new System.EventHandler(this.btNieuweSchutter_Click);
            // 
            // Wedstrijdoverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 480);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Wedstrijdoverzicht";
            this.Text = "Wedstrijdinformatie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBanen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbAantalSchutters;
        private System.Windows.Forms.Label lbSoort;
        private System.Windows.Forms.Label lbWedstrijdnaam;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbDatum;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btBewerkSchutter;
        private System.Windows.Forms.Button btNieuweSchutter;
        private System.Windows.Forms.Button btNieuweBaan;
    }
}