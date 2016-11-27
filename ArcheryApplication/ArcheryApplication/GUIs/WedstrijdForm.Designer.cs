namespace ArcheryApplication
{
    partial class WedstrijdForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btBaanToewijzen = new System.Windows.Forms.Button();
            this.btBewerkSchutter = new System.Windows.Forms.Button();
            this.btNieuweSchutter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NieuweWedstrijd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.cbSoort = new System.Windows.Forms.ComboBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWedstrijden = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSchutters = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(167, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 236);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Testknop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btBaanToewijzen);
            this.groupBox5.Controls.Add(this.btBewerkSchutter);
            this.groupBox5.Controls.Add(this.btNieuweSchutter);
            this.groupBox5.Location = new System.Drawing.Point(5, 67);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(158, 99);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Schutter";
            // 
            // btBaanToewijzen
            // 
            this.btBaanToewijzen.Location = new System.Drawing.Point(4, 72);
            this.btBaanToewijzen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBaanToewijzen.Name = "btBaanToewijzen";
            this.btBaanToewijzen.Size = new System.Drawing.Size(148, 23);
            this.btBaanToewijzen.TabIndex = 2;
            this.btBaanToewijzen.Text = "Wijs Baan Toe";
            this.btBaanToewijzen.UseVisualStyleBackColor = true;
            this.btBaanToewijzen.Click += new System.EventHandler(this.btBaanToewijzen_Click);
            // 
            // btBewerkSchutter
            // 
            this.btBewerkSchutter.Location = new System.Drawing.Point(4, 45);
            this.btBewerkSchutter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBewerkSchutter.Name = "btBewerkSchutter";
            this.btBewerkSchutter.Size = new System.Drawing.Size(148, 23);
            this.btBewerkSchutter.TabIndex = 1;
            this.btBewerkSchutter.Text = "Bewerk Schutter";
            this.btBewerkSchutter.UseVisualStyleBackColor = true;
            this.btBewerkSchutter.Click += new System.EventHandler(this.button2_Click);
            // 
            // btNieuweSchutter
            // 
            this.btNieuweSchutter.Location = new System.Drawing.Point(4, 17);
            this.btNieuweSchutter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNieuweSchutter.Name = "btNieuweSchutter";
            this.btNieuweSchutter.Size = new System.Drawing.Size(148, 23);
            this.btNieuweSchutter.TabIndex = 0;
            this.btNieuweSchutter.Text = "Nieuwe Schutter";
            this.btNieuweSchutter.UseVisualStyleBackColor = true;
            this.btNieuweSchutter.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NieuweWedstrijd);
            this.groupBox4.Location = new System.Drawing.Point(4, 17);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(158, 45);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wedstrijd";
            // 
            // NieuweWedstrijd
            // 
            this.NieuweWedstrijd.Location = new System.Drawing.Point(4, 17);
            this.NieuweWedstrijd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NieuweWedstrijd.Name = "NieuweWedstrijd";
            this.NieuweWedstrijd.Size = new System.Drawing.Size(148, 23);
            this.NieuweWedstrijd.TabIndex = 0;
            this.NieuweWedstrijd.Text = "Nieuwe Wedstrijd";
            this.NieuweWedstrijd.UseVisualStyleBackColor = true;
            this.NieuweWedstrijd.Click += new System.EventHandler(this.NieuweWedstrijd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtDatum);
            this.groupBox2.Controls.Add(this.cbSoort);
            this.groupBox2.Controls.Add(this.tbNaam);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbWedstrijden);
            this.groupBox2.Location = new System.Drawing.Point(182, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(629, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wedstrijdinformatie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum:";
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(51, 72);
            this.dtDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(146, 20);
            this.dtDatum.TabIndex = 5;
            // 
            // cbSoort
            // 
            this.cbSoort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoort.FormattingEnabled = true;
            this.cbSoort.Location = new System.Drawing.Point(51, 46);
            this.cbSoort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSoort.Name = "cbSoort";
            this.cbSoort.Size = new System.Drawing.Size(146, 21);
            this.cbSoort.TabIndex = 4;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(51, 24);
            this.tbNaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(146, 20);
            this.tbNaam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam:";
            // 
            // lbWedstrijden
            // 
            this.lbWedstrijden.FormattingEnabled = true;
            this.lbWedstrijden.Location = new System.Drawing.Point(200, 17);
            this.lbWedstrijden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbWedstrijden.Name = "lbWedstrijden";
            this.lbWedstrijden.Size = new System.Drawing.Size(426, 173);
            this.lbWedstrijden.TabIndex = 0;
            this.lbWedstrijden.SelectedIndexChanged += new System.EventHandler(this.lbWedstrijden_SelectedIndexChanged);
            this.lbWedstrijden.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbWedstrijden_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbSchutters);
            this.groupBox3.Location = new System.Drawing.Point(182, 214);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(629, 212);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schutterinformatie";
            // 
            // lbSchutters
            // 
            this.lbSchutters.FormattingEnabled = true;
            this.lbSchutters.Location = new System.Drawing.Point(200, 17);
            this.lbSchutters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbSchutters.Name = "lbSchutters";
            this.lbSchutters.Size = new System.Drawing.Size(426, 186);
            this.lbSchutters.TabIndex = 7;
            this.lbSchutters.SelectedIndexChanged += new System.EventHandler(this.lbSchutters_SelectedIndexChanged);
            // 
            // WedstrijdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 436);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WedstrijdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wedstrijdapplicatie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NieuweWedstrijd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSoort;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbWedstrijden;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.ListBox lbSchutters;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btNieuweSchutter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btBewerkSchutter;
        private System.Windows.Forms.Button btBaanToewijzen;
        private System.Windows.Forms.Button button3;
    }
}

