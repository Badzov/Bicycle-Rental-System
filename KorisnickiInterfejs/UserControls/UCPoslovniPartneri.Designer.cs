using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCPoslovniPartneri
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.brnObrisi = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.cmbMesto = new System.Windows.Forms.ComboBox();
            this.lblMesto = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.panelShow = new System.Windows.Forms.Panel();
            this.buttonKreiraj = new System.Windows.Forms.Button();
            this.lblPoslovni = new System.Windows.Forms.Label();
            this.dgvPoslovniPartneri = new System.Windows.Forms.DataGridView();
            this.panelInfo.SuspendLayout();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovniPartneri)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.buttonDodaj);
            this.panelInfo.Controls.Add(this.btnPretrazi);
            this.panelInfo.Controls.Add(this.brnObrisi);
            this.panelInfo.Controls.Add(this.btnPromeni);
            this.panelInfo.Controls.Add(this.btnUbaci);
            this.panelInfo.Controls.Add(this.cmbMesto);
            this.panelInfo.Controls.Add(this.lblMesto);
            this.panelInfo.Controls.Add(this.txtEmail);
            this.panelInfo.Controls.Add(this.lblEmail);
            this.panelInfo.Controls.Add(this.txtPrezime);
            this.panelInfo.Controls.Add(this.lblPrezime);
            this.panelInfo.Controls.Add(this.txtIme);
            this.panelInfo.Controls.Add(this.lblIme);
            this.panelInfo.Location = new System.Drawing.Point(20, 20);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(220, 410);
            this.panelInfo.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.buttonDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodaj.FlatAppearance.BorderSize = 0;
            this.buttonDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.buttonDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(181, 251);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(24, 21);
            this.buttonDodaj.TabIndex = 44;
            this.buttonDodaj.Text = "+";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPretrazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(118, 310);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(87, 35);
            this.btnPretrazi.TabIndex = 43;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // brnObrisi
            // 
            this.brnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.brnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnObrisi.FlatAppearance.BorderSize = 0;
            this.brnObrisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.brnObrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.brnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnObrisi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnObrisi.ForeColor = System.Drawing.Color.White;
            this.brnObrisi.Location = new System.Drawing.Point(118, 360);
            this.brnObrisi.Name = "brnObrisi";
            this.brnObrisi.Size = new System.Drawing.Size(87, 35);
            this.brnObrisi.TabIndex = 42;
            this.brnObrisi.Text = "Obrisi";
            this.brnObrisi.UseVisualStyleBackColor = false;
            this.brnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnPromeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromeni.FlatAppearance.BorderSize = 0;
            this.btnPromeni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPromeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPromeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromeni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromeni.ForeColor = System.Drawing.Color.White;
            this.btnPromeni.Location = new System.Drawing.Point(15, 360);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(87, 35);
            this.btnPromeni.TabIndex = 41;
            this.btnPromeni.Text = "Promeni";
            this.btnPromeni.UseVisualStyleBackColor = false;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnUbaci
            // 
            this.btnUbaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnUbaci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbaci.FlatAppearance.BorderSize = 0;
            this.btnUbaci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnUbaci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnUbaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbaci.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbaci.ForeColor = System.Drawing.Color.White;
            this.btnUbaci.Location = new System.Drawing.Point(15, 310);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(87, 35);
            this.btnUbaci.TabIndex = 40;
            this.btnUbaci.Text = "Ubaci";
            this.btnUbaci.UseVisualStyleBackColor = false;
            this.btnUbaci.Click += new System.EventHandler(this.btnUbaci_Click);
            // 
            // cmbMesto
            // 
            this.cmbMesto.FormattingEnabled = true;
            this.cmbMesto.Location = new System.Drawing.Point(15, 251);
            this.cmbMesto.Name = "cmbMesto";
            this.cmbMesto.Size = new System.Drawing.Size(160, 21);
            this.cmbMesto.TabIndex = 39;
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesto.Location = new System.Drawing.Point(12, 231);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(46, 16);
            this.lblMesto.TabIndex = 38;
            this.lblMesto.Text = "Mesto:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(15, 181);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 30);
            this.txtEmail.TabIndex = 37;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 162);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 16);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(15, 111);
            this.txtPrezime.Multiline = true;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(190, 30);
            this.txtPrezime.TabIndex = 35;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(12, 92);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(58, 16);
            this.lblPrezime.TabIndex = 34;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(15, 48);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(190, 30);
            this.txtIme.TabIndex = 33;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(12, 29);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 16);
            this.lblIme.TabIndex = 32;
            this.lblIme.Text = "Ime:";
            // 
            // panelShow
            // 
            this.panelShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelShow.BackColor = System.Drawing.Color.White;
            this.panelShow.Controls.Add(this.buttonKreiraj);
            this.panelShow.Controls.Add(this.lblPoslovni);
            this.panelShow.Controls.Add(this.dgvPoslovniPartneri);
            this.panelShow.Location = new System.Drawing.Point(260, 20);
            this.panelShow.Name = "panelShow";
            this.panelShow.Padding = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.panelShow.Size = new System.Drawing.Size(420, 410);
            this.panelShow.TabIndex = 1;
            // 
            // buttonKreiraj
            // 
            this.buttonKreiraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKreiraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.buttonKreiraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKreiraj.FlatAppearance.BorderSize = 0;
            this.buttonKreiraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.buttonKreiraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.buttonKreiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKreiraj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKreiraj.ForeColor = System.Drawing.Color.White;
            this.buttonKreiraj.Location = new System.Drawing.Point(329, 14);
            this.buttonKreiraj.Name = "buttonKreiraj";
            this.buttonKreiraj.Size = new System.Drawing.Size(71, 22);
            this.buttonKreiraj.TabIndex = 44;
            this.buttonKreiraj.Text = "Kreiraj";
            this.buttonKreiraj.UseVisualStyleBackColor = false;
            this.buttonKreiraj.Click += new System.EventHandler(this.buttonKreiraj_Click);
            // 
            // lblPoslovni
            // 
            this.lblPoslovni.AutoSize = true;
            this.lblPoslovni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoslovni.Location = new System.Drawing.Point(16, 14);
            this.lblPoslovni.Name = "lblPoslovni";
            this.lblPoslovni.Size = new System.Drawing.Size(165, 22);
            this.lblPoslovni.TabIndex = 30;
            this.lblPoslovni.Text = "Poslovni Partneri";
            // 
            // dgvPoslovniPartneri
            // 
            this.dgvPoslovniPartneri.AllowUserToAddRows = false;
            this.dgvPoslovniPartneri.AllowUserToDeleteRows = false;
            this.dgvPoslovniPartneri.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvPoslovniPartneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslovniPartneri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPoslovniPartneri.Location = new System.Drawing.Point(20, 50);
            this.dgvPoslovniPartneri.Name = "dgvPoslovniPartneri";
            this.dgvPoslovniPartneri.ReadOnly = true;
            this.dgvPoslovniPartneri.Size = new System.Drawing.Size(380, 340);
            this.dgvPoslovniPartneri.TabIndex = 0;
            this.dgvPoslovniPartneri.SelectionChanged += new System.EventHandler(this.dgvPoslovniPartneri_SelectionChanged);
            // 
            // UCPoslovniPartneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelInfo);
            this.Name = "UCPoslovniPartneri";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(700, 450);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovniPartneri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.ComboBox cmbMesto;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button brnObrisi;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnUbaci;
        private Panel panelShow;
        private DataGridView dgvPoslovniPartneri;
        private Label lblPoslovni;
        private Button btnPretrazi;
        private Button buttonKreiraj;
        private Button buttonDodaj;

        public Panel PanelInfo { get => panelInfo; set => panelInfo = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public ComboBox CmbMesto { get => cmbMesto; set => cmbMesto = value; }
        public Label LblMesto { get => lblMesto; set => lblMesto = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Button BrnObrisi { get => brnObrisi; set => brnObrisi = value; }
        public Button BtnPromeni { get => btnPromeni; set => btnPromeni = value; }
        public Button BtnKreiraj { get => btnUbaci; set => btnUbaci = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Panel PanelShow { get => panelShow; set => panelShow = value; }
        public DataGridView DgvPoslovniPartneri { get => dgvPoslovniPartneri; set => dgvPoslovniPartneri = value; }
        public Label LblPoslovni { get => lblPoslovni; set => lblPoslovni = value; }
        public Button BtnPretrazi1 { get => btnPretrazi; set => btnPretrazi = value; }
        public Button ButtonKreiraj { get => buttonKreiraj; set => buttonKreiraj = value; }
    }
}
