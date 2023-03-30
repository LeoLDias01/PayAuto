
using PayAuto.Domain.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.ConstrainedExecution;
using System.Net.Http.Json;
using System.Net.Mail;

namespace PayAuto.Business.Services
{
    public class PayAutoGeneralService
    {
        public PayAutoSPService spService = new PayAutoSPService();
        public AddressResponse address;

        public async Task ApiGet(string cep)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri("https://viacep.com.br");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync($"/ws/{cep}/json");
                if (response.IsSuccessStatusCode)
                {
                    address = await response.Content.ReadFromJsonAsync<AddressResponse>();
                }
            }
        }

        public void SimpleProcess(string link, string renavam, string placa)
        {
            spService.Start(link);
            spService.DataInsert(renavam, placa);
            spService.Archives();
        }
        public void MandaEmail(string emailToSend, string summary, string description, string ip, string hostname)
        {
            SmtpClient client = new SmtpClient("smtp.concilig.com.br");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("enviolembretes@concilig.com.br", "3nv10##1319");
            client.EnableSsl = true;
            client.Credentials = credentials;

            try
            {
                var mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress("enviolembretes@concilig.com.br");
                mail.To.Add(new System.Net.Mail.MailAddress(emailToSend));

                mail.Subject = "PAYAUTO - USER REPORT";
                mail.IsBodyHtml = true;
                mail.Body = $"Olá o usuário {hostname} sob o ip: {ip} <br>Reportou algo. <br>Resumo: {summary} <br>Descrição: {description}";

                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

    }
}
