using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using PayAuto.Business.Services;
using PayAuto.Domain.Models;
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
    public partial class frmMultipleSearch : Form
    {
        #region ..:: Instances ::..
        public List<WorksheetRows> worksheetRows = new List<WorksheetRows>();
        public PayAutoGeneralService generalService = new PayAutoGeneralService();
        #endregion

        #region ..:: Constructor ::..

        public frmMultipleSearch()
        {
            InitializeComponent();
        }

        #endregion

        #region ..:: Events ::..
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Searching data archive
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Archive location
                txtArchiveLocation.Text = ofd.FileName;
                // Import
                Import(location: ofd.FileName);
            }
            else
                MessageBox.Show("Não foi possível localizar arquivo por erro interno", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            new frmSupport().ShowDialog();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Cleaning Fields
            dgvImport.DataSource = null;
            txtArchiveLocation.Clear();
            worksheetRows = null;
        }

        private void btnMultSearch_Click(object sender, EventArgs e)
        {
            // Processing archive rows
            foreach (var item in worksheetRows)
            {
                if (item.Uf == "SP")
                    generalService.MultipleProcess(item.Renavam.ToString(), item.LicensePlate, States.SP);
                else
                    MessageBox.Show("UF Inválida, favor utilizar as uf's Disponíveis", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ..:: General Methods ::..

        // Importing 
        private void Import(string location)
        {
            var xls = new XLWorkbook(location);
            var worksheet = xls.Worksheets.First(w => w.Name == "Planilha1");
            var totalRows = worksheet.Rows().Count();

            // The first line is used to header
            for (int line = 2; line <= totalRows; line++)
            {
                try
                {
                    // Setting values 
                    var renavam = worksheet.Cell($"A{line}").Value.ToString();
                    var licensePlate = worksheet.Cell($"B{line}").Value.ToString();
                    var chassi = worksheet.Cell($"C{line}").Value.ToString();
                    var uf = worksheet.Cell($"D{line}").Value.ToString();
                    worksheetRows.Add(new WorksheetRows() { Renavam = renavam.Trim(),
                                                            LicensePlate = licensePlate.Trim(),
                                                            Chassi = chassi.Trim(),
                                                            Uf = uf.Trim()});
                }
                catch 
                {
                    MessageBox.Show("Erro no formato do arquivo", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
 
            dgvImport.DataSource = null;
            dgvImport.AutoGenerateColumns = false;
            dgvImport.DataSource = worksheetRows;

            if (dgvImport.Rows.Count < 1)
                btnMultSearch.Enabled = false;
            else
                btnMultSearch.Enabled = true;
        }
        #endregion
    }
}
