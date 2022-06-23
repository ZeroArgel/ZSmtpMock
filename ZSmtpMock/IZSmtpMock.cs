namespace ZSmtpMock
{
    using System.Net.Mail;
    public interface IZSmtpMock
    {
        void Send(MailMessage mailMessage);

        enum Port
        {
            P25 = 25,
            P587 = 587
        }
    }
}