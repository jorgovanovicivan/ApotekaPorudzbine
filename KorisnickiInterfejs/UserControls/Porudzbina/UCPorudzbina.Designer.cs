using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    partial class UCPorudzbina
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
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtCenaUkupno = new System.Windows.Forms.TextBox();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVratiLekove = new System.Windows.Forms.ComboBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSacuvajPorudzbinu = new System.Windows.Forms.Button();
            this.btnObrisiRed = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(260, 180);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(274, 24);
            this.cbDobavljac.TabIndex = 0;
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatum.Location = new System.Drawing.Point(260, 40);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(274, 22);
            this.txtDatum.TabIndex = 1;
            // 
            // txtCenaUkupno
            // 
            this.txtCenaUkupno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCenaUkupno.BackColor = System.Drawing.Color.LightGreen;
            this.txtCenaUkupno.Location = new System.Drawing.Point(260, 88);
            this.txtCenaUkupno.Name = "txtCenaUkupno";
            this.txtCenaUkupno.ReadOnly = true;
            this.txtCenaUkupno.Size = new System.Drawing.Size(274, 22);
            this.txtCenaUkupno.TabIndex = 2;
            // 
            // rbDa
            // 
            this.rbDa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(278, 137);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(47, 21);
            this.rbDa.TabIndex = 3;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "Da";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // rbNe
            // 
            this.rbNe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNe.AutoSize = true;
            this.rbNe.Location = new System.Drawing.Point(406, 137);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(47, 21);
            this.rbNe.TabIndex = 4;
            this.rbNe.TabStop = true;
            this.rbNe.Text = "Ne";
            this.rbNe.UseVisualStyleBackColor = true;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajStavku.Location = new System.Drawing.Point(179, 182);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(124, 30);
            this.btnDodajStavku.TabIndex = 5;
            this.btnDodajStavku.Text = "Dodaj Stavku Porudzvine";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cena ukupno:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hitno:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dobavljac:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbVratiLekove);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.btnDodajStavku);
            this.groupBox1.Location = new System.Drawing.Point(150, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 236);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavka porudzbine";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lek:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kolicina:";
            // 
            // cbVratiLekove
            // 
            this.cbVratiLekove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVratiLekove.FormattingEnabled = true;
            this.cbVratiLekove.Location = new System.Drawing.Point(110, 123);
            this.cbVratiLekove.Name = "cbVratiLekove";
            this.cbVratiLekove.Size = new System.Drawing.Size(274, 24);
            this.cbVratiLekove.TabIndex = 11;
            // 
            // txtCena
            // 
            this.txtCena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCena.BackColor = System.Drawing.Color.LightGreen;
            this.txtCena.Location = new System.Drawing.Point(110, 79);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(274, 22);
            this.txtCena.TabIndex = 12;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKolicina.Location = new System.Drawing.Point(110, 37);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(274, 22);
            this.txtKolicina.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 533);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 134);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnSacuvajPorudzbinu
            // 
            this.btnSacuvajPorudzbinu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajPorudzbinu.Location = new System.Drawing.Point(310, 692);
            this.btnSacuvajPorudzbinu.Name = "btnSacuvajPorudzbinu";
            this.btnSacuvajPorudzbinu.Size = new System.Drawing.Size(160, 42);
            this.btnSacuvajPorudzbinu.TabIndex = 13;
            this.btnSacuvajPorudzbinu.Text = "Sacuvaj Porudzbinu";
            this.btnSacuvajPorudzbinu.UseVisualStyleBackColor = true;
            // 
            // btnObrisiRed
            // 
            this.btnObrisiRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiRed.Location = new System.Drawing.Point(637, 494);
            this.btnObrisiRed.Name = "btnObrisiRed";
            this.btnObrisiRed.Size = new System.Drawing.Size(135, 33);
            this.btnObrisiRed.TabIndex = 13;
            this.btnObrisiRed.Text = "Obrisi red";
            this.btnObrisiRed.UseVisualStyleBackColor = true;
            // 
            // UCPorudzbina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnObrisiRed);
            this.Controls.Add(this.btnSacuvajPorudzbinu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbNe);
            this.Controls.Add(this.rbDa);
            this.Controls.Add(this.txtCenaUkupno);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.cbDobavljac);
            this.Name = "UCPorudzbina";
            this.Size = new System.Drawing.Size(818, 767);
            this.Load += new System.EventHandler(this.UCPorudzbina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtCenaUkupno;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GroupBox groupBox1;
        private TextBox txtKolicina;
        private ComboBox cbVratiLekove;
        private TextBox txtCena;
        private DataGridView dataGridView1;
        private Button btnSacuvajPorudzbinu;
        private Button btnObrisiRed;
        private Label label7;
        private Label label6;
        private Label label5;

        public ComboBox CbDovavljac { get=>cbDobavljac; set=> cbDobavljac=value; }
        public TextBox TxtDatum { get=>txtDatum; set=> txtDatum = value; } 
        public TextBox TxtKolicina { get=>txtKolicina; set=> txtKolicina = value; }
        public TextBox TxtCenaUkupno { get=>txtCenaUkupno; set=> txtCenaUkupno = value; }
        public TextBox TxtCena { get=>txtCena; set=> txtCena = value; }
        public RadioButton RbDa { get=>rbDa; set=> rbDa = value; }
        public RadioButton RbNe { get=>rbNe; set=> rbNe = value; }
        public Button BtnDodaj { get=>btnDodajStavku; set=> btnDodajStavku = value; }
        public Button BtnObrisiRed { get=>btnObrisiRed; set=> btnObrisiRed = value; }
        public Button BtnSacuvajPorudzbinu { get=>btnSacuvajPorudzbinu; set=> btnSacuvajPorudzbinu = value; }
        public DataGridView DgvListaStavki { get => dataGridView1; set => dataGridView1 = value; }
        public ComboBox CbListaLekova { get => cbVratiLekove; set => cbVratiLekove = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
    }
}
