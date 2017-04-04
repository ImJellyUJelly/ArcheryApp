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
            this.btVerwijderWedstrijd = new System.Windows.Forms.Button();
            this.btBewerkWedstrijd = new System.Windows.Forms.Button();
            this.NieuweWedstrijd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.cbSoort = new System.Windows.Forms.ComboBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbWedstrijden = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btVerwijderWedstrijd);
            this.groupBox1.Controls.Add(this.btBewerkWedstrijd);
            this.groupBox1.Controls.Add(this.NieuweWedstrijd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(223, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acties";
            // 
            // btVerwijderWedstrijd
            // 
            this.btVerwijderWedstrijd.Location = new System.Drawing.Point(11, 100);
            this.btVerwijderWedstrijd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVerwijderWedstrijd.Name = "btVerwijderWedstrijd";
            this.btVerwijderWedstrijd.Size = new System.Drawing.Size(197, 34);
            this.btVerwijderWedstrijd.TabIndex = 5;
            this.btVerwijderWedstrijd.Text = "Verwijder";
            this.btVerwijderWedstrijd.UseVisualStyleBackColor = true;
            this.btVerwijderWedstrijd.Click += new System.EventHandler(this.btVerwijderWedstrijd_Click);
            // 
            // btBewerkWedstrijd
            // 
            this.btBewerkWedstrijd.Location = new System.Drawing.Point(11, 60);
            this.btBewerkWedstrijd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBewerkWedstrijd.Name = "btBewerkWedstrijd";
            this.btBewerkWedstrijd.Size = new System.Drawing.Size(197, 34);
            this.btBewerkWedstrijd.TabIndex = 4;
            this.btBewerkWedstrijd.Text = "Bewerk";
            this.btBewerkWedstrijd.UseVisualStyleBackColor = true;
            this.btBewerkWedstrijd.Click += new System.EventHandler(this.btBewerkWedstrijd_Click);
            // 
            // NieuweWedstrijd
            // 
            this.NieuweWedstrijd.Location = new System.Drawing.Point(11, 21);
            this.NieuweWedstrijd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NieuweWedstrijd.Name = "NieuweWedstrijd";
            this.NieuweWedstrijd.Size = new System.Drawing.Size(197, 34);
            this.NieuweWedstrijd.TabIndex = 3;
            this.NieuweWedstrijd.Text = "Nieuw";
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
            this.groupBox2.Location = new System.Drawing.Point(243, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(357, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wedstrijdinformatie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum:";
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(68, 90);
            this.dtDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDatum.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(281, 22);
            this.dtDatum.TabIndex = 5;
            // 
            // cbSoort
            // 
            this.cbSoort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoort.FormattingEnabled = true;
            this.cbSoort.Location = new System.Drawing.Point(68, 59);
            this.cbSoort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSoort.Name = "cbSoort";
            this.cbSoort.Size = new System.Drawing.Size(281, 24);
            this.cbSoort.TabIndex = 4;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(68, 30);
            this.tbNaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(281, 22);
            this.tbNaam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbWedstrijden);
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(588, 245);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wedstrijden";
            // 
            // lbWedstrijden
            // 
            this.lbWedstrijden.FormattingEnabled = true;
            this.lbWedstrijden.ItemHeight = 16;
            this.lbWedstrijden.Location = new System.Drawing.Point(8, 23);
            this.lbWedstrijden.Name = "lbWedstrijden";
            this.lbWedstrijden.Size = new System.Drawing.Size(572, 212);
            this.lbWedstrijden.TabIndex = 0;
            this.lbWedstrijden.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbWedstrijden_MouseClick);
            this.lbWedstrijden.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbWedstrijden_MouseDoubleClick);
            // 
            // WedstrijdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 420);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WedstrijdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wedstrijdapplicatie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSoort;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Button NieuweWedstrijd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btVerwijderWedstrijd;
        private System.Windows.Forms.Button btBewerkWedstrijd;
        private System.Windows.Forms.ListBox lbWedstrijden;
    }
}

