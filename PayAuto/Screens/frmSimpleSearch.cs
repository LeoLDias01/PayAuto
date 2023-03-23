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

namespace PayAuto.Screens
{
    public partial class frmSimpleSearch : Form
    {
        public PayAutoGeneralService generalService = new PayAutoGeneralService();

        public frmSimpleSearch()
        {
            InitializeComponent();
        }

        private void frmSimpleSearch_Load(object sender, EventArgs e)
        {
            SearchStates();
        }
        public void SearchStates() 
        {
           
        }

        private void btnSimpleSearch_Click(object sender, EventArgs e)
        {
            if (Validation())
                StartProcess();





           
        }
        private void StartProcess()
        {
             Task.Run(() =>
            {
                generalService.SimpleProcess("https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx");

            });
        }
        private bool Validation()
        {
            Regex emailRegex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (txtRenavam.TextLength > 9 && txtPlaca.TextLength > 5)
                return true;
            else
            {
                MessageBox.Show("Campos Inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
                   
        }
    }
}

//if (emailRegex.IsMatch(txtEmail.Text))