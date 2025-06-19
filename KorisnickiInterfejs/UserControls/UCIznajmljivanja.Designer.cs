using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCIznajmljivanja
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
            this.dgvIznajmljivanja = new System.Windows.Forms.DataGridView();
            this.panelIznajmljivanja = new System.Windows.Forms.Panel();
            this.btnKreirajIznajmljivanje = new System.Windows.Forms.Button();
            this.lblIznajmljivanja = new System.Windows.Forms.Label();
            this.lblStavke = new System.Windows.Forms.Label();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.panelStavke = new System.Windows.Forms.Panel();
            this.panelIznajmljivanjaControls = new System.Windows.Forms.Panel();
            this.lblAutomat = new System.Windows.Forms.Label();
            this.cmbAutomati = new System.Windows.Forms.ComboBox();
            this.lblPoslovni = new System.Windows.Forms.Label();
            this.cmbPoslovniPartner = new System.Windows.Forms.ComboBox();
            this.btnObrisiIznajmljivanje = new System.Windows.Forms.Button();
            this.btnPretraziIznajmljivanje = new System.Windows.Forms.Button();
            this.btnPromeniIznajmljivanje = new System.Windows.Forms.Button();
            this.btnUbaciIznajmljivanje = new System.Windows.Forms.Button();
            this.dtpPovratka = new System.Windows.Forms.DateTimePicker();
            this.lblDatumPovratka = new System.Windows.Forms.Label();
            this.lblDatumIznajmljivanja = new System.Windows.Forms.Label();
            this.dtpIznajmljivanja = new System.Windows.Forms.DateTimePicker();
            this.panelStavkeControls = new System.Windows.Forms.Panel();
            this.btnObrisiStavka = new System.Windows.Forms.Button();
            this.btnUbaciStavka = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.cmbBicikla = new System.Windows.Forms.ComboBox();
            this.lblBicikla = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIznajmljivanja)).BeginInit();
            this.panelIznajmljivanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.panelStavke.SuspendLayout();
            this.panelIznajmljivanjaControls.SuspendLayout();
            this.panelStavkeControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIznajmljivanja
            // 
            this.dgvIznajmljivanja.AllowUserToAddRows = false;
            this.dgvIznajmljivanja.AllowUserToDeleteRows = false;
            this.dgvIznajmljivanja.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvIznajmljivanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIznajmljivanja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIznajmljivanja.Location = new System.Drawing.Point(20, 50);
            this.dgvIznajmljivanja.Name = "dgvIznajmljivanja";
            this.dgvIznajmljivanja.ReadOnly = true;
            this.dgvIznajmljivanja.Size = new System.Drawing.Size(320, 130);
            this.dgvIznajmljivanja.TabIndex = 0;
            this.dgvIznajmljivanja.SelectionChanged += new System.EventHandler(this.dgvIznajmljivanja_SelectionChanged);
            // 
            // panelIznajmljivanja
            // 
            this.panelIznajmljivanja.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelIznajmljivanja.BackColor = System.Drawing.Color.White;
            this.panelIznajmljivanja.Controls.Add(this.btnKreirajIznajmljivanje);
            this.panelIznajmljivanja.Controls.Add(this.lblIznajmljivanja);
            this.panelIznajmljivanja.Controls.Add(this.dgvIznajmljivanja);
            this.panelIznajmljivanja.Location = new System.Drawing.Point(15, 15);
            this.panelIznajmljivanja.Name = "panelIznajmljivanja";
            this.panelIznajmljivanja.Padding = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.panelIznajmljivanja.Size = new System.Drawing.Size(360, 200);
            this.panelIznajmljivanja.TabIndex = 4;
            // 
            // btnKreirajIznajmljivanje
            // 
            this.btnKreirajIznajmljivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKreirajIznajmljivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnKreirajIznajmljivanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKreirajIznajmljivanje.FlatAppearance.BorderSize = 0;
            this.btnKreirajIznajmljivanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnKreirajIznajmljivanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnKreirajIznajmljivanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajIznajmljivanje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajIznajmljivanje.ForeColor = System.Drawing.Color.White;
            this.btnKreirajIznajmljivanje.Location = new System.Drawing.Point(269, 14);
            this.btnKreirajIznajmljivanje.Name = "btnKreirajIznajmljivanje";
            this.btnKreirajIznajmljivanje.Size = new System.Drawing.Size(71, 22);
            this.btnKreirajIznajmljivanje.TabIndex = 44;
            this.btnKreirajIznajmljivanje.Text = "Kreiraj";
            this.btnKreirajIznajmljivanje.UseVisualStyleBackColor = false;
            this.btnKreirajIznajmljivanje.Click += new System.EventHandler(this.btnKreirajIznajmljivanje_Click);
            // 
            // lblIznajmljivanja
            // 
            this.lblIznajmljivanja.AutoSize = true;
            this.lblIznajmljivanja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIznajmljivanja.Location = new System.Drawing.Point(16, 14);
            this.lblIznajmljivanja.Name = "lblIznajmljivanja";
            this.lblIznajmljivanja.Size = new System.Drawing.Size(133, 22);
            this.lblIznajmljivanja.TabIndex = 30;
            this.lblIznajmljivanja.Text = "Iznajmljivanja";
            // 
            // lblStavke
            // 
            this.lblStavke.AutoSize = true;
            this.lblStavke.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStavke.Location = new System.Drawing.Point(16, 14);
            this.lblStavke.Name = "lblStavke";
            this.lblStavke.Size = new System.Drawing.Size(73, 22);
            this.lblStavke.TabIndex = 30;
            this.lblStavke.Text = "Stavke";
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AllowUserToDeleteRows = false;
            this.dgvStavke.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStavke.Location = new System.Drawing.Point(20, 50);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.Size = new System.Drawing.Size(245, 170);
            this.dgvStavke.TabIndex = 0;
            this.dgvStavke.SelectionChanged += new System.EventHandler(this.dgvStavke_SelectionChanged);
            // 
            // panelStavke
            // 
            this.panelStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelStavke.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelStavke.BackColor = System.Drawing.Color.White;
            this.panelStavke.Controls.Add(this.lblStavke);
            this.panelStavke.Controls.Add(this.dgvStavke);
            this.panelStavke.Location = new System.Drawing.Point(395, 15);
            this.panelStavke.Name = "panelStavke";
            this.panelStavke.Padding = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.panelStavke.Size = new System.Drawing.Size(285, 240);
            this.panelStavke.TabIndex = 5;
            // 
            // panelIznajmljivanjaControls
            // 
            this.panelIznajmljivanjaControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelIznajmljivanjaControls.BackColor = System.Drawing.Color.White;
            this.panelIznajmljivanjaControls.Controls.Add(this.lblAutomat);
            this.panelIznajmljivanjaControls.Controls.Add(this.cmbAutomati);
            this.panelIznajmljivanjaControls.Controls.Add(this.lblPoslovni);
            this.panelIznajmljivanjaControls.Controls.Add(this.cmbPoslovniPartner);
            this.panelIznajmljivanjaControls.Controls.Add(this.btnObrisiIznajmljivanje);
            this.panelIznajmljivanjaControls.Controls.Add(this.btnPretraziIznajmljivanje);
            this.panelIznajmljivanjaControls.Controls.Add(this.btnPromeniIznajmljivanje);
            this.panelIznajmljivanjaControls.Controls.Add(this.btnUbaciIznajmljivanje);
            this.panelIznajmljivanjaControls.Controls.Add(this.dtpPovratka);
            this.panelIznajmljivanjaControls.Controls.Add(this.lblDatumPovratka);
            this.panelIznajmljivanjaControls.Controls.Add(this.lblDatumIznajmljivanja);
            this.panelIznajmljivanjaControls.Controls.Add(this.dtpIznajmljivanja);
            this.panelIznajmljivanjaControls.Location = new System.Drawing.Point(15, 235);
            this.panelIznajmljivanjaControls.Name = "panelIznajmljivanjaControls";
            this.panelIznajmljivanjaControls.Size = new System.Drawing.Size(360, 200);
            this.panelIznajmljivanjaControls.TabIndex = 6;
            // 
            // lblAutomat
            // 
            this.lblAutomat.AutoSize = true;
            this.lblAutomat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutomat.Location = new System.Drawing.Point(9, 127);
            this.lblAutomat.Name = "lblAutomat";
            this.lblAutomat.Size = new System.Drawing.Size(64, 16);
            this.lblAutomat.TabIndex = 56;
            this.lblAutomat.Text = "Automat: ";
            // 
            // cmbAutomati
            // 
            this.cmbAutomati.FormattingEnabled = true;
            this.cmbAutomati.Location = new System.Drawing.Point(147, 126);
            this.cmbAutomati.Name = "cmbAutomati";
            this.cmbAutomati.Size = new System.Drawing.Size(196, 21);
            this.cmbAutomati.TabIndex = 55;
            // 
            // lblPoslovni
            // 
            this.lblPoslovni.AutoSize = true;
            this.lblPoslovni.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoslovni.Location = new System.Drawing.Point(9, 89);
            this.lblPoslovni.Name = "lblPoslovni";
            this.lblPoslovni.Size = new System.Drawing.Size(104, 16);
            this.lblPoslovni.TabIndex = 54;
            this.lblPoslovni.Text = "Poslovni partner:";
            // 
            // cmbPoslovniPartner
            // 
            this.cmbPoslovniPartner.FormattingEnabled = true;
            this.cmbPoslovniPartner.Location = new System.Drawing.Point(147, 88);
            this.cmbPoslovniPartner.Name = "cmbPoslovniPartner";
            this.cmbPoslovniPartner.Size = new System.Drawing.Size(196, 21);
            this.cmbPoslovniPartner.TabIndex = 53;
            // 
            // btnObrisiIznajmljivanje
            // 
            this.btnObrisiIznajmljivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiIznajmljivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnObrisiIznajmljivanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiIznajmljivanje.FlatAppearance.BorderSize = 0;
            this.btnObrisiIznajmljivanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnObrisiIznajmljivanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnObrisiIznajmljivanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiIznajmljivanje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiIznajmljivanje.ForeColor = System.Drawing.Color.White;
            this.btnObrisiIznajmljivanje.Location = new System.Drawing.Point(274, 162);
            this.btnObrisiIznajmljivanje.Name = "btnObrisiIznajmljivanje";
            this.btnObrisiIznajmljivanje.Size = new System.Drawing.Size(70, 25);
            this.btnObrisiIznajmljivanje.TabIndex = 52;
            this.btnObrisiIznajmljivanje.Text = "Obrisi";
            this.btnObrisiIznajmljivanje.UseVisualStyleBackColor = false;
            this.btnObrisiIznajmljivanje.Click += new System.EventHandler(this.btnObrisiIznajmljivanje_Click);
            // 
            // btnPretraziIznajmljivanje
            // 
            this.btnPretraziIznajmljivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPretraziIznajmljivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnPretraziIznajmljivanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretraziIznajmljivanje.FlatAppearance.BorderSize = 0;
            this.btnPretraziIznajmljivanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPretraziIznajmljivanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPretraziIznajmljivanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraziIznajmljivanje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziIznajmljivanje.ForeColor = System.Drawing.Color.White;
            this.btnPretraziIznajmljivanje.Location = new System.Drawing.Point(188, 162);
            this.btnPretraziIznajmljivanje.Name = "btnPretraziIznajmljivanje";
            this.btnPretraziIznajmljivanje.Size = new System.Drawing.Size(70, 25);
            this.btnPretraziIznajmljivanje.TabIndex = 51;
            this.btnPretraziIznajmljivanje.Text = "Pretrazi";
            this.btnPretraziIznajmljivanje.UseVisualStyleBackColor = false;
            this.btnPretraziIznajmljivanje.Click += new System.EventHandler(this.btnPretraziIznajmljivanje_Click);
            // 
            // btnPromeniIznajmljivanje
            // 
            this.btnPromeniIznajmljivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPromeniIznajmljivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnPromeniIznajmljivanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromeniIznajmljivanje.FlatAppearance.BorderSize = 0;
            this.btnPromeniIznajmljivanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPromeniIznajmljivanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPromeniIznajmljivanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromeniIznajmljivanje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromeniIznajmljivanje.ForeColor = System.Drawing.Color.White;
            this.btnPromeniIznajmljivanje.Location = new System.Drawing.Point(102, 162);
            this.btnPromeniIznajmljivanje.Name = "btnPromeniIznajmljivanje";
            this.btnPromeniIznajmljivanje.Size = new System.Drawing.Size(70, 25);
            this.btnPromeniIznajmljivanje.TabIndex = 50;
            this.btnPromeniIznajmljivanje.Text = "Promeni";
            this.btnPromeniIznajmljivanje.UseVisualStyleBackColor = false;
            this.btnPromeniIznajmljivanje.Click += new System.EventHandler(this.btnPromeniIznajmljivanje_Click);
            // 
            // btnUbaciIznajmljivanje
            // 
            this.btnUbaciIznajmljivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUbaciIznajmljivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnUbaciIznajmljivanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbaciIznajmljivanje.FlatAppearance.BorderSize = 0;
            this.btnUbaciIznajmljivanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnUbaciIznajmljivanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnUbaciIznajmljivanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbaciIznajmljivanje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbaciIznajmljivanje.ForeColor = System.Drawing.Color.White;
            this.btnUbaciIznajmljivanje.Location = new System.Drawing.Point(16, 162);
            this.btnUbaciIznajmljivanje.Name = "btnUbaciIznajmljivanje";
            this.btnUbaciIznajmljivanje.Size = new System.Drawing.Size(70, 25);
            this.btnUbaciIznajmljivanje.TabIndex = 49;
            this.btnUbaciIznajmljivanje.Text = "Ubaci";
            this.btnUbaciIznajmljivanje.UseVisualStyleBackColor = false;
            this.btnUbaciIznajmljivanje.Click += new System.EventHandler(this.btnUbaciIznajmljivanje_Click);
            // 
            // dtpPovratka
            // 
            this.dtpPovratka.Location = new System.Drawing.Point(146, 53);
            this.dtpPovratka.Name = "dtpPovratka";
            this.dtpPovratka.Size = new System.Drawing.Size(197, 20);
            this.dtpPovratka.TabIndex = 35;
            this.dtpPovratka.ValueChanged += new System.EventHandler(this.dtpPovratka_ValueChanged);
            // 
            // lblDatumPovratka
            // 
            this.lblDatumPovratka.AutoSize = true;
            this.lblDatumPovratka.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumPovratka.Location = new System.Drawing.Point(9, 53);
            this.lblDatumPovratka.Name = "lblDatumPovratka";
            this.lblDatumPovratka.Size = new System.Drawing.Size(102, 16);
            this.lblDatumPovratka.TabIndex = 34;
            this.lblDatumPovratka.Text = "Datum povratka:";
            // 
            // lblDatumIznajmljivanja
            // 
            this.lblDatumIznajmljivanja.AutoSize = true;
            this.lblDatumIznajmljivanja.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumIznajmljivanja.Location = new System.Drawing.Point(9, 20);
            this.lblDatumIznajmljivanja.Name = "lblDatumIznajmljivanja";
            this.lblDatumIznajmljivanja.Size = new System.Drawing.Size(132, 16);
            this.lblDatumIznajmljivanja.TabIndex = 33;
            this.lblDatumIznajmljivanja.Text = "Datum iznajmljivanja:";
            // 
            // dtpIznajmljivanja
            // 
            this.dtpIznajmljivanja.Location = new System.Drawing.Point(147, 20);
            this.dtpIznajmljivanja.Name = "dtpIznajmljivanja";
            this.dtpIznajmljivanja.Size = new System.Drawing.Size(196, 20);
            this.dtpIznajmljivanja.TabIndex = 0;
            this.dtpIznajmljivanja.ValueChanged += new System.EventHandler(this.dtpIznajmljivanja_ValueChanged);
            // 
            // panelStavkeControls
            // 
            this.panelStavkeControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelStavkeControls.BackColor = System.Drawing.Color.White;
            this.panelStavkeControls.Controls.Add(this.btnObrisiStavka);
            this.panelStavkeControls.Controls.Add(this.btnUbaciStavka);
            this.panelStavkeControls.Controls.Add(this.txtCena);
            this.panelStavkeControls.Controls.Add(this.cmbBicikla);
            this.panelStavkeControls.Controls.Add(this.lblBicikla);
            this.panelStavkeControls.Controls.Add(this.lblCena);
            this.panelStavkeControls.Location = new System.Drawing.Point(395, 275);
            this.panelStavkeControls.Name = "panelStavkeControls";
            this.panelStavkeControls.Size = new System.Drawing.Size(285, 160);
            this.panelStavkeControls.TabIndex = 36;
            // 
            // btnObrisiStavka
            // 
            this.btnObrisiStavka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiStavka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnObrisiStavka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiStavka.FlatAppearance.BorderSize = 0;
            this.btnObrisiStavka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnObrisiStavka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnObrisiStavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiStavka.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiStavka.ForeColor = System.Drawing.Color.White;
            this.btnObrisiStavka.Location = new System.Drawing.Point(168, 122);
            this.btnObrisiStavka.Name = "btnObrisiStavka";
            this.btnObrisiStavka.Size = new System.Drawing.Size(70, 25);
            this.btnObrisiStavka.TabIndex = 50;
            this.btnObrisiStavka.Text = "Obrisi";
            this.btnObrisiStavka.UseVisualStyleBackColor = false;
            this.btnObrisiStavka.Click += new System.EventHandler(this.btnObrisiStavka_Click);
            // 
            // btnUbaciStavka
            // 
            this.btnUbaciStavka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUbaciStavka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnUbaciStavka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbaciStavka.FlatAppearance.BorderSize = 0;
            this.btnUbaciStavka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnUbaciStavka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnUbaciStavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbaciStavka.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbaciStavka.ForeColor = System.Drawing.Color.White;
            this.btnUbaciStavka.Location = new System.Drawing.Point(52, 122);
            this.btnUbaciStavka.Name = "btnUbaciStavka";
            this.btnUbaciStavka.Size = new System.Drawing.Size(70, 25);
            this.btnUbaciStavka.TabIndex = 49;
            this.btnUbaciStavka.Text = "Ubaci";
            this.btnUbaciStavka.UseVisualStyleBackColor = false;
            this.btnUbaciStavka.Click += new System.EventHandler(this.btnUbaciStavka_Click);
            // 
            // txtCena
            // 
            this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCena.Location = new System.Drawing.Point(85, 31);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(148, 20);
            this.txtCena.TabIndex = 39;
            // 
            // cmbBicikla
            // 
            this.cmbBicikla.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBicikla.FormattingEnabled = true;
            this.cmbBicikla.Location = new System.Drawing.Point(85, 69);
            this.cmbBicikla.Name = "cmbBicikla";
            this.cmbBicikla.Size = new System.Drawing.Size(148, 21);
            this.cmbBicikla.TabIndex = 38;
            // 
            // lblBicikla
            // 
            this.lblBicikla.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBicikla.AutoSize = true;
            this.lblBicikla.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBicikla.Location = new System.Drawing.Point(17, 71);
            this.lblBicikla.Name = "lblBicikla";
            this.lblBicikla.Size = new System.Drawing.Size(51, 16);
            this.lblBicikla.TabIndex = 37;
            this.lblBicikla.Text = "Bicikla: ";
            // 
            // lblCena
            // 
            this.lblCena.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(17, 33);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(45, 16);
            this.lblCena.TabIndex = 36;
            this.lblCena.Text = "Cena: ";
            // 
            // UCIznajmljivanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelStavkeControls);
            this.Controls.Add(this.panelIznajmljivanjaControls);
            this.Controls.Add(this.panelStavke);
            this.Controls.Add(this.panelIznajmljivanja);
            this.Name = "UCIznajmljivanja";
            this.Size = new System.Drawing.Size(700, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIznajmljivanja)).EndInit();
            this.panelIznajmljivanja.ResumeLayout(false);
            this.panelIznajmljivanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.panelStavke.ResumeLayout(false);
            this.panelStavke.PerformLayout();
            this.panelIznajmljivanjaControls.ResumeLayout(false);
            this.panelIznajmljivanjaControls.PerformLayout();
            this.panelStavkeControls.ResumeLayout(false);
            this.panelStavkeControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIznajmljivanja;
        private System.Windows.Forms.Panel panelIznajmljivanja;
        private System.Windows.Forms.Button btnKreirajIznajmljivanje;
        private System.Windows.Forms.Label lblIznajmljivanja;
        private System.Windows.Forms.Label lblStavke;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Panel panelStavke;
        private System.Windows.Forms.Panel panelIznajmljivanjaControls;
        private System.Windows.Forms.DateTimePicker dtpIznajmljivanja;
        private System.Windows.Forms.Label lblDatumIznajmljivanja;
        private System.Windows.Forms.Label lblDatumPovratka;
        private System.Windows.Forms.DateTimePicker dtpPovratka;
        private System.Windows.Forms.Panel panelStavkeControls;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.ComboBox cmbBicikla;
        private System.Windows.Forms.Label lblBicikla;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Button btnObrisiIznajmljivanje;
        private System.Windows.Forms.Button btnPretraziIznajmljivanje;
        private System.Windows.Forms.Button btnPromeniIznajmljivanje;
        private System.Windows.Forms.Button btnUbaciIznajmljivanje;
        private System.Windows.Forms.ComboBox cmbPoslovniPartner;
        private System.Windows.Forms.Button btnObrisiStavka;
        private System.Windows.Forms.Button btnUbaciStavka;
        private System.Windows.Forms.Label lblPoslovni;
        private Label lblAutomat;
        private ComboBox cmbAutomati;

        public DataGridView DgvIznajmljivanja { get => dgvIznajmljivanja; set => dgvIznajmljivanja = value; }
        public Panel PanelIznajmljivanja { get => panelIznajmljivanja; set => panelIznajmljivanja = value; }
        public Button BtnKreirajIznajmljivanje { get => btnKreirajIznajmljivanje; set => btnKreirajIznajmljivanje = value; }
        public Label LblIznajmljivanja { get => lblIznajmljivanja; set => lblIznajmljivanja = value; }
        public Label LblStavke { get => lblStavke; set => lblStavke = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public Panel PanelStavke { get => panelStavke; set => panelStavke = value; }
        public Panel PanelIznajmljivanjaControls { get => panelIznajmljivanjaControls; set => panelIznajmljivanjaControls = value; }
        public DateTimePicker DtpIznajmljivanja { get => dtpIznajmljivanja; set => dtpIznajmljivanja = value; }
        public Label LblDatumIznajmljivanja { get => lblDatumIznajmljivanja; set => lblDatumIznajmljivanja = value; }
        public Label LblDatumPovratka { get => lblDatumPovratka; set => lblDatumPovratka = value; }
        public DateTimePicker DtpPovratka { get => dtpPovratka; set => dtpPovratka = value; }
        public Panel PanelStavkeControls { get => panelStavkeControls; set => panelStavkeControls = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public ComboBox CmbBicikla { get => cmbBicikla; set => cmbBicikla = value; }
        public Label LblBicikla { get => lblBicikla; set => lblBicikla = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public Button BtnObrisiIznajmljivanje { get => btnObrisiIznajmljivanje; set => btnObrisiIznajmljivanje = value; }
        public Button BtnPretraziIznajmljivanje { get => btnPretraziIznajmljivanje; set => btnPretraziIznajmljivanje = value; }
        public Button BtnPromeniIznajmljivanje { get => btnPromeniIznajmljivanje; set => btnPromeniIznajmljivanje = value; }
        public Button BtnUbaciIznajmljivanje { get => btnUbaciIznajmljivanje; set => btnUbaciIznajmljivanje = value; }
        public ComboBox CmbPoslovniPartner { get => cmbPoslovniPartner; set => cmbPoslovniPartner = value; }
        public Button BtnObrisiStavka { get => btnObrisiStavka; set => btnObrisiStavka = value; }
        public Button BtnUbaciStavka { get => btnUbaciStavka; set => btnUbaciStavka = value; }
        public Label LblPoslovni { get => lblPoslovni; set => lblPoslovni = value; }
        public Label LblAutomat { get => lblAutomat; set => lblAutomat = value; }
        public ComboBox CmbAutomati { get => cmbAutomati; set => cmbAutomati = value; }
    }
}
