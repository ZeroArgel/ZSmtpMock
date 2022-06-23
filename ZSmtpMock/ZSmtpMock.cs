namespace ZSmtpMock
{
    using System.Net.Mail;
    public class ZSmtpMock : IZSmtpMock
    {
        public SmtpClient SmtpClient { get; set; }
        public ZSmtpMock(string host, Port port)
        {
            SmtpClient = new SmtpClient(host, (int)port);
        }
        public ZSmtpMock(string host, int port)
        {
            SmtpClient = new SmtpClient(host, port);
        }
        public void Send(MailMessage mailMessage)
        {
            SmtpClient.Send(mailMessage);
        }
        public enum Port
        {
            P25 = 25,
            P587 = 587
        }
    }
}