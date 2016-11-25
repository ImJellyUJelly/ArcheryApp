namespace ArcheryApplication.GUIs
{
    partial class SchuttersLijst
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
            this.lbSchutters = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbSchutters
            // 
            this.lbSchutters.FormattingEnabled = true;
            this.lbSchutters.ItemHeight = 16;
            this.lbSchutters.Location = new System.Drawing.Point(13, 13);
            this.lbSchutters.Name = "lbSchutters";
            this.lbSchutters.ScrollAlwaysVisible = true;
            this.lbSchutters.Size = new System.Drawing.Size(383, 564);
            this.lbSchutters.TabIndex = 0;
            // 
            // SchuttersLijst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 597);
            this.Controls.Add(this.lbSchutters);
            this.Name = "SchuttersLijst";
            this.Text = "SchuttersLijst";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSchutters;
    }
}