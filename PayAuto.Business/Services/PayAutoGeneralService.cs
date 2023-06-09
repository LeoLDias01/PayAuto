﻿
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
        #region ..:: Instances ::..
        public PayAutoSPService spService = new PayAutoSPService();
        #endregion

        #region ..:: Variables ::..
        public AddressResponse address;
        #endregion

        #region ..:: API Call ::..

        /// <summary>
        /// Getting Api Values based on Cep Parameter cep
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
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
                else
                    MessageBox.Show("Erro da API");
            }
        }
        #endregion

        #region ..:: Automation ::..
        /// <summary>
        ///  Just one search 
        /// </summary>
        /// <param name="renavam"></param>
        /// <param name="licensePlate"></param>
        /// <param name="states"></param>
        public void SimpleProcess(string renavam, string licensePlate, States states)
        {
            if (states == States.SP)
            {
                // Opening the link
                spService.Start(GetStateLink(states));
                // Insert values on fields 
                spService.DataInsert(renavam, licensePlate);
                // Action to start a download
                spService.Archives();
            }
        }

        /// <summary>
        /// Search based on achive rows 
        /// </summary>
        /// <param name="renavam"></param>
        /// <param name="licensePlate"></param>
        /// <param name="states"></param>
        public void MultipleProcess(string renavam, string licensePlate, States states)
        {
            if (states == States.SP)
            {
                // Opening the link
                spService.Start(GetStateLink(states));
                // Insert values on fields 
                spService.DataInsert(renavam, licensePlate);
                // Action to start a download
                spService.Archives();
            }
        }

        /// <summary>
        /// state discover
        /// </summary>
        /// <param name="states"></param>
        /// <returns></returns>
        public string GetStateLink(States states)
        {
            string link;
            if (states == States.SP)
                link = "https://www.ipva.fazenda.sp.gov.br/ipvanet_consulta/consulta.aspx";
            else
                link = "";

            return link;
        }

        #endregion

        #region ..:: Mailer ::..

        /// <summary>
        /// Sending mail
        /// </summary>
        /// <param name="emailToSend"></param>
        /// <param name="summary"></param>
        /// <param name="description"></param>
        /// <param name="ip"></param>
        /// <param name="hostname"></param>
        public void SendEmail(string emailToSend, string summary, string description, string ip, string hostname)
        {
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("zpayautoma.disparos2023@outlook.com", "PayAuto@2023");
            client.EnableSsl = true;
            client.Credentials = credentials;
            try
            {
                var mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress("zpayautoma.disparos2023@outlook.com");
                mail.To.Add(new System.Net.Mail.MailAddress(emailToSend));

                mail.Subject = "PAYAUTO - USER REPORT";
                mail.IsBodyHtml = true;
                mail.Body = $"Olá, <br>O usuário {hostname}<br>Sob o ip: {ip} <br>Reportou algo. <br>Resumo: {summary} <br>Descrição: {description}";

                client.Send(mail);
                MessageBox.Show("E-mail enviado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        #endregion
    }
}
