using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls.Porudzbina
{
    partial class UCObrisiPorudzbinu
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvPorudzbine = new System.Windows.Forms.DataGridView();
            this.btnUcitajPorudzbinu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApotekar = new System.Windows.Forms.TextBox();
            this.txtCenaUkupno = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtPorudzbinaID = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorudzbine)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(56, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 17);
            this.label14.TabIndex = 46;
            this.label14.Text = " PORUDZBINE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "STAVKE PORUDZBINE";
            // 
            // dgvStavke
            // 
            this.dgvStavke.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(59, 357);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(898, 94);
            this.dgvStavke.TabIndex = 44;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(620, 24);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(127, 31);
            this.btnPretraga.TabIndex = 43;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Pretraga po dobavljaču:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(342, 31);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(237, 22);
            this.txtPretraga.TabIndex = 41;
            // 
            // dgvPorudzbine
            // 
            this.dgvPorudzbine.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPorudzbine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorudzbine.Location = new System.Drawing.Point(59, 145);
            this.dgvPorudzbine.Name = "dgvPorudzbine";
            this.dgvPorudzbine.RowHeadersWidth = 51;
            this.dgvPorudzbine.RowTemplate.Height = 24;
            this.dgvPorudzbine.Size = new System.Drawing.Size(898, 151);
            this.dgvPorudzbine.TabIndex = 26;
            // 
            // btnUcitajPorudzbinu
            // 
            this.btnUcitajPorudzbinu.Location = new System.Drawing.Point(761, 106);
            this.btnUcitajPorudzbinu.Name = "btnUcitajPorudzbinu";
            this.btnUcitajPorudzbinu.Size = new System.Drawing.Size(196, 32);
            this.btnUcitajPorudzbinu.TabIndex = 49;
            this.btnUcitajPorudzbinu.Text = "Ucitaj Porudzbinu";
            this.btnUcitajPorudzbinu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Datum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Cena ukupno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Apotekar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Dobavljac:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Porudzbina ID:";
            // 
            // txtApotekar
            // 
            this.txtApotekar.BackColor = System.Drawing.Color.LightGreen;
            this.txtApotekar.Location = new System.Drawing.Point(423, 601);
            this.txtApotekar.Name = "txtApotekar";
            this.txtApotekar.ReadOnly = true;
            this.txtApotekar.Size = new System.Drawing.Size(237, 22);
            this.txtApotekar.TabIndex = 54;
            // 
            // txtCenaUkupno
            // 
            this.txtCenaUkupno.BackColor = System.Drawing.Color.LightGreen;
            this.txtCenaUkupno.Location = new System.Drawing.Point(423, 535);
            this.txtCenaUkupno.Name = "txtCenaUkupno";
            this.txtCenaUkupno.ReadOnly = true;
            this.txtCenaUkupno.Size = new System.Drawing.Size(237, 22);
            this.txtCenaUkupno.TabIndex = 53;
            // 
            // txtDatum
            // 
            this.txtDatum.BackColor = System.Drawing.Color.LightGreen;
            this.txtDatum.Location = new System.Drawing.Point(423, 503);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(237, 22);
            this.txtDatum.TabIndex = 52;
            // 
            // txtPorudzbinaID
            // 
            this.txtPorudzbinaID.BackColor = System.Drawing.Color.LightGreen;
            this.txtPorudzbinaID.Location = new System.Drawing.Point(423, 472);
            this.txtPorudzbinaID.Name = "txtPorudzbinaID";
            this.txtPorudzbinaID.ReadOnly = true;
            this.txtPorudzbinaID.Size = new System.Drawing.Size(237, 22);
            this.txtPorudzbinaID.TabIndex = 51;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(465, 685);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(149, 40);
            this.btnObrisi.TabIndex = 50;
            this.btnObrisi.Text = "OBRISI";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.BackColor = System.Drawing.Color.LightGreen;
            this.txtDobavljac.Location = new System.Drawing.Point(423, 639);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.ReadOnly = true;
            this.txtDobavljac.Size = new System.Drawing.Size(237, 22);
            this.txtDobavljac.TabIndex = 63;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.LightGreen;
            this.txtStatus.Location = new System.Drawing.Point(423, 566);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(237, 22);
            this.txtStatus.TabIndex = 64;
            // 
            // UCObrisiPorudzbinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApotekar);
            this.Controls.Add(this.txtCenaUkupno);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtPorudzbinaID);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUcitajPorudzbinu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvPorudzbine);
            this.Name = "UCObrisiPorudzbinu";
            this.Size = new System.Drawing.Size(1003, 750);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorudzbine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvPorudzbine;
        private Button btnUcitajPorudzbinu;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtApotekar;
        private TextBox txtCenaUkupno;
        private TextBox txtDatum;
        private TextBox txtPorudzbinaID;
        private Button btnObrisi;
        private TextBox txtDobavljac;
        private TextBox txtStatus;

        public Button BtnUcitajPorudzbinu { get => btnUcitajPorudzbinu; set => btnUcitajPorudzbinu = value; }
        public Label Label14 { get => label14; set => label14 = value; }
        public Label Label13 { get => label13; set => label13 = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public Button BtnPretraga { get => btnPretraga; set => btnPretraga = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public TextBox TxtStatus { get => txtStatus; set => txtStatus = value; }

        //public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        //public Label Label12 { get => label12; set => label12 = value; }
        //public Label Label11 { get => label11; set => label11 = value; }
        //public Label Label10 { get => label10; set => label10 = value; }
        //public Label Label9 { get => label9; set => label9 = value; }
        //public Label Label8 { get => label8; set => label8 = value; }
        //public ComboBox CbLekovi { get => cbLekovi; set => cbLekovi = value; }
        //public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        //public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        //public TextBox TxtRb { get => txtRb; set => txtRb = value; }
        //public TextBox TxtPorudzbinaNaziv { get => txtPorudzbinaNaziv; set => txtPorudzbinaNaziv = value; }
        //public ComboBox CbDobavljac { get => cbDobavljac; set => cbDobavljac = value; }
        //public Label Label6 { get => label6; set => label6 = value; }
        //public Label Label5 { get => label5; set => label5 = value; }
        //public Label Label4 { get => label4; set => label4 = value; }
        //public Label Label3 { get => label3; set => label3 = value; }
        //public Label Label2 { get => label2; set => label2 = value; }
        //public Label Label1 { get => label1; set => label1 = value; }
        //public RadioButton RbNe { get => rbNe; set => rbNe = value; }
        //public RadioButton RbDa { get => rbDa; set => rbDa = value; }
        //public TextBox TxtApotekar { get => txtApotekar; set => txtApotekar = value; }
        //public TextBox TxtCenaUkupno { get => txtCenaUkupno; set => txtCenaUkupno = value; }
        //public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        //public TextBox TxtPorudzbinaID { get => txtPorudzbinaID; set => txtPorudzbinaID = value; }
        public DataGridView DgvPorudzbine { get => dgvPorudzbine; set => dgvPorudzbine = value; }
        public Button BtnObrisi{ get => btnObrisi; set => btnObrisi = value; }
        public TextBox TxtApotekar { get => txtApotekar; set => txtApotekar = value; }
        public TextBox TxtCenaUkupno { get => txtCenaUkupno; set => txtCenaUkupno = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        public TextBox TxtPorudzbinaID { get => txtPorudzbinaID; set => txtPorudzbinaID = value; }
        public TextBox TxtDobavljac { get => txtDobavljac; set => txtDobavljac = value; }
    }
}
