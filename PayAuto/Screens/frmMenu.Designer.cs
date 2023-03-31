namespace PayAuto.Screens
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblSaudation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMultipleSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSimpleSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCredits = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaudation
            // 
            this.lblSaudation.AutoSize = true;
            this.lblSaudation.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaudation.ForeColor = System.Drawing.Color.White;
            this.lblSaudation.Location = new System.Drawing.Point(12, 11);
            this.lblSaudation.Name = "lblSaudation";
            this.lblSaudation.Size = new System.Drawing.Size(258, 25);
            this.lblSaudation.TabIndex = 3;
            this.lblSaudation.Text = "Olá bom dia, do que precisa?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMultipleSearch, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSimpleSearch, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 315);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::PayAuto.Properties.Resources.logout256_24927;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(3, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(263, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMultipleSearch
            // 
            this.btnMultipleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMultipleSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultipleSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultipleSearch.FlatAppearance.BorderSize = 2;
            this.btnMultipleSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMultipleSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipleSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleSearch.ForeColor = System.Drawing.Color.White;
            this.btnMultipleSearch.Image = global::PayAuto.Properties.Resources.tools_terminal_rabbit_12989;
            this.btnMultipleSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMultipleSearch.Location = new System.Drawing.Point(3, 218);
            this.btnMultipleSearch.Name = "btnMultipleSearch";
            this.btnMultipleSearch.Size = new System.Drawing.Size(263, 44);
            this.btnMultipleSearch.TabIndex = 2;
            this.btnMultipleSearch.Text = "Consulta em Lote";
            this.btnMultipleSearch.UseVisualStyleBackColor = false;
            this.btnMultipleSearch.Click += new System.EventHandler(this.btnMultipleSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PayAuto.Properties.Resources.robo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSimpleSearch
            // 
            this.btnSimpleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSimpleSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpleSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSimpleSearch.FlatAppearance.BorderSize = 2;
            this.btnSimpleSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSimpleSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpleSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpleSearch.ForeColor = System.Drawing.Color.White;
            this.btnSimpleSearch.Image = global::PayAuto.Properties.Resources.search_Dir__White_32x32;
            this.btnSimpleSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpleSearch.Location = new System.Drawing.Point(3, 168);
            this.btnSimpleSearch.Name = "btnSimpleSearch";
            this.btnSimpleSearch.Size = new System.Drawing.Size(263, 44);
            this.btnSimpleSearch.TabIndex = 1;
            this.btnSimpleSearch.Text = "Consulta Simples";
            this.btnSimpleSearch.UseVisualStyleBackColor = false;
            this.btnSimpleSearch.Click += new System.EventHandler(this.btnSimpleSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblCredits);
            this.panel1.Location = new System.Drawing.Point(12, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 30);
            this.panel1.TabIndex = 4;
            // 
            // lblCredits
            // 
            this.lblCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCredits.ForeColor = System.Drawing.Color.White;
            this.lblCredits.Location = new System.Drawing.Point(51, 11);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(173, 15);
            this.lblCredits.TabIndex = 5;
            this.lblCredits.Text = "Copyright@ Leonardo Dias Leal";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(293, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSaudation);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaudation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMultipleSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSimpleSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCredits;
    }
}