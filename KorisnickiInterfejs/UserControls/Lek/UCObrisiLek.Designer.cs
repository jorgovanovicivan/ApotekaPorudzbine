using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls.Lek
{
    partial class UCObrisiLek
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLekovi = new System.Windows.Forms.DataGridView();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUcitajLek = new System.Windows.Forms.Button();
            this.txtSifraLeka = new System.Windows.Forms.TextBox();
            this.cbTipLeka = new System.Windows.Forms.ComboBox();
            this.cbProizvodjac = new System.Windows.Forms.ComboBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtFOLeka = new System.Windows.Forms.TextBox();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.txtImeLeka = new System.Windows.Forms.TextBox();
            this.txtJKL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLekovi
            // 
            this.dgvLekovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLekovi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLekovi.Location = new System.Drawing.Point(24, 67);
            this.dgvLekovi.Name = "dgvLekovi";
            this.dgvLekovi.RowHeadersWidth = 51;
            this.dgvLekovi.RowTemplate.Height = 24;
            this.dgvLekovi.Size = new System.Drawing.Size(953, 168);
            this.dgvLekovi.TabIndex = 0;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(243, 24);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(299, 22);
            this.txtPretraga.TabIndex = 1;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(569, 18);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(103, 34);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretrazi po nazivu leka:";
            // 
            // btnUcitajLek
            // 
            this.btnUcitajLek.Location = new System.Drawing.Point(398, 252);
            this.btnUcitajLek.Name = "btnUcitajLek";
            this.btnUcitajLek.Size = new System.Drawing.Size(218, 28);
            this.btnUcitajLek.TabIndex = 31;
            this.btnUcitajLek.Text = "Ucitaj podatke o leku";
            this.btnUcitajLek.UseVisualStyleBackColor = true;
            // 
            // txtSifraLeka
            // 
            this.txtSifraLeka.Location = new System.Drawing.Point(398, 307);
            this.txtSifraLeka.Name = "txtSifraLeka";
            this.txtSifraLeka.ReadOnly = true;
            this.txtSifraLeka.Size = new System.Drawing.Size(218, 22);
            this.txtSifraLeka.TabIndex = 30;
            // 
            // cbTipLeka
            // 
            this.cbTipLeka.FormattingEnabled = true;
            this.cbTipLeka.Location = new System.Drawing.Point(398, 580);
            this.cbTipLeka.Name = "cbTipLeka";
            this.cbTipLeka.Size = new System.Drawing.Size(218, 24);
            this.cbTipLeka.TabIndex = 29;
            // 
            // cbProizvodjac
            // 
            this.cbProizvodjac.FormattingEnabled = true;
            this.cbProizvodjac.Location = new System.Drawing.Point(398, 537);
            this.cbProizvodjac.Name = "cbProizvodjac";
            this.cbProizvodjac.Size = new System.Drawing.Size(218, 24);
            this.cbProizvodjac.TabIndex = 28;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(398, 499);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(218, 22);
            this.txtCena.TabIndex = 27;
            // 
            // txtFOLeka
            // 
            this.txtFOLeka.Location = new System.Drawing.Point(398, 459);
            this.txtFOLeka.Name = "txtFOLeka";
            this.txtFOLeka.ReadOnly = true;
            this.txtFOLeka.Size = new System.Drawing.Size(218, 22);
            this.txtFOLeka.TabIndex = 26;
            // 
            // txtINN
            // 
            this.txtINN.Location = new System.Drawing.Point(398, 419);
            this.txtINN.Name = "txtINN";
            this.txtINN.ReadOnly = true;
            this.txtINN.Size = new System.Drawing.Size(218, 22);
            this.txtINN.TabIndex = 25;
            // 
            // txtImeLeka
            // 
            this.txtImeLeka.Location = new System.Drawing.Point(398, 380);
            this.txtImeLeka.Name = "txtImeLeka";
            this.txtImeLeka.ReadOnly = true;
            this.txtImeLeka.Size = new System.Drawing.Size(218, 22);
            this.txtImeLeka.TabIndex = 24;
            // 
            // txtJKL
            // 
            this.txtJKL.Location = new System.Drawing.Point(398, 342);
            this.txtJKL.Name = "txtJKL";
            this.txtJKL.ReadOnly = true;
            this.txtJKL.Size = new System.Drawing.Size(218, 22);
            this.txtJKL.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Sifra leka:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tip Leka:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Proizvodjac:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "FOLeka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "INN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ime leka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "JKL:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(398, 646);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(218, 39);
            this.btnObrisi.TabIndex = 40;
            this.btnObrisi.Text = "OBRISI";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // UCObrisiLek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUcitajLek);
            this.Controls.Add(this.txtSifraLeka);
            this.Controls.Add(this.cbTipLeka);
            this.Controls.Add(this.cbProizvodjac);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtFOLeka);
            this.Controls.Add(this.txtINN);
            this.Controls.Add(this.txtImeLeka);
            this.Controls.Add(this.txtJKL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvLekovi);
            this.Name = "UCObrisiLek";
            this.Size = new System.Drawing.Size(1014, 723);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLekovi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUcitajLek;
        private System.Windows.Forms.TextBox txtSifraLeka;
        private System.Windows.Forms.ComboBox cbTipLeka;
        private System.Windows.Forms.ComboBox cbProizvodjac;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtFOLeka;
        private System.Windows.Forms.TextBox txtINN;
        private System.Windows.Forms.TextBox txtImeLeka;
        private System.Windows.Forms.TextBox txtJKL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisi;


        public DataGridView DgvLekovi { get => dgvLekovi; set => dgvLekovi = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Button BtnPretraga { get => btnPretraga; set => btnPretraga = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnUcitajLek { get => btnUcitajLek; set => btnUcitajLek = value; }
        public TextBox TxtSifraLeka { get => txtSifraLeka; set => txtSifraLeka = value; }
        public ComboBox CbTipLeka { get => cbTipLeka; set => cbTipLeka = value; }
        public ComboBox CbProizvodjac { get => cbProizvodjac; set => cbProizvodjac = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public TextBox TxtFOLeka { get => txtFOLeka; set => txtFOLeka = value; }
        public TextBox TxtINN { get => txtINN; set => txtINN = value; }
        public TextBox TxtImeLeka { get => txtImeLeka; set => txtImeLeka = value; }
        public TextBox TxtJKL { get => txtJKL; set => txtJKL = value; }
        public Label Label9 { get => label9; set => label9 = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
    }
}
