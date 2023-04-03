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
        #region ..:: Instances ::..

        // General Service Instance
        public PayAutoGeneralService generalService = new PayAutoGeneralService();

        #endregion

        #region ..:: Variables ::..

        // State Name for Combo Options Select
        public string stateName;

        #endregion

        #region ..:: Constructor ::..
        public frmSimpleSearch()
        {
            InitializeComponent();
        }
        #endregion

        #region ..:: Events ::..

        private void frmSimpleSearch_Load(object sender, EventArgs e)
        {
            // Setting combo value to default
            cmbUf.SelectedIndex = 0;
        }
        private void btnSimpleSearch_Click(object sender, EventArgs e)
        {
            // Verifying fields and starting process 
            if (Validation())
                StartProcess();
        }
        private void txtRenavam_KeyPress(object sender, KeyPressEventArgs e)
        {
            LockingNumberKey(e);
        }
        private void btnSearchAddress_Click(object sender, EventArgs e)
        {
            GetAddress();
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
        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disable fields based on state
            if (cmbUf.SelectedIndex == 0)
                SettingUsedComponents(renavam: false, licensePlate: false, chassi: false, erase: false, process: false);
            else
                SettingStateDepartament();
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            new frmSupport().Show();
        }

        #endregion

        #region ..:: Methods ::..
        private void StartProcess()
        {
            States states  = StateSelected();

            Task.Run(() =>
           {
               generalService.SimpleProcess(txtRenavam.Text, txtPlaca.Text, states);
                   
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

        /// <summary>
        /// Taking data from API
        /// </summary>
        /// <returns></returns>
        private async Task GetAddress()
        {
            await generalService.ApiGet(txtCep.Text);
            stateName = generalService.address.Uf.ToString();
            SelectState();
        }

        /// <summary>
        /// State Select based on Api return
        /// </summary>
        private void SelectState()
        {
            if (stateName.Trim() == "SP")
                cmbUf.SelectedIndex = 1;
            else
                cmbUf.SelectedIndex = 0;
        }
        /// <summary>
        /// Fields enable
        /// </summary>
        private void SettingStateDepartament()
        {
            if (cmbUf.SelectedIndex == 1)
                SettingUsedComponents(renavam: true, licensePlate: true, chassi: false, erase: true, process: true);
             
            else
                MessageBox.Show("Consulta Disponível apenas para o estado de São Paulo \n Eventualmente será liberado para os demais estados", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Using parameters to set values to enable fields
        /// </summary>
        /// <param name="renavam"></param>
        /// <param name="licensePlate"></param>
        /// <param name="chassi"></param>
        /// <param name="erase"></param>
        /// <param name="process"></param>
        private void SettingUsedComponents(bool renavam, bool licensePlate, bool chassi, bool erase, bool process)
        {
            pnlRenavam.Visible  = renavam;
            pnlPlaca.Visible    = licensePlate;
            pnlChassi.Visible   = chassi;
            btnClean.Visible = erase;
            btnSimpleSearch.Enabled = process;
        }

        /// <summary>
        /// Cleaning fields
        /// </summary>
        private void Clear()
        {
            txtCep.Clear();
            cmbUf.SelectedIndex = 0;
            txtRenavam.Clear();
            txtPlaca.Clear();
            txtChassi.Clear();
        }
        private States StateSelected()
        {
            if (cmbUf.SelectedIndex == 1)
                return States.SP;
            else
                return States.SP;
        }
        #endregion
    }
}