namespace LatihanGithub2
{
    partial class FormJurusan
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblIdJurusan = new System.Windows.Forms.Label();
            this.lblJurusan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbJurusan = new System.Windows.Forms.ComboBox();
            this.btnSIMPAN = new System.Windows.Forms.Button();
            this.btnKELUAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(123, 53);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(476, 46);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "INPUT DATA JURUSAN";
            // 
            // lblIdJurusan
            // 
            this.lblIdJurusan.AutoSize = true;
            this.lblIdJurusan.Location = new System.Drawing.Point(163, 161);
            this.lblIdJurusan.Name = "lblIdJurusan";
            this.lblIdJurusan.Size = new System.Drawing.Size(99, 20);
            this.lblIdJurusan.TabIndex = 1;
            this.lblIdJurusan.Text = "ID Jurusan  :";
            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new System.Drawing.Point(184, 219);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(78, 20);
            this.lblJurusan.TabIndex = 2;
            this.lblJurusan.Text = "Jurusan  :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 3;
            // 
            // cmbJurusan
            // 
            this.cmbJurusan.FormattingEnabled = true;
            this.cmbJurusan.Items.AddRange(new object[] {
            "Rekayasa Perangkat Lunak",
            "Akuntansi Keuangan Lembaga",
            "Teknik Kimia Industri",
            "Tata Kecantikan Kulit dan Rambut",
            "Usaha Layanan Wisata",
            "Perhotelan",
            "Desain Produk Busana"});
            this.cmbJurusan.Location = new System.Drawing.Point(293, 216);
            this.cmbJurusan.Name = "cmbJurusan";
            this.cmbJurusan.Size = new System.Drawing.Size(294, 28);
            this.cmbJurusan.TabIndex = 4;
            // 
            // btnSIMPAN
            // 
            this.btnSIMPAN.Location = new System.Drawing.Point(335, 317);
            this.btnSIMPAN.Name = "btnSIMPAN";
            this.btnSIMPAN.Size = new System.Drawing.Size(103, 40);
            this.btnSIMPAN.TabIndex = 5;
            this.btnSIMPAN.Text = "SIMPAN";
            this.btnSIMPAN.UseVisualStyleBackColor = true;
            // 
            // btnKELUAR
            // 
            this.btnKELUAR.Location = new System.Drawing.Point(496, 317);
            this.btnKELUAR.Name = "btnKELUAR";
            this.btnKELUAR.Size = new System.Drawing.Size(103, 40);
            this.btnKELUAR.TabIndex = 6;
            this.btnKELUAR.Text = "KELUAR";
            this.btnKELUAR.UseVisualStyleBackColor = true;
            // 
            // FormJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 440);
            this.Controls.Add(this.btnKELUAR);
            this.Controls.Add(this.btnSIMPAN);
            this.Controls.Add(this.cmbJurusan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblJurusan);
            this.Controls.Add(this.lblIdJurusan);
            this.Controls.Add(this.lblJudul);
            this.Name = "FormJurusan";
            this.Text = "FormJurusan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblIdJurusan;
        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbJurusan;
        private System.Windows.Forms.Button btnSIMPAN;
        private System.Windows.Forms.Button btnKELUAR;
    }
}