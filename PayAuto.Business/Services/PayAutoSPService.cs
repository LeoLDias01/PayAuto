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

namespace PayAuto.Business.Services
{
    public class PayAutoSPService
    {
        public Chrome chrome;
        public Firefox firefox;
        public void Start(string link)
        {
            try
            {
                // Define o Chrome como navegador
                chrome = new Chrome(InterfaceType.NoUserInterface, isAdministrator: false);

                // Manter a janela maximizada
                chrome.Driver.Manage().Window.Maximize();

                // Entra no Link
                chrome.Navegacao(link);
            }
            catch
            {
                try 
                {
                    // Define o Chrome como navegador
                    firefox = new Firefox(InterfaceType.NoUserInterface, isAdministrator: false);

                    // Manter a janela maximizada
                    firefox.Driver.Manage().Window.Maximize();

                    // Entra no Link
                    firefox.Navegacao(link);

                }
                catch
                {
                    try
                    {
                        //tenta no explorer
                        MessageBox.Show("Nenhum dos browsers foi encontrado!");
                    }
                    catch 
                    {
                        MessageBox.Show("Nenhum dos browsers foi encontrado!");
                    }
                }
            }
        }
        public void Logon() 
        { 
        
        
        
        }
    }
}
