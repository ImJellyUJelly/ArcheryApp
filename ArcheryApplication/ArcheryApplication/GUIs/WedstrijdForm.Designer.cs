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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.cbSoort = new System.Windows.Forms.ComboBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWedstrijden = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NieuweWedstrijd = new System.Windows.Forms.Button();
            this.btBewerkWedstrijd = new System.Windows.Forms.Button();
            this.btVerwijderWedstrijd = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(167, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acties";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtDatum);
            this.groupBox2.Controls.Add(this.cbSoort);
            this.groupBox2.Controls.Add(this.tbNaam);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(182, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(268, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wedstrijdinformatie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum:";
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(51, 73);
            this.dtDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtDatum.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(212, 20);
            this.dtDatum.TabIndex = 5;
            // 
            // cbSoort
            // 
            this.cbSoort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoort.FormattingEnabled = true;
            this.cbSoort.Location = new System.Drawing.Point(51, 48);
            this.cbSoort.Margin = new System.Windows.Forms.Padding(2);
            this.cbSoort.Name = "cbSoort";
            this.cbSoort.Size = new System.Drawing.Size(212, 21);
            this.cbSoort.TabIndex = 4;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(51, 24);
            this.tbNaam.Margin = new System.Windows.Forms.Padding(2);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(212, 20);
            this.tbNaam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam:";
            // 
            // lbWedstrijden
            // 
            this.lbWedstrijden.FormattingEnabled = true;
            this.lbWedstrijden.Location = new System.Drawing.Point(8, 18);
            this.lbWedstrijden.Margin = new System.Windows.Forms.Padding(2);
            this.lbWedstrijden.Name = "lbWedstrijden";
            this.lbWedstrijden.Size = new System.Drawing.Size(428, 173);
            this.lbWedstrijden.TabIndex = 0;
            this.lbWedstrijden.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbWedstrijden_MouseClick);
            this.lbWedstrijden.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbWedstrijden_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbWedstrijden);
            this.groupBox3.Location = new System.Drawing.Point(9, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 199);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wedstrijden";
            // 
            // NieuweWedstrijd
            // 
            this.NieuweWedstrijd.Location = new System.Drawing.Point(8, 17);
            this.NieuweWedstrijd.Margin = new System.Windows.Forms.Padding(2);
            this.NieuweWedstrijd.Name = "NieuweWedstrijd";
            this.NieuweWedstrijd.Size = new System.Drawing.Size(148, 28);
            this.NieuweWedstrijd.TabIndex = 3;
            this.NieuweWedstrijd.Text = "Nieuw";
            this.NieuweWedstrijd.UseVisualStyleBackColor = true;
            this.NieuweWedstrijd.Click += new System.EventHandler(this.NieuweWedstrijd_Click);
            // 
            // btBewerkWedstrijd
            // 
            this.btBewerkWedstrijd.Location = new System.Drawing.Point(8, 49);
            this.btBewerkWedstrijd.Margin = new System.Windows.Forms.Padding(2);
            this.btBewerkWedstrijd.Name = "btBewerkWedstrijd";
            this.btBewerkWedstrijd.Size = new System.Drawing.Size(148, 28);
            this.btBewerkWedstrijd.TabIndex = 4;
            this.btBewerkWedstrijd.Text = "Bewerk";
            this.btBewerkWedstrijd.UseVisualStyleBackColor = true;
            this.btBewerkWedstrijd.Click += new System.EventHandler(this.btBewerkWedstrijd_Click);
            // 
            // btVerwijderWedstrijd
            // 
            this.btVerwijderWedstrijd.Location = new System.Drawing.Point(8, 81);
            this.btVerwijderWedstrijd.Margin = new System.Windows.Forms.Padding(2);
            this.btVerwijderWedstrijd.Name = "btVerwijderWedstrijd";
            this.btVerwijderWedstrijd.Size = new System.Drawing.Size(148, 28);
            this.btVerwijderWedstrijd.TabIndex = 5;
            this.btVerwijderWedstrijd.Text = "Verwijder";
            this.btVerwijderWedstrijd.UseVisualStyleBackColor = true;
            this.btVerwijderWedstrijd.Click += new System.EventHandler(this.btVerwijderWedstrijd_Click);
            // 
            // WedstrijdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 341);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ListBox lbWedstrijden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Button NieuweWedstrijd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btVerwijderWedstrijd;
        private System.Windows.Forms.Button btBewerkWedstrijd;
    }
}

