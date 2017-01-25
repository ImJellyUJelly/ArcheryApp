namespace ArcheryApplication.GUIs
{
    partial class WarningBox
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
            this.btTerug = new System.Windows.Forms.Button();
            this.btDoorgaan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btTerug
            // 
            this.btTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTerug.Location = new System.Drawing.Point(154, 56);
            this.btTerug.Name = "btTerug";
            this.btTerug.Size = new System.Drawing.Size(81, 23);
            this.btTerug.TabIndex = 0;
            this.btTerug.Text = "Nee";
            this.btTerug.UseVisualStyleBackColor = true;
            this.btTerug.Click += new System.EventHandler(this.btTerug_Click);
            // 
            // btDoorgaan
            // 
            this.btDoorgaan.Location = new System.Drawing.Point(12, 56);
            this.btDoorgaan.Name = "btDoorgaan";
            this.btDoorgaan.Size = new System.Drawing.Size(81, 23);
            this.btDoorgaan.TabIndex = 1;
            this.btDoorgaan.Text = "Ja";
            this.btDoorgaan.UseVisualStyleBackColor = true;
            this.btDoorgaan.Click += new System.EventHandler(this.btDoorgaan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weet u zeker dat u door wilt gaan?";
            // 
            // WarningBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 91);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDoorgaan);
            this.Controls.Add(this.btTerug);
            this.Name = "WarningBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarningBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTerug;
        private System.Windows.Forms.Button btDoorgaan;
        private System.Windows.Forms.Label label1;
    }
}