using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCPocetna
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelPartneri = new System.Windows.Forms.Panel();
            this.lblBrPartneri = new System.Windows.Forms.Label();
            this.lblPartneri = new System.Windows.Forms.Label();
            this.pbPartneri = new System.Windows.Forms.PictureBox();
            this.panelAutomati = new System.Windows.Forms.Panel();
            this.lblBrAutomati = new System.Windows.Forms.Label();
            this.lblAutomati = new System.Windows.Forms.Label();
            this.pbAutomati = new System.Windows.Forms.PictureBox();
            this.panelBicikle = new System.Windows.Forms.Panel();
            this.lblBrBicikle = new System.Windows.Forms.Label();
            this.lblBicikle = new System.Windows.Forms.Label();
            this.pbBicikle = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.pbPocetna = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelPartneri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPartneri)).BeginInit();
            this.panelAutomati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutomati)).BeginInit();
            this.panelBicikle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBicikle)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPocetna)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.panelPartneri);
            this.panelTop.Controls.Add(this.panelAutomati);
            this.panelTop.Controls.Add(this.panelBicikle);
            this.panelTop.Location = new System.Drawing.Point(20, 20);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);
            this.panelTop.Size = new System.Drawing.Size(660, 155);
            this.panelTop.TabIndex = 0;
            // 
            // panelPartneri
            // 
            this.panelPartneri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPartneri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panelPartneri.Controls.Add(this.lblBrPartneri);
            this.panelPartneri.Controls.Add(this.lblPartneri);
            this.panelPartneri.Controls.Add(this.pbPartneri);
            this.panelPartneri.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPartneri.Location = new System.Drawing.Point(450, 20);
            this.panelPartneri.Name = "panelPartneri";
            this.panelPartneri.Size = new System.Drawing.Size(190, 115);
            this.panelPartneri.TabIndex = 2;
            // 
            // lblBrPartneri
            // 
            this.lblBrPartneri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrPartneri.AutoSize = true;
            this.lblBrPartneri.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrPartneri.ForeColor = System.Drawing.Color.White;
            this.lblBrPartneri.Location = new System.Drawing.Point(150, 10);
            this.lblBrPartneri.Name = "lblBrPartneri";
            this.lblBrPartneri.Size = new System.Drawing.Size(30, 33);
            this.lblBrPartneri.TabIndex = 4;
            this.lblBrPartneri.Text = "0";
            // 
            // lblPartneri
            // 
            this.lblPartneri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPartneri.AutoSize = true;
            this.lblPartneri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartneri.ForeColor = System.Drawing.Color.White;
            this.lblPartneri.Location = new System.Drawing.Point(71, 89);
            this.lblPartneri.Name = "lblPartneri";
            this.lblPartneri.Size = new System.Drawing.Size(102, 19);
            this.lblPartneri.TabIndex = 3;
            this.lblPartneri.Tag = "Broj partnera";
            this.lblPartneri.Text = "Broj partnera";
            // 
            // pbPartneri
            // 
            this.pbPartneri.Image = global::KorisnickiInterfejs.Properties.Resources.users;
            this.pbPartneri.Location = new System.Drawing.Point(20, 20);
            this.pbPartneri.Name = "pbPartneri";
            this.pbPartneri.Size = new System.Drawing.Size(60, 60);
            this.pbPartneri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPartneri.TabIndex = 2;
            this.pbPartneri.TabStop = false;
            // 
            // panelAutomati
            // 
            this.panelAutomati.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAutomati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panelAutomati.Controls.Add(this.lblBrAutomati);
            this.panelAutomati.Controls.Add(this.lblAutomati);
            this.panelAutomati.Controls.Add(this.pbAutomati);
            this.panelAutomati.Location = new System.Drawing.Point(235, 20);
            this.panelAutomati.Name = "panelAutomati";
            this.panelAutomati.Size = new System.Drawing.Size(190, 115);
            this.panelAutomati.TabIndex = 1;
            // 
            // lblBrAutomati
            // 
            this.lblBrAutomati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrAutomati.AutoSize = true;
            this.lblBrAutomati.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrAutomati.ForeColor = System.Drawing.Color.White;
            this.lblBrAutomati.Location = new System.Drawing.Point(150, 10);
            this.lblBrAutomati.Name = "lblBrAutomati";
            this.lblBrAutomati.Size = new System.Drawing.Size(30, 33);
            this.lblBrAutomati.TabIndex = 3;
            this.lblBrAutomati.Text = "0";
            // 
            // lblAutomati
            // 
            this.lblAutomati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutomati.AutoSize = true;
            this.lblAutomati.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutomati.ForeColor = System.Drawing.Color.White;
            this.lblAutomati.Location = new System.Drawing.Point(64, 89);
            this.lblAutomati.Name = "lblAutomati";
            this.lblAutomati.Size = new System.Drawing.Size(109, 19);
            this.lblAutomati.TabIndex = 2;
            this.lblAutomati.Tag = "Broj automata";
            this.lblAutomati.Text = "Broj automata";
            // 
            // pbAutomati
            // 
            this.pbAutomati.Image = global::KorisnickiInterfejs.Properties.Resources.automat;
            this.pbAutomati.Location = new System.Drawing.Point(20, 20);
            this.pbAutomati.Name = "pbAutomati";
            this.pbAutomati.Size = new System.Drawing.Size(60, 60);
            this.pbAutomati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAutomati.TabIndex = 1;
            this.pbAutomati.TabStop = false;
            // 
            // panelBicikle
            // 
            this.panelBicikle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBicikle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panelBicikle.Controls.Add(this.lblBrBicikle);
            this.panelBicikle.Controls.Add(this.lblBicikle);
            this.panelBicikle.Controls.Add(this.pbBicikle);
            this.panelBicikle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBicikle.Location = new System.Drawing.Point(20, 20);
            this.panelBicikle.Name = "panelBicikle";
            this.panelBicikle.Padding = new System.Windows.Forms.Padding(20);
            this.panelBicikle.Size = new System.Drawing.Size(190, 115);
            this.panelBicikle.TabIndex = 0;
            // 
            // lblBrBicikle
            // 
            this.lblBrBicikle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrBicikle.AutoSize = true;
            this.lblBrBicikle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrBicikle.ForeColor = System.Drawing.Color.White;
            this.lblBrBicikle.Location = new System.Drawing.Point(150, 10);
            this.lblBrBicikle.Name = "lblBrBicikle";
            this.lblBrBicikle.Size = new System.Drawing.Size(30, 33);
            this.lblBrBicikle.TabIndex = 2;
            this.lblBrBicikle.Text = "0";
            // 
            // lblBicikle
            // 
            this.lblBicikle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBicikle.AutoSize = true;
            this.lblBicikle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBicikle.ForeColor = System.Drawing.Color.White;
            this.lblBicikle.Location = new System.Drawing.Point(90, 89);
            this.lblBicikle.Name = "lblBicikle";
            this.lblBicikle.Size = new System.Drawing.Size(83, 19);
            this.lblBicikle.TabIndex = 1;
            this.lblBicikle.Tag = "Broj bicikli";
            this.lblBicikle.Text = "Broj bicikli";
            // 
            // pbBicikle
            // 
            this.pbBicikle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pbBicikle.Image = global::KorisnickiInterfejs.Properties.Resources.bicikla;
            this.pbBicikle.InitialImage = null;
            this.pbBicikle.Location = new System.Drawing.Point(20, 20);
            this.pbBicikle.Name = "pbBicikle";
            this.pbBicikle.Size = new System.Drawing.Size(60, 60);
            this.pbBicikle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBicikle.TabIndex = 0;
            this.pbBicikle.TabStop = false;
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.pbPocetna);
            this.panelBottom.Location = new System.Drawing.Point(20, 196);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(660, 235);
            this.panelBottom.TabIndex = 1;
            // 
            // pbPocetna
            // 
            this.pbPocetna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPocetna.Image = global::KorisnickiInterfejs.Properties.Resources.machine;
            this.pbPocetna.Location = new System.Drawing.Point(0, 0);
            this.pbPocetna.Name = "pbPocetna";
            this.pbPocetna.Size = new System.Drawing.Size(660, 235);
            this.pbPocetna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPocetna.TabIndex = 0;
            this.pbPocetna.TabStop = false;
            // 
            // UCPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "UCPocetna";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(700, 450);
            this.panelTop.ResumeLayout(false);
            this.panelPartneri.ResumeLayout(false);
            this.panelPartneri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPartneri)).EndInit();
            this.panelAutomati.ResumeLayout(false);
            this.panelAutomati.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutomati)).EndInit();
            this.panelBicikle.ResumeLayout(false);
            this.panelBicikle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBicikle)).EndInit();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPocetna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelBicikle;
        private System.Windows.Forms.Panel panelPartneri;
        private System.Windows.Forms.Panel panelAutomati;
        private System.Windows.Forms.PictureBox pbBicikle;
        private System.Windows.Forms.PictureBox pbAutomati;
        private System.Windows.Forms.PictureBox pbPartneri;
        private System.Windows.Forms.Label lblBicikle;
        private System.Windows.Forms.Label lblBrBicikle;
        private System.Windows.Forms.Label lblBrPartneri;
        private System.Windows.Forms.Label lblPartneri;
        private System.Windows.Forms.Label lblBrAutomati;
        private System.Windows.Forms.Label lblAutomati;
        private PictureBox pbPocetna;

        public Panel PanelTop { get => panelTop; set => panelTop = value; }
        public Panel PanelBottom { get => panelBottom; set => panelBottom = value; }
        public Panel PanelBicikle { get => panelBicikle; set => panelBicikle = value; }
        public Panel PanelPartneri { get => panelPartneri; set => panelPartneri = value; }
        public Panel PanelAutomati { get => panelAutomati; set => panelAutomati = value; }
        public PictureBox PbBicikle { get => pbBicikle; set => pbBicikle = value; }
        public PictureBox PbAutomati { get => pbAutomati; set => pbAutomati = value; }
        public PictureBox PbPartneri { get => pbPartneri; set => pbPartneri = value; }
        public Label LblBicikle { get => lblBicikle; set => lblBicikle = value; }
        public Label LblBrBicikle { get => lblBrBicikle; set => lblBrBicikle = value; }
        public Label LblBrPartneri { get => lblBrPartneri; set => lblBrPartneri = value; }
        public Label LblPartneri { get => lblPartneri; set => lblPartneri = value; }
        public Label LblBrAutomati { get => lblBrAutomati; set => lblBrAutomati = value; }
        public Label LblAutomati { get => lblAutomati; set => lblAutomati = value; }
    }
}
