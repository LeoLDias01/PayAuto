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
        public int link;

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
            if (EmailValidation())
                SendEmail();

        }
        private void StartProcess()
        {
             Task.Run(() =>
            {
                generalService.SimpleProcess(link: SetStatesDep(), txtRenavam.Text.Trim(), txtPlaca.Text.Trim());

            });
        }
        private bool Validation()
        {
            if (txtRenavam.TextLength > 9 && txtPlaca.TextLength > 5)
                return true;
            else
            {
                MessageBox.Show("Campos Inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }     
        }
        private bool EmailValidation()
        {
            Regex emailRegex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (emailRegex.IsMatch(txtEmail.Text))
                return true;
            else
                return false;
        }
        private void SendEmail()
        {

        }
        private string SetStatesDep()
        {
            string state = "SP";

            if (state == "SP")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
           else if  (state == "AC")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "AL")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "AP")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "AM")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "BA")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "CE")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "DF")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "ES")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "GO")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "MA")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "MT")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "MS")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "MG")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "PA")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "PB")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "PR")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "PE")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "PI")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "RJ")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "RN")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "RS")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "RO")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "RR")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "SC")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "SE")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (state == "TO")
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else
                return "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
        }

        private void txtRenavam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generalService.ApiCall(txtCep.Text);
        }
    }
}
