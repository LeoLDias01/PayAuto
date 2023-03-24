using PayAuto.Selenium.Domain;
using PayAuto.Domain.Models;
using PayAuto.Selenium.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayAuto.Business.Services
{
    public class PayAutoSPService
    {
        public Chrome chrome;
        public Firefox firefox;
        public void Start(string link)
        {
            chrome = new Chrome(InterfaceType.OnlyBrowser, isAdministrator: false);
           // firefox = new Firefox(InterfaceType.OnlyBrowser, isAdministrator: false);
            try
            {
                chrome.Driver.Manage().Window.Maximize();
                chrome.Navegacao(link);
            }
            catch
            {
                MessageBox.Show("Nenhum dos browsers foi encontrado!");
            }
        }
        public void DataInsert(string renavam, string placa)
        {
            try
            {
                chrome.LoginSp(renavam.Trim(), placa.Trim());
            }
            catch
            {

            }
        }
        public void Archives() 
        { 
            chrome.GeraArquivoSp();
        }
    }
}
