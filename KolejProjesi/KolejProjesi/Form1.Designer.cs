namespace KolejProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKolejAdi = new System.Windows.Forms.TextBox();
            this.txtKolejSahibi = new System.Windows.Forms.TextBox();
            this.txtKolejUcreti = new System.Windows.Forms.TextBox();
            this.txtKolejKapasitesi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpIslemler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kolej Listesi";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(24, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 344);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // grpIslemler
            // 
            this.grpIslemler.Controls.Add(this.btnSil);
            this.grpIslemler.Controls.Add(this.btnGüncelle);
            this.grpIslemler.Controls.Add(this.btnTemizle);
            this.grpIslemler.Controls.Add(this.btnEkle);
            this.grpIslemler.Location = new System.Drawing.Point(372, 296);
            this.grpIslemler.Name = "grpIslemler";
            this.grpIslemler.Size = new System.Drawing.Size(325, 129);
            this.grpIslemler.TabIndex = 2;
            this.grpIslemler.TabStop = false;
            this.grpIslemler.Text = "İşlemler";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(188, 74);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 29);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(51, 74);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(94, 29);
            this.btnGüncelle.TabIndex = 2;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(188, 39);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(94, 29);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(51, 39);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 29);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kolej Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kolej Sahibi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kolej Ücreti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kolej Kapasitesi";
            // 
            // txtKolejAdi
            // 
            this.txtKolejAdi.Location = new System.Drawing.Point(157, 35);
            this.txtKolejAdi.Name = "txtKolejAdi";
            this.txtKolejAdi.Size = new System.Drawing.Size(125, 27);
            this.txtKolejAdi.TabIndex = 4;
            // 
            // txtKolejSahibi
            // 
            this.txtKolejSahibi.Location = new System.Drawing.Point(157, 82);
            this.txtKolejSahibi.Name = "txtKolejSahibi";
            this.txtKolejSahibi.Size = new System.Drawing.Size(125, 27);
            this.txtKolejSahibi.TabIndex = 5;
            // 
            // txtKolejUcreti
            // 
            this.txtKolejUcreti.Location = new System.Drawing.Point(157, 127);
            this.txtKolejUcreti.Name = "txtKolejUcreti";
            this.txtKolejUcreti.Size = new System.Drawing.Size(125, 27);
            this.txtKolejUcreti.TabIndex = 6;
            // 
            // txtKolejKapasitesi
            // 
            this.txtKolejKapasitesi.Location = new System.Drawing.Point(157, 170);
            this.txtKolejKapasitesi.Name = "txtKolejKapasitesi";
            this.txtKolejKapasitesi.Size = new System.Drawing.Size(125, 27);
            this.txtKolejKapasitesi.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKolejKapasitesi);
            this.groupBox2.Controls.Add(this.txtKolejUcreti);
            this.groupBox2.Controls.Add(this.txtKolejSahibi);
            this.groupBox2.Controls.Add(this.txtKolejAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(372, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kolej Bilgileri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpIslemler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpIslemler.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private GroupBox grpIslemler;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnTemizle;
        private Button btnEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtKolejAdi;
        private TextBox txtKolejSahibi;
        private TextBox txtKolejUcreti;
        private TextBox txtKolejKapasitesi;
        private GroupBox groupBox2;
    }
}