using PayAuto.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PayAuto.Screens
{
    public partial class frmSupport : Form
    {
        public PayAutoGeneralService generalService = new PayAutoGeneralService();

        public frmSupport()
        {
            InitializeComponent();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtDesc.Clear();
            txtDetail.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(Validation())
                generalService.MandaEmail(emailToSend: "", summary: "", description: "", ip: "", hostname: "");
        }
        private bool Validation()
        {
            Regex regexEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (regexEmail.IsMatch(txtEmail.Text))
            {
                if (txtDesc.TextLength > 3 && txtDetail.TextLength > 5)
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
    }
}
