using PayAuto.Business.Services;
using PayAuto.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public string stateName;

        public frmSimpleSearch()
        {
            InitializeComponent();
        }

        private void frmSimpleSearch_Load(object sender, EventArgs e)
        {
            cmbUf.SelectedIndex = 0;
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
            stateName = generalService.address.Uf.ToString();
            SelectState();
        }
        private void SelectState()
        {
            if (stateName.Trim() == "SP")
                cmbUf.SelectedIndex = 25;
            else if (stateName.Trim() == "AC")
                cmbUf.SelectedIndex = 1;
            else if (stateName.Trim() == "AL")
                cmbUf.SelectedIndex = 2;
            else if (stateName.Trim() == "AP")
                cmbUf.SelectedIndex = 3;
            else if (stateName.Trim() == "AM")
                cmbUf.SelectedIndex = 4;
            else if (stateName.Trim() == "BA")
                cmbUf.SelectedIndex = 5;
            else if (stateName.Trim() == "CE")
                cmbUf.SelectedIndex = 6;
            else if (stateName.Trim() == "DF")
                cmbUf.SelectedIndex = 7;
            else if (stateName.Trim() == "ES")
                cmbUf.SelectedIndex = 8;
            else if (stateName.Trim() == "GO")
                cmbUf.SelectedIndex = 9;
            else if (stateName.Trim() == "MA")
                cmbUf.SelectedIndex = 10;
            else if (stateName.Trim() == "MT")
                cmbUf.SelectedIndex = 11;
            else if (stateName.Trim() == "MS")
                cmbUf.SelectedIndex = 12;
            else if (stateName.Trim() == "MG")
                cmbUf.SelectedIndex = 13;
            else if (stateName.Trim() == "PA")
                cmbUf.SelectedIndex = 14;
            else if (stateName.Trim() == "PB")
                cmbUf.SelectedIndex = 15;
            else if (stateName.Trim() == "PR")
                cmbUf.SelectedIndex = 16;
            else if (stateName.Trim() == "PE")
                cmbUf.SelectedIndex = 17;
            else if (stateName.Trim() == "PI")
                cmbUf.SelectedIndex = 18;
            else if (stateName.Trim() == "RJ")
                cmbUf.SelectedIndex = 19;
            else if (stateName.Trim() == "RN")
                cmbUf.SelectedIndex = 20;
            else if (stateName.Trim() == "RS")
                cmbUf.SelectedIndex = 21;
            else if (stateName.Trim() == "RO")
                cmbUf.SelectedIndex = 22;
            else if (stateName.Trim() == "RR")
                cmbUf.SelectedIndex = 23;
            else if (stateName.Trim() == "SC")
                cmbUf.SelectedIndex = 24;
            else if (stateName.Trim() == "SE")
                cmbUf.SelectedIndex = 26;
            else if (stateName.Trim() == "TO")
                cmbUf.SelectedIndex = 27;
            else
                cmbUf.SelectedIndex = 0;
        }
        private void SettingStateDepartament()
        {
            if (cmbUf.SelectedIndex == 25)
            {
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
                SettingUsedComponents(renavam: true, placa: true, chassi: false, erase: true, process: true);
            } 
        }

        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUf.SelectedIndex == 0)
                SettingUsedComponents(renavam: false, placa: false, chassi: false, erase: false, process: false);
            else
            SettingStateDepartament();
        }
        private void SettingUsedComponents(bool renavam, bool placa, bool chassi, bool erase, bool process)
        {
            pnlRenavam.Visible  = renavam;
            pnlPlaca.Visible    = placa;
            pnlChassi.Visible   = chassi;
            btnClean.Visible = erase;
            btnSimpleSearch.Enabled = process;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCep.Clear();
            cmbUf.SelectedIndex = 0;
            txtRenavam.Clear();
            txtPlaca.Clear();
            txtChassi.Clear();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new frmSupport().Show();
        }
    }
}