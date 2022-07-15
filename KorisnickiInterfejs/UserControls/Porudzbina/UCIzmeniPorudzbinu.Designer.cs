using System.ComponentModel;
using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls.Porudzbina
{
    partial class UCIzmeniPorudzbinu
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
            this.dgvPorudzbine = new System.Windows.Forms.DataGridView();
            this.txtPorudzbinaID = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtCenaUkupno = new System.Windows.Forms.TextBox();
            this.txtApotekar = new System.Windows.Forms.TextBox();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLekovi = new System.Windows.Forms.ComboBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtRb = new System.Windows.Forms.TextBox();
            this.txtPorudzbinaNaziv = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUcitajStavku = new System.Windows.Forms.Button();
            this.btnIzmeniStavku = new System.Windows.Forms.Button();
            this.btnUcitajPorudzbinu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorudzbine)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(157, 656);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(149, 40);
            this.btnSacuvajIzmene.TabIndex = 0;
            this.btnSacuvajIzmene.Text = "Sacuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            // 
            // dgvPorudzbine
            // 
            this.dgvPorudzbine.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPorudzbine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorudzbine.Location = new System.Drawing.Point(53, 104);
            this.dgvPorudzbine.Name = "dgvPorudzbine";
            this.dgvPorudzbine.RowHeadersWidth = 51;
            this.dgvPorudzbine.RowTemplate.Height = 24;
            this.dgvPorudzbine.Size = new System.Drawing.Size(893, 157);
            this.dgvPorudzbine.TabIndex = 1;
            // 
            // txtPorudzbinaID
            // 
            this.txtPorudzbinaID.BackColor = System.Drawing.Color.LightGreen;
            this.txtPorudzbinaID.Location = new System.Drawing.Point(182, 446);
            this.txtPorudzbinaID.Name = "txtPorudzbinaID";
            this.txtPorudzbinaID.ReadOnly = true;
            this.txtPorudzbinaID.Size = new System.Drawing.Size(237, 22);
            this.txtPorudzbinaID.TabIndex = 2;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(182, 477);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(237, 22);
            this.txtDatum.TabIndex = 3;
            // 
            // txtCenaUkupno
            // 
            this.txtCenaUkupno.BackColor = System.Drawing.Color.LightGreen;
            this.txtCenaUkupno.Location = new System.Drawing.Point(182, 509);
            this.txtCenaUkupno.Name = "txtCenaUkupno";
            this.txtCenaUkupno.ReadOnly = true;
            this.txtCenaUkupno.Size = new System.Drawing.Size(237, 22);
            this.txtCenaUkupno.TabIndex = 4;
            // 
            // txtApotekar
            // 
            this.txtApotekar.BackColor = System.Drawing.Color.LightGreen;
            this.txtApotekar.Location = new System.Drawing.Point(182, 575);
            this.txtApotekar.Name = "txtApotekar";
            this.txtApotekar.ReadOnly = true;
            this.txtApotekar.Size = new System.Drawing.Size(237, 22);
            this.txtApotekar.TabIndex = 5;
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(182, 538);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(47, 21);
            this.rbDa.TabIndex = 6;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "Da";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // rbNe
            // 
            this.rbNe.AutoSize = true;
            this.rbNe.Location = new System.Drawing.Point(299, 540);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(47, 21);
            this.rbNe.TabIndex = 7;
            this.rbNe.TabStop = true;
            this.rbNe.Text = "Ne";
            this.rbNe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Porudzbina ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dobavljac:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apotekar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hitno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cena ukupno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datum:";
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(182, 610);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(237, 24);
            this.cbDobavljac.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbLekovi);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.txtRb);
            this.groupBox1.Controls.Add(this.txtPorudzbinaNaziv);
            this.groupBox1.Location = new System.Drawing.Point(564, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 260);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavka porudzbine";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Lek:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cena:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Kolicina:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "RB:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Porudzbina ID:";
            // 
            // cbLekovi
            // 
            this.cbLekovi.FormattingEnabled = true;
            this.cbLekovi.Location = new System.Drawing.Point(133, 184);
            this.cbLekovi.Name = "cbLekovi";
            this.cbLekovi.Size = new System.Drawing.Size(237, 24);
            this.cbLekovi.TabIndex = 19;
            // 
            // txtCena
            // 
            this.txtCena.BackColor = System.Drawing.Color.LightGreen;
            this.txtCena.Location = new System.Drawing.Point(133, 147);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(237, 22);
            this.txtCena.TabIndex = 22;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(133, 110);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(237, 22);
            this.txtKolicina.TabIndex = 21;
            // 
            // txtRb
            // 
            this.txtRb.BackColor = System.Drawing.Color.LightGreen;
            this.txtRb.Location = new System.Drawing.Point(133, 71);
            this.txtRb.Name = "txtRb";
            this.txtRb.ReadOnly = true;
            this.txtRb.Size = new System.Drawing.Size(237, 22);
            this.txtRb.TabIndex = 20;
            // 
            // txtPorudzbinaNaziv
            // 
            this.txtPorudzbinaNaziv.BackColor = System.Drawing.Color.LightGreen;
            this.txtPorudzbinaNaziv.Location = new System.Drawing.Point(133, 26);
            this.txtPorudzbinaNaziv.Name = "txtPorudzbinaNaziv";
            this.txtPorudzbinaNaziv.ReadOnly = true;
            this.txtPorudzbinaNaziv.Size = new System.Drawing.Size(237, 22);
            this.txtPorudzbinaNaziv.TabIndex = 19;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(299, 13);
            this.txtPretraga.Multiline = true;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(237, 31);
            this.txtPretraga.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pretraga po datumu:";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(573, 13);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(127, 31);
            this.btnPretraga.TabIndex = 18;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(893, 107);
            this.dataGridView1.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(51, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "STAVKE PORUDZBINE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(51, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = " PORUDZBINE";
            // 
            // btnUcitajStavku
            // 
            this.btnUcitajStavku.Location = new System.Drawing.Point(608, 267);
            this.btnUcitajStavku.Name = "btnUcitajStavku";
            this.btnUcitajStavku.Size = new System.Drawing.Size(130, 31);
            this.btnUcitajStavku.TabIndex = 22;
            this.btnUcitajStavku.Text = "Ucitaj stavke";
            this.btnUcitajStavku.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniStavku
            // 
            this.btnIzmeniStavku.Location = new System.Drawing.Point(816, 267);
            this.btnIzmeniStavku.Name = "btnIzmeniStavku";
            this.btnIzmeniStavku.Size = new System.Drawing.Size(130, 31);
            this.btnIzmeniStavku.TabIndex = 23;
            this.btnIzmeniStavku.Text = "Izmeni";
            this.btnIzmeniStavku.UseVisualStyleBackColor = true;
            // 
            // btnUcitajPorudzbinu
            // 
            this.btnUcitajPorudzbinu.Location = new System.Drawing.Point(816, 67);
            this.btnUcitajPorudzbinu.Name = "btnUcitajPorudzbinu";
            this.btnUcitajPorudzbinu.Size = new System.Drawing.Size(130, 31);
            this.btnUcitajPorudzbinu.TabIndex = 24;
            this.btnUcitajPorudzbinu.Text = "Ucitaj porudzbinu";
            this.btnUcitajPorudzbinu.UseVisualStyleBackColor = true;
            // 
            // UCIzmeniPorudzbinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnUcitajPorudzbinu);
            this.Controls.Add(this.btnIzmeniStavku);
            this.Controls.Add(this.btnUcitajStavku);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbNe);
            this.Controls.Add(this.rbDa);
            this.Controls.Add(this.txtApotekar);
            this.Controls.Add(this.txtCenaUkupno);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtPorudzbinaID);
            this.Controls.Add(this.dgvPorudzbine);
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Name = "UCIzmeniPorudzbinu";
            this.Size = new System.Drawing.Size(1006, 750);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorudzbine)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvajIzmene;
        private System.Windows.Forms.DataGridView dgvPorudzbine;
        private System.Windows.Forms.TextBox txtPorudzbinaID;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtCenaUkupno;
        private System.Windows.Forms.TextBox txtApotekar;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLekovi;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtRb;
        private System.Windows.Forms.TextBox txtPorudzbinaNaziv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPretraga;
        private DataGridView dataGridView1;
        private Label label13;
        private Label label14;
        private Button btnUcitajStavku;
        private Button btnIzmeniStavku;
        private Button btnUcitajPorudzbinu;

        public Button BtnUcitajPorudbinu { get => btnUcitajPorudzbinu; set => btnUcitajPorudzbinu = value; }
        public Button BtnSacuvajIzmene { get => btnSacuvajIzmene; set => btnSacuvajIzmene = value; }
        public Button BtnUcitajStavku { get => btnUcitajStavku; set => btnUcitajStavku = value; }
        public DataGridView DgvPorudzbine { get => dgvPorudzbine; set => dgvPorudzbine = value; }
        public DataGridView DgvStavkaPorudzbine { get => dataGridView1; set => dataGridView1 = value; }
        public TextBox TxtPorudzbinaID { get => txtPorudzbinaID; set => txtPorudzbinaID = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        public TextBox TxtCenaUkupno { get => txtCenaUkupno; set => txtCenaUkupno = value; }
        public TextBox TxtApotekar { get => txtApotekar; set => txtApotekar = value; }
        public RadioButton RbDa { get => rbDa; set => rbDa = value; }
        public RadioButton RbNe { get => rbNe; set => rbNe = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public ComboBox CbDobavljac { get => cbDobavljac; set => cbDobavljac = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Label Label12 { get => label12; set => label12 = value; }
        public Label Label11 { get => label11; set => label11 = value; }
        public Label Label10 { get => label10; set => label10 = value; }
        public Label Label9 { get => label9; set => label9 = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public ComboBox CbLekovi { get => cbLekovi; set => cbLekovi = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        public TextBox TxtRb { get => txtRb; set => txtRb = value; }
        public TextBox TxtPorudzbinaNaziv { get => txtPorudzbinaNaziv; set => txtPorudzbinaNaziv = value; }
        public BackgroundWorker BackgroundWorker1 { get => backgroundWorker1; set => backgroundWorker1 = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Button BtnPretraga { get => btnPretraga; set => btnPretraga = value; }
        public Button BtnIzmeniStavku { get => btnIzmeniStavku; set => btnIzmeniStavku = value; }
    }
}
