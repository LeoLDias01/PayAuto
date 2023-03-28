using PayAuto.Business.Services;
using PayAuto.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayAuto.Screens
{
    public partial class frmSimpleSearch : Form
    {
        public PayAutoGeneralService generalService = new PayAutoGeneralService();
        public string link;

        public frmSimpleSearch()
        {
            InitializeComponent();
        }

        private void frmSimpleSearch_Load(object sender, EventArgs e)
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
               generalService.SimpleProcess(link: link, txtRenavam.Text.Trim(), txtPlaca.Text.Trim());

           });
        }
        private bool Validation()
        {
            if (txtRenavam.TextLength > 9 && txtPlaca.TextLength > 5 && link != string.Empty)
                return true;
            else
            {
                MessageBox.Show("Campos Inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
       

        private void txtRenavam_KeyPress(object sender, KeyPressEventArgs e)
        {
            LockingNumberKey(e);
        }
        private void btnSearchAddress_Click(object sender, EventArgs e)
        {
            SettingComboValue();
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            LockingNumberKey(e);
        }
        private void LockingNumberKey(KeyPressEventArgs eventArgs)
        {
            if (!char.IsControl(eventArgs.KeyChar) && !char.IsDigit(eventArgs.KeyChar) && (eventArgs.KeyChar != '.'))
                eventArgs.Handled = true;
        }
        private async Task SettingComboValue()
        {
            await generalService.ApiGet(txtCep.Text);
            cmbUf.SelectedText = generalService.address.Uf.ToString();
            await SetStatesDep();  
        }
        private void cmbUf_TextChanged(object sender, EventArgs e)
        {
           SetStatesDep();
        }
        private async Task SetStatesDep()
        {
            if (cmbUf.SelectedText == "SP")
            {
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
                pnlChassi.Visible = false;
            }
            else if (cmbUf.SelectedText == "AC")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "AL")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "AP")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "AM")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "BA")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "CE")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "DF")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "ES")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "GO")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "MA")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "MT")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "MS")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "MG")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "PA")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "PB")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "PR")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "PE")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "PI")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "RJ")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "RN")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "RS")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "RO")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "RR")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "SC")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "SE")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else if (cmbUf.SelectedText == "TO")
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
        }
    }
}
