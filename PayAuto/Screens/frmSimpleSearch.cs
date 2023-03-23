using PayAuto.Business.Services;
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
           generalService.ApiCall(ref cmbUf);
        }

        private void btnSimpleSearch_Click(object sender, EventArgs e)
        {

        }
        private void ValidaCampos()
        {
            Task.Run(() =>
            {


            });
        }
    }
}
