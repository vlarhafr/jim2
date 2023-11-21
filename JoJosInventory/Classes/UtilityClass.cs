using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;
using System;
using System.Security.Cryptography;
using System.Text;

namespace JoJosInventory.Classes
{
    public static class UtilityClass
    {
        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        public static async Task<string?> GetApiDataAsync(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
                catch (HttpRequestException e)
                {
                    return null;
                }
            }
        }
        public static bool CheckInternetConnection()
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("8.8.8.8", 1000); 
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool SendEmail(string destinatario, string subject, string body)
        {
            try
            {
                
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("info@jojo-s.com"); 
                mail.To.Add(destinatario);
                mail.Subject = subject;
                mail.Body = body;

                
                SmtpClient smtpClient = new SmtpClient("smtp.office365.com"); 
                smtpClient.Port = 25; 
                smtpClient.Credentials = new NetworkCredential("info@jojo-s.com", "Jojos2022$"); 
                smtpClient.EnableSsl = true; 

                
                smtpClient.Send(mail);
                return true;
                //Console.WriteLine("Correo enviado con éxito.");
            }
            catch (Exception ex)
            {
                return false;
                //Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
