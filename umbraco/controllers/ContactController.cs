/* using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

public class ContactController : SurfaceController
{
    public ContactController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
    }

    public string? isSend { get; set; }
    
    [HttpPost]
    public void PostMail()
    {
        var name = Request.Form["name"].ToString();
        var email = Request.Form["email"].ToString();
        var phone = Request.Form["phone"].ToString();
        var message = Request.Form["message"].ToString();

        try
        {
            SendMail(name, email, phone, message);
            isSend = "send";
            Console.WriteLine(isSend);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    } 
     
    public bool SendMail(string name, string email, string phone, string message_content)
    {
        MailMessage message = new MailMessage();
        message.From = new MailAddress("noreply@genesys-health.com");
        message.To.Add("seazkidayo@gmail.com");
        message.Subject = "Contact Mail";
        message.IsBodyHtml = true;
        message.Body = "<p>Name: " + name + "</p>" + "<p>Email: " + email + "</p>" + "<p>Phone: " + phone + "</p>" + "<p>Message: " + message_content + "</p>";

        using(SmtpClient smtpClient = new SmtpClient("smtp.office365.com"))
        {
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential("sayobami@genesys-health.com", "Intern@tional1");
            smtpClient.Send(message);
        }

        return true;
    }
} */

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
/* using Portfolio.Core.Models.ViewModels; */
using System.Threading.Tasks;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Configuration.Models;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Mail;
using Umbraco.Cms.Core.Models.Email;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;


namespace Portfolio.Core.Controllers.Surface
{
    public class ContactController : SurfaceController
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger<ContactController> _logger;
        private readonly GlobalSettings _globalSettings;

        public ContactController(
            IUmbracoContextAccessor umbracoContextAccessor, 
            IUmbracoDatabaseFactory databaseFactory, 
            ServiceContext services, 
            AppCaches appCaches, 
            IProfilingLogger profilingLogger, 
            IPublishedUrlProvider publishedUrlProvider, 
            IEmailSender emailSender, 
            ILogger<ContactController> logger, 
            IOptions<GlobalSettings> globalSettings)
            : base(umbracoContextAccessor, databaseFactory, 
                  services, appCaches, profilingLogger, 
                  publishedUrlProvider)
        {
            _emailSender = emailSender;
            _logger = logger;
            _globalSettings = globalSettings.Value;
        }

        public string? isSend { get; set; }

        [HttpPost]
        public async Task<IActionResult> PostMail(ContactViewModel model)
        {
            var name = Request.Form["name"].ToString();
            var email = Request.Form["email"].ToString();
            var phone = Request.Form["phone"].ToString();
            var message = Request.Form["message"].ToString();

            try
            {
                await SendEmail(name, email, phone, message);
                isSend = "send";
                Console.WriteLine(isSend);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                isSend = "failed";
                Console.WriteLine(isSend);
            }

            return RedirectToCurrentUmbracoPage();
        }

        public async Task<bool> SendEmail(string name, string email, string phone, string message_content)
        {
            try
            {
                var fromAddress = _globalSettings?.Smtp?.From;
                var toAddress = "seazkidayo@gmail.com";

                var subject = string.Format("Enquiry from: {0}", name);
                var body = "<p>"+ message_content +"</p>" + "<br/><p><b>Contact Info:</b></p>" +"<p><b>Email:</b> "+ email +"</p>" + "<p><b>Phone:</b> "+ phone +"</p>";
                EmailMessage message = new EmailMessage(fromAddress, toAddress, subject, body, true);
                await _emailSender.SendAsync(message, emailType: "Contact");

                _logger.LogInformation("Contact Form Submitted Successfully");
                return true;
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error When Submitting Contact Form");
                return false;
            }
        }
    }
}