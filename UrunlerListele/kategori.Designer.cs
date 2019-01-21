namespace UrunlerListele
{
    partial class kategori
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
            this.listKategori1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listKategori1
            // 
            this.listKategori1.FormattingEnabled = true;
            this.listKategori1.Location = new System.Drawing.Point(25, 39);
            this.listKategori1.Name = "listKategori1";
            this.listKategori1.Size = new System.Drawing.Size(276, 225);
            this.listKategori1.TabIndex = 0;
            // 
            // kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 300);
            this.Controls.Add(this.listKategori1);
            this.Name = "kategori";
            this.Text = "kategori";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listKategori1;
    }
}