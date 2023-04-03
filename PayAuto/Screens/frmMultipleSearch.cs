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
        public List<WorksheetRows> worksheetRows = new List<WorksheetRows>();
        public PayAutoGeneralService generalService = new PayAutoGeneralService();

        public frmMultipleSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtArchiveLocation.Text = ofd.FileName;
                Import(location: ofd.FileName);
            }
            else
                MessageBox.Show("Não foi possível localizar arquivo por erro interno", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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
                    var renavam = long.Parse(worksheet.Cell($"A{line}").Value.ToString());
                    var licensePlate = worksheet.Cell($"B{line}").Value.ToString();
                    var chassi = worksheet.Cell($"C{line}").Value.ToString();
                    var uf = worksheet.Cell($"D{line}").Value.ToString();
                    worksheetRows.Add(new WorksheetRows() { Renavam = renavam,
                                                            LicensePlate = licensePlate,
                                                            Chassi = chassi,
                                                            Uf = uf});
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
        private void btnHelp_Click(object sender, EventArgs e)
        {
            new frmSupport().ShowDialog();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvImport.DataSource = null;
            txtArchiveLocation.Clear();
            worksheetRows = null;
        }

        private void btnMultSearch_Click(object sender, EventArgs e)
        {
            foreach (var item in worksheetRows)
            {
                if (item.Uf == "SP")
                    generalService.MultipleProcess(item.Renavam.ToString(), item.LicensePlate, States.SP);
                else
                    MessageBox.Show("UF Inválida, favor utilizar as uf's Disponíveis", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
