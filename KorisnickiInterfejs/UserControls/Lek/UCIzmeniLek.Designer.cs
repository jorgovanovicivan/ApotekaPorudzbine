using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls.Lek
{
    partial class UCIzmeniLek
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
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.txtJKL = new System.Windows.Forms.TextBox();
            this.txtImeLeka = new System.Windows.Forms.TextBox();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.txtFOLeka = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.cbProizvodjac = new System.Windows.Forms.ComboBox();
            this.cbTipLeka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtSifraLeka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUcitajLek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(346, 653);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(205, 39);
            this.btnSacuvajIzmene.TabIndex = 0;
            this.btnSacuvajIzmene.Text = "Sacuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            // 
            // txtJKL
            // 
            this.txtJKL.Location = new System.Drawing.Point(413, 356);
            this.txtJKL.Name = "txtJKL";
            this.txtJKL.Size = new System.Drawing.Size(218, 22);
            this.txtJKL.TabIndex = 1;
            // 
            // txtImeLeka
            // 
            this.txtImeLeka.Location = new System.Drawing.Point(413, 392);
            this.txtImeLeka.Name = "txtImeLeka";
            this.txtImeLeka.Size = new System.Drawing.Size(218, 22);
            this.txtImeLeka.TabIndex = 2;
            // 
            // txtINN
            // 
            this.txtINN.Location = new System.Drawing.Point(413, 436);
            this.txtINN.Name = "txtINN";
            this.txtINN.Size = new System.Drawing.Size(218, 22);
            this.txtINN.TabIndex = 3;
            // 
            // txtFOLeka
            // 
            this.txtFOLeka.Location = new System.Drawing.Point(413, 475);
            this.txtFOLeka.Name = "txtFOLeka";
            this.txtFOLeka.Size = new System.Drawing.Size(218, 22);
            this.txtFOLeka.TabIndex = 4;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(413, 517);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(218, 22);
            this.txtCena.TabIndex = 5;
            // 
            // cbProizvodjac
            // 
            this.cbProizvodjac.FormattingEnabled = true;
            this.cbProizvodjac.Location = new System.Drawing.Point(413, 557);
            this.cbProizvodjac.Name = "cbProizvodjac";
            this.cbProizvodjac.Size = new System.Drawing.Size(218, 24);
            this.cbProizvodjac.TabIndex = 6;
            // 
            // cbTipLeka
            // 
            this.cbTipLeka.FormattingEnabled = true;
            this.cbTipLeka.Location = new System.Drawing.Point(413, 605);
            this.cbTipLeka.Name = "cbTipLeka";
            this.cbTipLeka.Size = new System.Drawing.Size(218, 24);
            this.cbTipLeka.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "JKL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ime leka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "INN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "FOLeka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Proizvodjac:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 612);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tip Leka:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 153);
            this.dataGridView1.TabIndex = 16;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(206, 45);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(327, 22);
            this.txtPretraga.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Naziv leka:";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(554, 37);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(148, 33);
            this.btnPretraga.TabIndex = 19;
            this.btnPretraga.Text = "Pretrazi lek";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // txtSifraLeka
            // 
            this.txtSifraLeka.BackColor = System.Drawing.Color.LightGreen;
            this.txtSifraLeka.Location = new System.Drawing.Point(413, 319);
            this.txtSifraLeka.Name = "txtSifraLeka";
            this.txtSifraLeka.ReadOnly = true;
            this.txtSifraLeka.Size = new System.Drawing.Size(218, 22);
            this.txtSifraLeka.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sifra leka:";
            // 
            // btnUcitajLek
            // 
            this.btnUcitajLek.Location = new System.Drawing.Point(796, 110);
            this.btnUcitajLek.Name = "btnUcitajLek";
            this.btnUcitajLek.Size = new System.Drawing.Size(209, 28);
            this.btnUcitajLek.TabIndex = 22;
            this.btnUcitajLek.Text = "Ucitaj podatke o leku";
            this.btnUcitajLek.UseVisualStyleBackColor = true;
            // 
            // UCIzmeniLek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnUcitajLek);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSifraLeka);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipLeka);
            this.Controls.Add(this.cbProizvodjac);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtFOLeka);
            this.Controls.Add(this.txtINN);
            this.Controls.Add(this.txtImeLeka);
            this.Controls.Add(this.txtJKL);
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Name = "UCIzmeniLek";
            this.Size = new System.Drawing.Size(1053, 748);
            this.Load += new System.EventHandler(this.UCIzmeniLek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvajIzmene;
        private System.Windows.Forms.TextBox txtJKL;
        private System.Windows.Forms.TextBox txtImeLeka;
        private System.Windows.Forms.TextBox txtINN;
        private System.Windows.Forms.TextBox txtFOLeka;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.ComboBox cbProizvodjac;
        private System.Windows.Forms.ComboBox cbTipLeka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label2;
        private Button btnPretraga;
        private TextBox txtSifraLeka;
        private Label label9;
        private Button btnUcitajLek;
        public Button BtnUcitajLek { get => btnUcitajLek; set => btnUcitajLek = value; }
        public Button BtnPretraga { get => btnPretraga; set => btnPretraga = value; }
        public Button  BtnSacuvajIzmene { get=>btnSacuvajIzmene; set=> btnSacuvajIzmene=value; }
        public TextBox TxtJKL { get=> txtJKL; set=> txtJKL=value; }  
        public TextBox TxtSifraLeka { get=> txtSifraLeka; set=> txtSifraLeka = value; }
        public TextBox TxtImeLeka { get => txtImeLeka; set => txtImeLeka = value; }
        public TextBox TxtINN { get => txtINN; set => txtINN = value; }
        public TextBox TxtFOLeka { get => txtFOLeka; set => txtFOLeka = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public ComboBox CbProizvodjac { get => cbProizvodjac; set => cbProizvodjac = value; }
        public ComboBox CbTipLeka { get => cbTipLeka; set => cbTipLeka = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Label Label2 { get => label2; set => label2 = value; }

    }
}
