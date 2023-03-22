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
    public partial class frmLoading : Form
    {
        #region ..:: Instances ::..

        private readonly Timer timer = new Timer();

        #endregion

        #region ..:: Constructor ::..
        public frmLoading()
        {
            InitializeComponent();
            timer.Interval = 3000; // Set Interval in miliseconds
            timer.Tick += TimerTick; // When timer stop, we execute this method
        }
        #endregion

        #region ..:: Events ::..
        private void frmLoading_Load(object sender, EventArgs e)
        {
            ShowVersion();
            timer.Start();
        }
        #endregion

        #region ..:: General Methods ::..

        /// <summary>
        /// Showing system version
        /// </summary>
        private void ShowVersion()
        {
            lblShowVersion.Text = "Version:  " + Application.ProductVersion;
        }

        /// <summary>
        /// Showing Menu after timer is stopped
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();
            new frmMenu().ShowDialog();
        }

        #endregion
    }
}
