using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSistem = new System.Windows.Forms.Label();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.lblPrijavi = new System.Windows.Forms.Label();
            this.btnRegistruj = new System.Windows.Forms.Button();
            this.checkbxShow = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblRegistrujAutomat = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.dtpDatumProizvodnje = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblSistem);
            this.panel1.Controls.Add(this.btnPrijavi);
            this.panel1.Controls.Add(this.lblPrijavi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 400);
            this.panel1.TabIndex = 18;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.picLogo.Image = global::KorisnickiInterfejs.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(24, 27);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(224, 112);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // lblSistem
            // 
            this.lblSistem.AutoSize = true;
            this.lblSistem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistem.ForeColor = System.Drawing.Color.White;
            this.lblSistem.Location = new System.Drawing.Point(22, 183);
            this.lblSistem.Name = "lblSistem";
            this.lblSistem.Size = new System.Drawing.Size(230, 19);
            this.lblSistem.TabIndex = 2;
            this.lblSistem.Text = "Sistem za Iznajmljivanje Bicikla";
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnPrijavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrijavi.FlatAppearance.BorderSize = 0;
            this.btnPrijavi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnPrijavi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnPrijavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijavi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijavi.ForeColor = System.Drawing.Color.White;
            this.btnPrijavi.Location = new System.Drawing.Point(12, 350);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(253, 35);
            this.btnPrijavi.TabIndex = 1;
            this.btnPrijavi.Text = "PRIJAVI";
            this.btnPrijavi.UseVisualStyleBackColor = false;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // lblPrijavi
            // 
            this.lblPrijavi.AutoSize = true;
            this.lblPrijavi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavi.ForeColor = System.Drawing.Color.White;
            this.lblPrijavi.Location = new System.Drawing.Point(96, 330);
            this.lblPrijavi.Name = "lblPrijavi";
            this.lblPrijavi.Size = new System.Drawing.Size(89, 14);
            this.lblPrijavi.TabIndex = 0;
            this.lblPrijavi.Text = "Prijavi Automat";
            // 
            // btnRegistruj
            // 
            this.btnRegistruj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnRegistruj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistruj.FlatAppearance.BorderSize = 0;
            this.btnRegistruj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnRegistruj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnRegistruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistruj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistruj.ForeColor = System.Drawing.Color.White;
            this.btnRegistruj.Location = new System.Drawing.Point(375, 350);
            this.btnRegistruj.Name = "btnRegistruj";
            this.btnRegistruj.Size = new System.Drawing.Size(105, 37);
            this.btnRegistruj.TabIndex = 26;
            this.btnRegistruj.Text = "REGISTRUJ";
            this.btnRegistruj.UseVisualStyleBackColor = false;
            this.btnRegistruj.Click += new System.EventHandler(this.btnRegistruj_Click);
            // 
            // checkbxShow
            // 
            this.checkbxShow.AutoSize = true;
            this.checkbxShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbxShow.Location = new System.Drawing.Point(470, 194);
            this.checkbxShow.Name = "checkbxShow";
            this.checkbxShow.Size = new System.Drawing.Size(84, 18);
            this.checkbxShow.TabIndex = 25;
            this.checkbxShow.Text = "Prikaži šifru";
            this.checkbxShow.UseVisualStyleBackColor = true;
            this.checkbxShow.CheckedChanged += new System.EventHandler(this.checkbxShow_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(300, 159);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(251, 30);
            this.txtPassword.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(300, 138);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(39, 16);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Šifra:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(300, 96);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(251, 30);
            this.txtUsername.TabIndex = 22;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(300, 75);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(94, 16);
            this.lblusername.TabIndex = 21;
            this.lblusername.Text = "Korisničko ime:";
            // 
            // lblRegistrujAutomat
            // 
            this.lblRegistrujAutomat.AutoSize = true;
            this.lblRegistrujAutomat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrujAutomat.Location = new System.Drawing.Point(300, 23);
            this.lblRegistrujAutomat.Name = "lblRegistrujAutomat";
            this.lblRegistrujAutomat.Size = new System.Drawing.Size(176, 22);
            this.lblRegistrujAutomat.TabIndex = 20;
            this.lblRegistrujAutomat.Text = "Registruj Automat";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(548, 10);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 18);
            this.lblX.TabIndex = 19;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.Location = new System.Drawing.Point(525, 10);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(16, 18);
            this.lblMinimize.TabIndex = 37;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // dtpDatumProizvodnje
            // 
            this.dtpDatumProizvodnje.Location = new System.Drawing.Point(300, 250);
            this.dtpDatumProizvodnje.Name = "dtpDatumProizvodnje";
            this.dtpDatumProizvodnje.Size = new System.Drawing.Size(221, 20);
            this.dtpDatumProizvodnje.TabIndex = 38;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(300, 225);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(123, 16);
            this.lblDatum.TabIndex = 40;
            this.lblDatum.Text = "Datum proizvodnje: ";
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(300, 310);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(221, 21);
            this.cmbLokacija.TabIndex = 41;
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.Location = new System.Drawing.Point(300, 285);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(62, 16);
            this.lblLokacija.TabIndex = 42;
            this.lblLokacija.Text = "Lokacija: ";
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
            this.buttonDodaj.Location = new System.Drawing.Point(530, 310);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(24, 21);
            this.buttonDodaj.TabIndex = 43;
            this.buttonDodaj.Text = "+";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.cmbLokacija);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dtpDatumProizvodnje);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistruj);
            this.Controls.Add(this.checkbxShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblRegistrujAutomat);
            this.Controls.Add(this.lblX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegister";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSistem;
        private System.Windows.Forms.Button btnPrijavi;
        private System.Windows.Forms.Label lblPrijavi;
        private System.Windows.Forms.Button btnRegistruj;
        private System.Windows.Forms.CheckBox checkbxShow;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblRegistrujAutomat;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblMinimize;
        private DateTimePicker dtpDatumProizvodnje;
        private Label lblDatum;
        private ComboBox cmbLokacija;
        private Label lblLokacija;
        private Button buttonDodaj;

        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public PictureBox PicLogo { get => picLogo; set => picLogo = value; }
        public Label LblSistem { get => lblSistem; set => lblSistem = value; }
        public Button BtnPrijavi { get => btnPrijavi; set => btnPrijavi = value; }
        public Label LblPrijavi { get => lblPrijavi; set => lblPrijavi = value; }
        public Button BtnRegistruj { get => btnRegistruj; set => btnRegistruj = value; }
        public CheckBox CheckbxShow { get => checkbxShow; set => checkbxShow = value; }
        public TextBox TxtPassword { get => txtPassword; set => txtPassword = value; }
        public Label LblPassword { get => lblPassword; set => lblPassword = value; }
        public TextBox TxtUsername { get => txtUsername; set => txtUsername = value; }
        public Label Lblusername { get => lblusername; set => lblusername = value; }
        public Label LblRegistrujAutomat { get => lblRegistrujAutomat; set => lblRegistrujAutomat = value; }
        public Label LblX { get => lblX; set => lblX = value; }
        public Label LblMinimize { get => lblMinimize; set => lblMinimize = value; }
        public DateTimePicker DtpDatumProizvodnje { get => dtpDatumProizvodnje; set => dtpDatumProizvodnje = value; }
        public Label LblDatum { get => lblDatum; set => lblDatum = value; }
        public ComboBox CmbLokacija { get => cmbLokacija; set => cmbLokacija = value; }
        public Label LblLokacija { get => lblLokacija; set => lblLokacija = value; }
    }
}