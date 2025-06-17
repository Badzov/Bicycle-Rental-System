using FontAwesome.Sharp;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibIznajmljivanja = new FontAwesome.Sharp.IconButton();
            this.ibBicikle = new FontAwesome.Sharp.IconButton();
            this.ibSignOut = new FontAwesome.Sharp.IconButton();
            this.ibPoslovniPartneri = new FontAwesome.Sharp.IconButton();
            this.ibHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.ibNavicon = new FontAwesome.Sharp.IconButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panelMenu.Controls.Add(this.ibIznajmljivanja);
            this.panelMenu.Controls.Add(this.ibBicikle);
            this.panelMenu.Controls.Add(this.ibSignOut);
            this.panelMenu.Controls.Add(this.ibPoslovniPartneri);
            this.panelMenu.Controls.Add(this.ibHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // ibIznajmljivanja
            // 
            this.ibIznajmljivanja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibIznajmljivanja.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibIznajmljivanja.FlatAppearance.BorderSize = 0;
            this.ibIznajmljivanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibIznajmljivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibIznajmljivanja.ForeColor = System.Drawing.SystemColors.Control;
            this.ibIznajmljivanja.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.ibIznajmljivanja.IconColor = System.Drawing.Color.White;
            this.ibIznajmljivanja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibIznajmljivanja.IconSize = 30;
            this.ibIznajmljivanja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibIznajmljivanja.Location = new System.Drawing.Point(0, 242);
            this.ibIznajmljivanja.Name = "ibIznajmljivanja";
            this.ibIznajmljivanja.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibIznajmljivanja.Size = new System.Drawing.Size(200, 37);
            this.ibIznajmljivanja.TabIndex = 6;
            this.ibIznajmljivanja.Tag = "   Iznajmljivanja";
            this.ibIznajmljivanja.Text = "   Iznajmljivanja";
            this.ibIznajmljivanja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibIznajmljivanja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibIznajmljivanja.UseVisualStyleBackColor = true;
            this.ibIznajmljivanja.Click += new System.EventHandler(this.ibIznajmljivanja_Click);
            // 
            // ibBicikle
            // 
            this.ibBicikle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibBicikle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibBicikle.FlatAppearance.BorderSize = 0;
            this.ibBicikle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibBicikle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibBicikle.ForeColor = System.Drawing.SystemColors.Control;
            this.ibBicikle.IconChar = FontAwesome.Sharp.IconChar.Bicycle;
            this.ibBicikle.IconColor = System.Drawing.Color.White;
            this.ibBicikle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibBicikle.IconSize = 30;
            this.ibBicikle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibBicikle.Location = new System.Drawing.Point(0, 205);
            this.ibBicikle.Name = "ibBicikle";
            this.ibBicikle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibBicikle.Size = new System.Drawing.Size(200, 37);
            this.ibBicikle.TabIndex = 5;
            this.ibBicikle.Tag = "   Bicikle";
            this.ibBicikle.Text = "   Bicikle";
            this.ibBicikle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibBicikle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibBicikle.UseVisualStyleBackColor = true;
            this.ibBicikle.Click += new System.EventHandler(this.ibBicikle_Click);
            // 
            // ibSignOut
            // 
            this.ibSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibSignOut.FlatAppearance.BorderSize = 0;
            this.ibSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSignOut.ForeColor = System.Drawing.SystemColors.Control;
            this.ibSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.ibSignOut.IconColor = System.Drawing.Color.White;
            this.ibSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSignOut.IconSize = 30;
            this.ibSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSignOut.Location = new System.Drawing.Point(0, 402);
            this.ibSignOut.Name = "ibSignOut";
            this.ibSignOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibSignOut.Size = new System.Drawing.Size(200, 48);
            this.ibSignOut.TabIndex = 4;
            this.ibSignOut.Tag = "   Odjava";
            this.ibSignOut.Text = "   Odjava";
            this.ibSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSignOut.UseVisualStyleBackColor = true;
            this.ibSignOut.Click += new System.EventHandler(this.ibSignOut_Click);
            // 
            // ibPoslovniPartneri
            // 
            this.ibPoslovniPartneri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibPoslovniPartneri.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibPoslovniPartneri.FlatAppearance.BorderSize = 0;
            this.ibPoslovniPartneri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibPoslovniPartneri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibPoslovniPartneri.ForeColor = System.Drawing.SystemColors.Control;
            this.ibPoslovniPartneri.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibPoslovniPartneri.IconColor = System.Drawing.Color.White;
            this.ibPoslovniPartneri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibPoslovniPartneri.IconSize = 30;
            this.ibPoslovniPartneri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibPoslovniPartneri.Location = new System.Drawing.Point(0, 168);
            this.ibPoslovniPartneri.Name = "ibPoslovniPartneri";
            this.ibPoslovniPartneri.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibPoslovniPartneri.Size = new System.Drawing.Size(200, 37);
            this.ibPoslovniPartneri.TabIndex = 3;
            this.ibPoslovniPartneri.Tag = "   Poslovni partneri";
            this.ibPoslovniPartneri.Text = "   Poslovni partneri";
            this.ibPoslovniPartneri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibPoslovniPartneri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibPoslovniPartneri.UseVisualStyleBackColor = true;
            this.ibPoslovniPartneri.Click += new System.EventHandler(this.ibPoslovniPartneri_Click);
            // 
            // ibHome
            // 
            this.ibHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibHome.FlatAppearance.BorderSize = 0;
            this.ibHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibHome.ForeColor = System.Drawing.SystemColors.Control;
            this.ibHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.ibHome.IconColor = System.Drawing.Color.White;
            this.ibHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibHome.IconSize = 30;
            this.ibHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibHome.Location = new System.Drawing.Point(0, 131);
            this.ibHome.Name = "ibHome";
            this.ibHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibHome.Size = new System.Drawing.Size(200, 37);
            this.ibHome.TabIndex = 1;
            this.ibHome.Tag = "   Početna";
            this.ibHome.Text = "   Početna";
            this.ibHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibHome.UseVisualStyleBackColor = true;
            this.ibHome.Click += new System.EventHandler(this.ibHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.ibNavicon);
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 131);
            this.panelLogo.TabIndex = 0;
            // 
            // ibNavicon
            // 
            this.ibNavicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibNavicon.FlatAppearance.BorderSize = 0;
            this.ibNavicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibNavicon.ForeColor = System.Drawing.SystemColors.Control;
            this.ibNavicon.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.ibNavicon.IconColor = System.Drawing.Color.White;
            this.ibNavicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibNavicon.IconSize = 30;
            this.ibNavicon.Location = new System.Drawing.Point(138, 0);
            this.ibNavicon.Name = "ibNavicon";
            this.ibNavicon.Size = new System.Drawing.Size(62, 97);
            this.ibNavicon.TabIndex = 1;
            this.ibNavicon.UseVisualStyleBackColor = true;
            this.ibNavicon.Click += new System.EventHandler(this.ibNavicon_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::KorisnickiInterfejs.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(10, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(122, 97);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.Location = new System.Drawing.Point(748, 9);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(16, 18);
            this.lblMinimize.TabIndex = 38;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(771, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 18);
            this.lblX.TabIndex = 37;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 450);
            this.panelMain.TabIndex = 39;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton ibNavicon;
        private FontAwesome.Sharp.IconButton ibHome;
        private FontAwesome.Sharp.IconButton ibSignOut;
        private FontAwesome.Sharp.IconButton ibPoslovniPartneri;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblX;
        private Panel panelMain;
        private IconButton ibBicikle;
        private IconButton ibIznajmljivanja;

        public Panel PanelMenu { get => panelMenu; set => panelMenu = value; }
        public Panel PanelLogo { get => panelLogo; set => panelLogo = value; }
        public PictureBox PbLogo { get => pbLogo; set => pbLogo = value; }
        public IconButton IbNavicon { get => ibNavicon; set => ibNavicon = value; }
        public IconButton IbHome { get => ibHome; set => ibHome = value; }
        public IconButton IbSignOut { get => ibSignOut; set => ibSignOut = value; }
        public IconButton IbPoslovniPartneri { get => ibPoslovniPartneri; set => ibPoslovniPartneri = value; }
        public Label LblMinimize { get => lblMinimize; set => lblMinimize = value; }
        public Label LblX { get => lblX; set => lblX = value; }
        public Panel PanelMain { get => panelMain; set => panelMain = value; }
    }
}