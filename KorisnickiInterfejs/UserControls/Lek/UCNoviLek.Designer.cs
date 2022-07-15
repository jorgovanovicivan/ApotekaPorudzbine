using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls.Lek
{
    partial class UCNoviLek
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
            this.cbTipLeka = new System.Windows.Forms.ComboBox();
            this.btnDodajLek = new System.Windows.Forms.Button();
            this.txtImeLeka = new System.Windows.Forms.TextBox();
            this.txtJKL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFOLeka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProizvodjac = new System.Windows.Forms.ComboBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTipLeka
            // 
            this.cbTipLeka.FormattingEnabled = true;
            this.cbTipLeka.Location = new System.Drawing.Point(402, 314);
            this.cbTipLeka.Name = "cbTipLeka";
            this.cbTipLeka.Size = new System.Drawing.Size(273, 24);
            this.cbTipLeka.TabIndex = 0;
            this.cbTipLeka.SelectedIndexChanged += new System.EventHandler(this.cbTipLeka_SelectedIndexChanged);
            // 
            // btnDodajLek
            // 
            this.btnDodajLek.Location = new System.Drawing.Point(467, 366);
            this.btnDodajLek.Name = "btnDodajLek";
            this.btnDodajLek.Size = new System.Drawing.Size(143, 42);
            this.btnDodajLek.TabIndex = 1;
            this.btnDodajLek.Text = "Dodaj Lek";
            this.btnDodajLek.UseVisualStyleBackColor = true;
            this.btnDodajLek.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImeLeka
            // 
            this.txtImeLeka.Location = new System.Drawing.Point(402, 42);
            this.txtImeLeka.Name = "txtImeLeka";
            this.txtImeLeka.Size = new System.Drawing.Size(273, 22);
            this.txtImeLeka.TabIndex = 2;
            this.txtImeLeka.TextChanged += new System.EventHandler(this.txtImeLeka_TextChanged);
            // 
            // txtJKL
            // 
            this.txtJKL.Location = new System.Drawing.Point(402, 86);
            this.txtJKL.Name = "txtJKL";
            this.txtJKL.Size = new System.Drawing.Size(273, 22);
            this.txtJKL.TabIndex = 3;
            this.txtJKL.TextChanged += new System.EventHandler(this.txtJKL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv leka:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "JKL:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtINN
            // 
            this.txtINN.Location = new System.Drawing.Point(402, 128);
            this.txtINN.Name = "txtINN";
            this.txtINN.Size = new System.Drawing.Size(273, 22);
            this.txtINN.TabIndex = 6;
            this.txtINN.TextChanged += new System.EventHandler(this.txtINN_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "INN:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFOLeka
            // 
            this.txtFOLeka.Location = new System.Drawing.Point(402, 174);
            this.txtFOLeka.Name = "txtFOLeka";
            this.txtFOLeka.Size = new System.Drawing.Size(273, 22);
            this.txtFOLeka.TabIndex = 8;
            this.txtFOLeka.TextChanged += new System.EventHandler(this.txtFOLeka_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "FOLeka:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Proizvodjac:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbProizvodjac
            // 
            this.cbProizvodjac.FormattingEnabled = true;
            this.cbProizvodjac.Location = new System.Drawing.Point(402, 265);
            this.cbProizvodjac.Name = "cbProizvodjac";
            this.cbProizvodjac.Size = new System.Drawing.Size(273, 24);
            this.cbProizvodjac.TabIndex = 11;
            this.cbProizvodjac.SelectedIndexChanged += new System.EventHandler(this.cbProizvodjac_SelectedIndexChanged);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(402, 216);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(273, 22);
            this.txtCena.TabIndex = 12;
            this.txtCena.TextChanged += new System.EventHandler(this.txtCena_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cena:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tip Leka:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // UCNoviLek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.cbProizvodjac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFOLeka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtINN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJKL);
            this.Controls.Add(this.txtImeLeka);
            this.Controls.Add(this.btnDodajLek);
            this.Controls.Add(this.cbTipLeka);
            this.Name = "UCNoviLek";
            this.Size = new System.Drawing.Size(997, 565);
            this.Load += new System.EventHandler(this.UCNoviLek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipLeka;
        private Button btnDodajLek;
        private TextBox txtImeLeka;
        private TextBox txtJKL;
        private Label label1;
        private Label label2;
        private TextBox txtINN;
        private Label label3;
        private TextBox txtFOLeka;
        private Label label4;
        private Label label5;
        private ComboBox cbProizvodjac;
        private TextBox txtCena;
        private Label label6;
        private Label label7;

        public ComboBox CbTipLeka { get=>cbTipLeka; set=>cbTipLeka=value; }
        public ComboBox CbProizvodjac { get=>cbProizvodjac; set=>cbProizvodjac=value; }
        public TextBox TxtImeLeka { get=>txtImeLeka; set=>txtImeLeka=value; }
        public TextBox TxtJKL { get=>txtJKL; set=> txtJKL = value; }
        public TextBox TxtINN { get=>txtINN; set=> txtINN = value; }
        public TextBox TxtFOLeka { get=>txtFOLeka; set=> txtFOLeka = value; }
        public TextBox TxtCena { get=>txtCena; set=> txtCena = value; }
        public Button BtnDOdajLek { get=>btnDodajLek; set=>btnDodajLek=value; }

    }
}
