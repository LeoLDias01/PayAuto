namespace PayAuto.Screens
{
    partial class frmSimpleSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimpleSearch));
            this.btnSimpleSearch = new System.Windows.Forms.Button();
            this.lblChassi = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtRenavam = new System.Windows.Forms.TextBox();
            this.lblRenavam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.btnSearchAddress = new System.Windows.Forms.Button();
            this.gpbAddress = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRenavam = new System.Windows.Forms.Panel();
            this.pnlPlaca = new System.Windows.Forms.Panel();
            this.pnlChassi = new System.Windows.Forms.Panel();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.gpbAddress.SuspendLayout();
            this.gpbInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlRenavam.SuspendLayout();
            this.pnlPlaca.SuspendLayout();
            this.pnlChassi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimpleSearch
            // 
            this.btnSimpleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpleSearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSimpleSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpleSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSimpleSearch.ForeColor = System.Drawing.Color.White;
            this.btnSimpleSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpleSearch.Location = new System.Drawing.Point(14, 301);
            this.btnSimpleSearch.Name = "btnSimpleSearch";
            this.btnSimpleSearch.Size = new System.Drawing.Size(271, 42);
            this.btnSimpleSearch.TabIndex = 21;
            this.btnSimpleSearch.Text = "Processar";
            this.btnSimpleSearch.UseVisualStyleBackColor = false;
            this.btnSimpleSearch.Click += new System.EventHandler(this.btnSimpleSearch_Click);
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblChassi.ForeColor = System.Drawing.Color.White;
            this.lblChassi.Location = new System.Drawing.Point(3, 11);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(51, 20);
            this.lblChassi.TabIndex = 19;
            this.lblChassi.Text = "Chassi";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(3, 34);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(265, 23);
            this.txtPlaca.TabIndex = 18;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblPlaca.ForeColor = System.Drawing.Color.White;
            this.lblPlaca.Location = new System.Drawing.Point(3, 11);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(45, 20);
            this.lblPlaca.TabIndex = 17;
            this.lblPlaca.Text = "Placa";
            // 
            // txtRenavam
            // 
            this.txtRenavam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRenavam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenavam.Location = new System.Drawing.Point(4, 34);
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(258, 23);
            this.txtRenavam.TabIndex = 16;
            this.txtRenavam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRenavam_KeyPress);
            // 
            // lblRenavam
            // 
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblRenavam.ForeColor = System.Drawing.Color.White;
            this.lblRenavam.Location = new System.Drawing.Point(3, 11);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(72, 20);
            this.lblRenavam.TabIndex = 15;
            this.lblRenavam.Text = "Renavam";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(299, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 43);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ajuda";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(16, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 10);
            this.panel2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Digite seu CEP";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(112, 39);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(244, 23);
            this.txtCep.TabIndex = 29;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // btnSearchAddress
            // 
            this.btnSearchAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchAddress.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchAddress.FlatAppearance.BorderSize = 0;
            this.btnSearchAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchAddress.ForeColor = System.Drawing.Color.White;
            this.btnSearchAddress.Image = global::PayAuto.Properties.Resources.search_Dir__White_32x32;
            this.btnSearchAddress.Location = new System.Drawing.Point(362, 30);
            this.btnSearchAddress.Name = "btnSearchAddress";
            this.btnSearchAddress.Size = new System.Drawing.Size(36, 34);
            this.btnSearchAddress.TabIndex = 30;
            this.btnSearchAddress.UseVisualStyleBackColor = false;
            this.btnSearchAddress.Click += new System.EventHandler(this.btnSearchAddress_Click);
            // 
            // gpbAddress
            // 
            this.gpbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAddress.Controls.Add(this.label5);
            this.gpbAddress.Controls.Add(this.cmbUf);
            this.gpbAddress.Controls.Add(this.label6);
            this.gpbAddress.Controls.Add(this.txtCep);
            this.gpbAddress.Controls.Add(this.btnSearchAddress);
            this.gpbAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gpbAddress.ForeColor = System.Drawing.Color.White;
            this.gpbAddress.Location = new System.Drawing.Point(17, 28);
            this.gpbAddress.Name = "gpbAddress";
            this.gpbAddress.Size = new System.Drawing.Size(554, 79);
            this.gpbAddress.TabIndex = 32;
            this.gpbAddress.TabStop = false;
            this.gpbAddress.Text = "Identificando Uf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(416, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "UF";
            // 
            // cmbUf
            // 
            this.cmbUf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUf.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbUf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "<Selecione>",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbUf.Location = new System.Drawing.Point(448, 38);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(100, 23);
            this.cmbUf.TabIndex = 31;
            this.cmbUf.TextChanged += new System.EventHandler(this.cmbUf_TextChanged);
            // 
            // gpbInfo
            // 
            this.gpbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbInfo.Controls.Add(this.flowLayoutPanel1);
            this.gpbInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gpbInfo.ForeColor = System.Drawing.Color.White;
            this.gpbInfo.Location = new System.Drawing.Point(17, 113);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(554, 181);
            this.gpbInfo.TabIndex = 33;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Dados de Busca";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlRenavam);
            this.flowLayoutPanel1.Controls.Add(this.pnlPlaca);
            this.flowLayoutPanel1.Controls.Add(this.pnlChassi);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(548, 153);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlRenavam
            // 
            this.pnlRenavam.Controls.Add(this.txtRenavam);
            this.pnlRenavam.Controls.Add(this.lblRenavam);
            this.pnlRenavam.Location = new System.Drawing.Point(3, 3);
            this.pnlRenavam.Name = "pnlRenavam";
            this.pnlRenavam.Size = new System.Drawing.Size(265, 66);
            this.pnlRenavam.TabIndex = 34;
            // 
            // pnlPlaca
            // 
            this.pnlPlaca.Controls.Add(this.txtPlaca);
            this.pnlPlaca.Controls.Add(this.lblPlaca);
            this.pnlPlaca.Location = new System.Drawing.Point(274, 3);
            this.pnlPlaca.Name = "pnlPlaca";
            this.pnlPlaca.Size = new System.Drawing.Size(271, 66);
            this.pnlPlaca.TabIndex = 35;
            // 
            // pnlChassi
            // 
            this.pnlChassi.Controls.Add(this.txtChassi);
            this.pnlChassi.Controls.Add(this.lblChassi);
            this.pnlChassi.Location = new System.Drawing.Point(3, 75);
            this.pnlChassi.Name = "pnlChassi";
            this.pnlChassi.Size = new System.Drawing.Size(265, 66);
            this.pnlChassi.TabIndex = 36;
            // 
            // txtChassi
            // 
            this.txtChassi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChassi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChassi.Location = new System.Drawing.Point(4, 34);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(258, 23);
            this.txtChassi.TabIndex = 18;
            // 
            // frmSimpleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(580, 355);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.gpbAddress);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSimpleSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSimpleSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSimpleSearch";
            this.Load += new System.EventHandler(this.frmSimpleSearch_Load);
            this.gpbAddress.ResumeLayout(false);
            this.gpbAddress.PerformLayout();
            this.gpbInfo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlRenavam.ResumeLayout(false);
            this.pnlRenavam.PerformLayout();
            this.pnlPlaca.ResumeLayout(false);
            this.pnlPlaca.PerformLayout();
            this.pnlChassi.ResumeLayout(false);
            this.pnlChassi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSimpleSearch;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtRenavam;
        private System.Windows.Forms.Label lblRenavam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button btnSearchAddress;
        private System.Windows.Forms.GroupBox gpbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlRenavam;
        private System.Windows.Forms.Panel pnlPlaca;
        private System.Windows.Forms.Panel pnlChassi;
        private System.Windows.Forms.TextBox txtChassi;
    }
}