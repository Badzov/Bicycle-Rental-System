using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    partial class UCUbaciLokacija
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
            this.txtOpstina = new System.Windows.Forms.TextBox();
            this.lblOpstina = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblUbaci = new System.Windows.Forms.Label();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOpstina
            // 
            this.txtOpstina.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpstina.Location = new System.Drawing.Point(15, 170);
            this.txtOpstina.Multiline = true;
            this.txtOpstina.Name = "txtOpstina";
            this.txtOpstina.Size = new System.Drawing.Size(202, 30);
            this.txtOpstina.TabIndex = 28;
            // 
            // lblOpstina
            // 
            this.lblOpstina.AutoSize = true;
            this.lblOpstina.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpstina.Location = new System.Drawing.Point(15, 149);
            this.lblOpstina.Name = "lblOpstina";
            this.lblOpstina.Size = new System.Drawing.Size(55, 16);
            this.lblOpstina.TabIndex = 27;
            this.lblOpstina.Text = "Opština:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(15, 107);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(202, 30);
            this.txtNaziv.TabIndex = 26;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(15, 86);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(42, 16);
            this.lblNaziv.TabIndex = 25;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblUbaci
            // 
            this.lblUbaci.AutoSize = true;
            this.lblUbaci.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbaci.Location = new System.Drawing.Point(58, 26);
            this.lblUbaci.Name = "lblUbaci";
            this.lblUbaci.Size = new System.Drawing.Size(144, 22);
            this.lblUbaci.TabIndex = 29;
            this.lblUbaci.Text = "Ubaci Lokaciju";
            // 
            // btnUbaci
            // 
            this.btnUbaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnUbaci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbaci.FlatAppearance.BorderSize = 0;
            this.btnUbaci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnUbaci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnUbaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbaci.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbaci.ForeColor = System.Drawing.Color.White;
            this.btnUbaci.Location = new System.Drawing.Point(77, 248);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(105, 37);
            this.btnUbaci.TabIndex = 30;
            this.btnUbaci.Text = "UBACI";
            this.btnUbaci.UseVisualStyleBackColor = false;
            this.btnUbaci.Click += new System.EventHandler(this.btnUbaci_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(237, 5);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 18);
            this.lblX.TabIndex = 31;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // UCUbaciLokacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnUbaci);
            this.Controls.Add(this.lblUbaci);
            this.Controls.Add(this.txtOpstina);
            this.Controls.Add(this.lblOpstina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UCUbaciLokacija";
            this.Size = new System.Drawing.Size(260, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpstina;
        private System.Windows.Forms.Label lblOpstina;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblUbaci;
        private System.Windows.Forms.Button btnUbaci;
        private Label lblX;

        public TextBox TxtOpstina { get => txtOpstina; set => txtOpstina = value; }
        public Label LblOpstina { get => lblOpstina; set => lblOpstina = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public Label LblUbaci { get => lblUbaci; set => lblUbaci = value; }
        public Button BtnUbaci { get => btnUbaci; set => btnUbaci = value; }
    }
}
