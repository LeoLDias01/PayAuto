using PayAuto.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PayAuto.Screens
{
    public partial class frmSupport : Form
    {
        #region ..:: Instances ::..

        public PayAutoGeneralService generalService = new PayAutoGeneralService();

        #endregion

        #region ..:: Constructor ::..
        public frmSupport()
        {
            InitializeComponent();
        }
        #endregion

        #region ..:: Events::..

        private void btnErase_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            if (Validation())
                generalService.SendEmail(emailToSend: txtEmail.Text.Trim(), summary: txtDesc.Text, description: txtDetail.Text, ip: ip[1].ToString(), hostname: Dns.GetHostName().ToString());
            Cursor = Cursors.Default;
            this.Enabled = true;
            Clear();
        }

        #endregion

        #region ..:: General Methods ::..
        private bool Validation()
        {
            Regex regexEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (regexEmail.IsMatch(txtEmail.Text))
            {
                if (txtDesc.TextLength > 3  && txtDetail.TextLength > 5)
                    return true;
                else
                {
                    MessageBox.Show("Campos Inválidos, texto não correspopnde ao mínimo de caracteres aceito", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("E-mail inválido", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void Clear()
        {
            txtEmail.Clear();
            txtDesc.Clear();
            txtDetail.Clear();
        }
        #endregion
    }
}
