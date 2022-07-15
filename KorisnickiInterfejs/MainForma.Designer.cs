namespace KorisnickiInterfejs
{
    partial class MainForma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unesiLekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogLekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaLekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeLekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porudzbinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovePorudzbineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaPorudzbineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjePorudzbineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiLekToolStripMenuItem,
            this.porudzbinaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // unesiLekToolStripMenuItem
            // 
            this.unesiLekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogLekaToolStripMenuItem,
            this.izmenaLekaToolStripMenuItem,
            this.brisanjeLekaToolStripMenuItem});
            this.unesiLekToolStripMenuItem.Name = "unesiLekToolStripMenuItem";
            this.unesiLekToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.unesiLekToolStripMenuItem.Text = "Lek";
            // 
            // unosNovogLekaToolStripMenuItem
            // 
            this.unosNovogLekaToolStripMenuItem.Name = "unosNovogLekaToolStripMenuItem";
            this.unosNovogLekaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.unosNovogLekaToolStripMenuItem.Text = "Unos novog leka";
            this.unosNovogLekaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogLekaToolStripMenuItem_Click);
            // 
            // izmenaLekaToolStripMenuItem
            // 
            this.izmenaLekaToolStripMenuItem.Name = "izmenaLekaToolStripMenuItem";
            this.izmenaLekaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.izmenaLekaToolStripMenuItem.Text = "Izmena leka";
            this.izmenaLekaToolStripMenuItem.Click += new System.EventHandler(this.izmenaLekaToolStripMenuItem_Click);
            // 
            // brisanjeLekaToolStripMenuItem
            // 
            this.brisanjeLekaToolStripMenuItem.Name = "brisanjeLekaToolStripMenuItem";
            this.brisanjeLekaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.brisanjeLekaToolStripMenuItem.Text = "Obrisi lek";
            this.brisanjeLekaToolStripMenuItem.Click += new System.EventHandler(this.brisanjeLekaToolStripMenuItem_Click);
            // 
            // porudzbinaToolStripMenuItem
            // 
            this.porudzbinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovePorudzbineToolStripMenuItem,
            this.izmenaPorudzbineToolStripMenuItem,
            this.brisanjePorudzbineToolStripMenuItem});
            this.porudzbinaToolStripMenuItem.Name = "porudzbinaToolStripMenuItem";
            this.porudzbinaToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.porudzbinaToolStripMenuItem.Text = "Porudzbina";
            // 
            // unosNovePorudzbineToolStripMenuItem
            // 
            this.unosNovePorudzbineToolStripMenuItem.Name = "unosNovePorudzbineToolStripMenuItem";
            this.unosNovePorudzbineToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.unosNovePorudzbineToolStripMenuItem.Text = "Unos nove porudzbine";
            this.unosNovePorudzbineToolStripMenuItem.Click += new System.EventHandler(this.unosNovePorudzbineToolStripMenuItem_Click);
            // 
            // izmenaPorudzbineToolStripMenuItem
            // 
            this.izmenaPorudzbineToolStripMenuItem.Name = "izmenaPorudzbineToolStripMenuItem";
            this.izmenaPorudzbineToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.izmenaPorudzbineToolStripMenuItem.Text = "Izmena porudzbine";
            this.izmenaPorudzbineToolStripMenuItem.Click += new System.EventHandler(this.izmenaPorudzbineToolStripMenuItem_Click);
            // 
            // brisanjePorudzbineToolStripMenuItem
            // 
            this.brisanjePorudzbineToolStripMenuItem.Name = "brisanjePorudzbineToolStripMenuItem";
            this.brisanjePorudzbineToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.brisanjePorudzbineToolStripMenuItem.Text = "Obrisi porudzbinu";
            this.brisanjePorudzbineToolStripMenuItem.Click += new System.EventHandler(this.brisanjePorudzbineToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(12, 49);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1081, 751);
            this.pnlMain.TabIndex = 1;
            // 
            // MainForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1105, 812);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForma";
            this.Text = "Apoteka";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForma_FormClosed);
            this.Load += new System.EventHandler(this.MainForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unesiLekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogLekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaLekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeLekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porudzbinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovePorudzbineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaPorudzbineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjePorudzbineToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
    }
}

