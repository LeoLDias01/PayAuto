using PayAuto.Selenium.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PayAuto.Domain.Models
{
    public static class BrowserNavi
    {
        public static IWebBrowserBase Navi(this IWebBrowserBase webBrowser, string url)
        {

            webBrowser.Navigate(url);

            return webBrowser;
        }

        public static IWebBrowserBase LoginSp(this IWebBrowserBase webBrowser, string renavam, string placa)
        {
            // Preenche dados de acesso
            webBrowser.SetValue(@"//*[@id='conteudoPaginaPlaceHolder_txtRenavam']", renavam);
            Thread.Sleep(500);

            webBrowser.SetValue(@"//*[@id='conteudoPaginaPlaceHolder_txtPlaca']", placa);
            Thread.Sleep(500);
            var retorno = webBrowser.CustomFindElementXPath(@"//*[@title='reCAPTCHA']");
            string retornaDados = retorno.GetAttribute("name");
            webBrowser.SwitchToFrame(retornaDados);
            webBrowser.WaitUntil(
                nav => nav.CustomFindElementXPath(@"//*[contains(@class,'recaptcha-checkbox-checked')]") != null,
                timeout: 120);

            webBrowser.Driver.SwitchTo().DefaultContent();
            webBrowser.Click(@"//*[@id='conteudoPaginaPlaceHolder_btn_Consultar']");

            return webBrowser;
        }

        public static IWebBrowserBase GenerateArchive(this IWebBrowserBase webBrowser)
        {

            // Clicar no botão de impressão, aguardar nova janela abrir
            webBrowser.Click(@"//*[@id='conteudoPaginaPlaceHolder_btn_Imprimir']");
            webBrowser.WaitUntilLoaded();
            return webBrowser;
        }
    }
}
