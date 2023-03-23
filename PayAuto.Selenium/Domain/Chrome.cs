using OpenQA.Selenium.Chrome;
using PayAuto.Selenium.Infra;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayAuto.Selenium.Domain
{
    public class Chrome : WebBrowserBase
    {
        public Chrome(
            InterfaceType @InterfaceType,
            bool isAdministrator = true,
            string downloadPath = "",
            bool configurePrinter = false,
           // bool randomUserAgent = false,
          //  bool isW3CCompliant = false,
            bool ignoreCertificateErrors = false
        )
        {
            var options = new ChromeOptions();
            var driverService = ChromeDriverService.CreateDefaultService();
           // var roboRepository = new RoboRepository();
           // var diretorioAutomacao = @"\\10.103.2.242\sistemagrc$\AUTOMACOES\GERAL";

            if (isAdministrator)
                foreach (var process in Process.GetProcessesByName("Chrome").Union(Process.GetProcessesByName("geckodriver")).ToList())
                    if (process.HasExited == false)
                        process.Kill();

            if (configurePrinter)
            {
                options.AddArgument("--kiosk --kiosk-printing");
                options.AddUserProfilePreference("printing.default_destination_selection_rules", "{\"kind\": \"local\", \"namePattern\": \"Save as PDF\"}");
                options.AddUserProfilePreference("printing.print_preview_sticky_settings.appState", "{\"recentDestinations\": [{\"id\": \"Save as PDF\", \"origin\": \"local\", \"account\": \"\"}],\"version\":2,\"isGcpPromoDismissed\":false,\"selectedDestinationId\":\"Save as PDF\"}");
                options.AddUserProfilePreference("print.always_print_silent", true);
            }

            if (@InterfaceType == InterfaceType.NoUserInterface)
            {
                options.AddArgument("--headless");
                driverService.HideCommandPromptWindow = true;
            }
          
            if (@InterfaceType == InterfaceType.OnlyBrowser)
                driverService.HideCommandPromptWindow = true;

            if (!string.IsNullOrEmpty(downloadPath))
            {
                DownloadPath = downloadPath;
                options.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 1);
                options.AddUserProfilePreference("savefile.default_directory", downloadPath);
                options.AddUserProfilePreference("download.default_directory", downloadPath);
                options.AddUserProfilePreference("download.prompt_for_download", false);
            }

            /* if (randomUserAgent)
             {
                 // Strings de user agent aleatório ajudam a diversificar a identidade da automação
                 var userAgentSorteado = roboRepository.RetornarUserAgent();

                 // Registrar no log o user agent sorteado
                 using (StreamWriter arquivo = new StreamWriter(Path.Combine(diretorioAutomacao, "log_useragent.txt"), true))
                 {
                     arquivo.WriteLine(String.Format("[{0}] Sorteado: {1}", DateTime.Now.ToString("dd/MM/yy - HH:mm:ss"), userAgentSorteado));
                 }

                 // Alterar user agent
                 options.AddArgument(String.Format("--user-agent={0}", userAgentSorteado));
             }

             // Evitar erro "handle must be a string". Atribuir false na propriedade não funciona.
             if (isW3CCompliant)
                 options.UseSpecCompliantProtocol = true;
            */

            // Ignorar erros de certificado
            if (ignoreCertificateErrors)
            {
                options.AddArgument("--ignore-ssl-errors=yes");
                options.AddArgument("--ignore-certificate-errors");
            }

            Driver = new ChromeDriver(driverService, options);
        }
    }
}
