using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCBicikle
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
            this.panelShow = new System.Windows.Forms.Panel();
            this.buttonKreiraj = new System.Windows.Forms.Button();
            this.lblBicikle = new System.Windows.Forms.Label();
            this.dgvBicikle = new System.Windows.Forms.DataGridView();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.brnObrisi = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.lblBoja = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBicikle)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelShow.BackColor = System.Drawing.Color.White;
            this.panelShow.Controls.Add(this.buttonKreiraj);
            this.panelShow.Controls.Add(this.lblBicikle);
            this.panelShow.Controls.Add(this.dgvBicikle);
            this.panelShow.Location = new System.Drawing.Point(260, 20);
            this.panelShow.Name = "panelShow";
            this.panelShow.Padding = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.panelShow.Size = new System.Drawing.Size(420, 410);
            this.panelShow.TabIndex = 3;
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
            // lblBicikle
            // 
            this.lblBicikle.AutoSize = true;
            this.lblBicikle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBicikle.Location = new System.Drawing.Point(16, 14);
            this.lblBicikle.Name = "lblBicikle";
            this.lblBicikle.Size = new System.Drawing.Size(72, 22);
            this.lblBicikle.TabIndex = 30;
            this.lblBicikle.Text = "Bicikle";
            // 
            // dgvBicikle
            // 
            this.dgvBicikle.AllowUserToAddRows = false;
            this.dgvBicikle.AllowUserToDeleteRows = false;
            this.dgvBicikle.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvBicikle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBicikle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBicikle.Location = new System.Drawing.Point(20, 50);
            this.dgvBicikle.Name = "dgvBicikle";
            this.dgvBicikle.ReadOnly = true;
            this.dgvBicikle.Size = new System.Drawing.Size(380, 340);
            this.dgvBicikle.TabIndex = 0;
            this.dgvBicikle.SelectionChanged += new System.EventHandler(this.dgvBicikle_SelectionChanged);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.txtGodina);
            this.panelInfo.Controls.Add(this.txtCena);
            this.panelInfo.Controls.Add(this.btnPretrazi);
            this.panelInfo.Controls.Add(this.brnObrisi);
            this.panelInfo.Controls.Add(this.btnPromeni);
            this.panelInfo.Controls.Add(this.btnUbaci);
            this.panelInfo.Controls.Add(this.lblCena);
            this.panelInfo.Controls.Add(this.lblGodina);
            this.panelInfo.Controls.Add(this.txtBoja);
            this.panelInfo.Controls.Add(this.lblBoja);
            this.panelInfo.Controls.Add(this.txtModel);
            this.panelInfo.Controls.Add(this.lblModel);
            this.panelInfo.Location = new System.Drawing.Point(20, 20);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(220, 410);
            this.panelInfo.TabIndex = 2;
            // 
            // txtGodina
            // 
            this.txtGodina.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGodina.Location = new System.Drawing.Point(15, 181);
            this.txtGodina.Multiline = true;
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(190, 30);
            this.txtGodina.TabIndex = 47;
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.Location = new System.Drawing.Point(15, 250);
            this.txtCena.Multiline = true;
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(190, 30);
            this.txtCena.TabIndex = 46;
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
            this.brnObrisi.Click += new System.EventHandler(this.brnObrisi_Click);
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
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(12, 231);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(41, 16);
            this.lblCena.TabIndex = 38;
            this.lblCena.Text = "Cena:";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodina.Location = new System.Drawing.Point(12, 162);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(121, 16);
            this.lblGodina.TabIndex = 36;
            this.lblGodina.Text = "Godina proizvodnje:";
            // 
            // txtBoja
            // 
            this.txtBoja.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoja.Location = new System.Drawing.Point(15, 111);
            this.txtBoja.Multiline = true;
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(190, 30);
            this.txtBoja.TabIndex = 35;
            // 
            // lblBoja
            // 
            this.lblBoja.AutoSize = true;
            this.lblBoja.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoja.Location = new System.Drawing.Point(12, 92);
            this.lblBoja.Name = "lblBoja";
            this.lblBoja.Size = new System.Drawing.Size(37, 16);
            this.lblBoja.TabIndex = 34;
            this.lblBoja.Text = "Boja:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(15, 48);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(190, 30);
            this.txtModel.TabIndex = 33;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(12, 29);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 16);
            this.lblModel.TabIndex = 32;
            this.lblModel.Text = "Model:";
            // 
            // UCBicikle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelInfo);
            this.Name = "UCBicikle";
            this.Size = new System.Drawing.Size(700, 450);
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBicikle)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Button buttonKreiraj;
        private System.Windows.Forms.Label lblBicikle;
        private System.Windows.Forms.DataGridView dgvBicikle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button brnObrisi;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnUbaci;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.Label lblBoja;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtCena;
        private TextBox txtGodina;

        public Panel PanelShow { get => panelShow; set => panelShow = value; }
        public Button ButtonKreiraj { get => buttonKreiraj; set => buttonKreiraj = value; }
        public Label LblBicikle { get => lblBicikle; set => lblBicikle = value; }
        public DataGridView DgvBicikle { get => dgvBicikle; set => dgvBicikle = value; }
        public Panel PanelInfo { get => panelInfo; set => panelInfo = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Button BrnObrisi { get => brnObrisi; set => brnObrisi = value; }
        public Button BtnPromeni { get => btnPromeni; set => btnPromeni = value; }
        public Button BtnUbaci { get => btnUbaci; set => btnUbaci = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public Label LblGodina { get => lblGodina; set => lblGodina = value; }
        public TextBox TxtBoja { get => txtBoja; set => txtBoja = value; }
        public Label LblBoja { get => lblBoja; set => lblBoja = value; }
        public TextBox TxtModel { get => txtModel; set => txtModel = value; }
        public Label LblModel { get => lblModel; set => lblModel = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public TextBox TxtGodina { get => txtGodina; set => txtGodina = value; }
    }
}
