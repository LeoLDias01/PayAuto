using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayAuto.Screens
{
    public partial class frmMenu : Form
    {
        #region ..:: Constructor ::..

        public frmMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region ..:: Events ::..

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ShowSaudation();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exiting the application
            Application.Exit();
        }
        private void btnSimpleSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CONSULTA DISPONÍVEL APENAS PARA 'SP'", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            new frmSimpleSearch().ShowDialog();
        }
        private void btnMultipleSearch_Click(object sender, EventArgs e)
        {
            new frmMultipleSearch().ShowDialog();
        }

        #endregion

        #region ..:: Methods ::..

        /// <summary>
        /// Showing saudation based on time
        /// </summary>
        private void ShowSaudation()
        {
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
                lblSaudation.Text = "Olá! Bom dia, do que precisa?";
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                lblSaudation.Text = "Olá! Boa tarde, do que precisa?";
            else
                lblSaudation.Text = "Olá! Boa noite, do que precisa?";
        }

        #endregion

    }
}
