namespace ProjectVispro
{
    partial class formrincianorder
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxNilaiAwal = new System.Windows.Forms.TextBox();
            this.LblIdOrder = new System.Windows.Forms.Label();
            this.LblHarga = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblMakanan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(498, 359);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 20);
            this.labelTotal.TabIndex = 14;
            // 
            // textBoxNilaiAwal
            // 
            this.textBoxNilaiAwal.Location = new System.Drawing.Point(430, 283);
            this.textBoxNilaiAwal.Name = "textBoxNilaiAwal";
            this.textBoxNilaiAwal.Size = new System.Drawing.Size(100, 26);
            this.textBoxNilaiAwal.TabIndex = 13;
            // 
            // LblIdOrder
            // 
            this.LblIdOrder.AutoSize = true;
            this.LblIdOrder.Location = new System.Drawing.Point(530, 421);
            this.LblIdOrder.Name = "LblIdOrder";
            this.LblIdOrder.Size = new System.Drawing.Size(0, 20);
            this.LblIdOrder.TabIndex = 12;
            // 
            // LblHarga
            // 
            this.LblHarga.AutoSize = true;
            this.LblHarga.BackColor = System.Drawing.Color.Transparent;
            this.LblHarga.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHarga.Location = new System.Drawing.Point(389, 196);
            this.LblHarga.Name = "LblHarga";
            this.LblHarga.Size = new System.Drawing.Size(76, 18);
            this.LblHarga.TabIndex = 11;
            this.LblHarga.Text = "LblHarga";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "SAVE ORDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Jumlah Pesanan";
            // 
            // LblMakanan
            // 
            this.LblMakanan.AutoSize = true;
            this.LblMakanan.BackColor = System.Drawing.Color.Transparent;
            this.LblMakanan.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMakanan.Location = new System.Drawing.Point(365, 165);
            this.LblMakanan.Name = "LblMakanan";
            this.LblMakanan.Size = new System.Drawing.Size(126, 18);
            this.LblMakanan.TabIndex = 8;
            this.LblMakanan.Text = "Makanan Pilihan";
            // 
            // formrincianorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectVispro.Properties.Resources.gradiant_biru_ke_putih;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxNilaiAwal);
            this.Controls.Add(this.LblIdOrder);
            this.Controls.Add(this.LblHarga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblMakanan);
            this.Name = "formrincianorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formrincianorder";
            this.Load += new System.EventHandler(this.formrincianorder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxNilaiAwal;
        private System.Windows.Forms.Label LblIdOrder;
        private System.Windows.Forms.Label LblHarga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblMakanan;
    }
}