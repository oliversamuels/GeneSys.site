using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
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
    public class MailController : SurfaceController
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger<MailController> _logger;
        private readonly GlobalSettings _globalSettings;

        public MailController(
            IUmbracoContextAccessor umbracoContextAccessor, 
            IUmbracoDatabaseFactory databaseFactory, 
            ServiceContext services, 
            AppCaches appCaches, 
            IProfilingLogger profilingLogger, 
            IPublishedUrlProvider publishedUrlProvider, 
            IEmailSender emailSender, 
            ILogger<MailController> logger, 
            IOptions<GlobalSettings> globalSettings)
            : base(umbracoContextAccessor, databaseFactory, 
                  services, appCaches, profilingLogger, 
                  publishedUrlProvider)
        {
            _emailSender = emailSender;
            _logger = logger;
            _globalSettings = globalSettings.Value;
        }

        [HttpPost]
        public async Task<IActionResult> DemoMail(DemoViewModel model)
        {

            if(!ModelState.IsValid) return CurrentUmbracoPage();
            var status = await SendDemoEmail(model);
            
            if(status)
                TempData["Info"] = "Sent";
            else
                TempData["Info"] = "Failed";

            return RedirectToCurrentUmbracoPage();
        }

        [HttpPost]
        public async Task<IActionResult> ContactMail(ContactViewModel model)
        {

            if(!ModelState.IsValid) return CurrentUmbracoPage();
            var status = await SendContactEmail(model);
            
            if(status)
                TempData["Info"] = "Sent";
            else
                TempData["Info"] = "Failed";

            return RedirectToCurrentUmbracoPage();
        }

        public async Task<bool> SendDemoEmail(DemoViewModel model)
        {
            try
            {
                var fromAddress = _globalSettings?.Smtp?.From;
                var toAddress = "seazkidayo@gmail.com";

                var subject = string.Format("Demo Request from: {0} - {1}", model.LName, model.CompanyName);
                var body = "<p><b>Demo Request Details:</b></p>" + "<p><b>Name:</b>\t" + model.FName +" "+ model.LName +"</p>" +"<p><b>Company:</b>\t "+ model.CompanyName +"</p>" + "<p><b>Email:</b>\t"+ model.CompanyEmail +"</p>" + "<p><b>Country:</b>\t"+ model.Country +"</p>" + "<p><b>Phone:</b>\t"+ model.Phone +"</p>";
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

        public async Task<bool> SendContactEmail(ContactViewModel model)
        {
            try
            {
                var fromAddress = _globalSettings?.Smtp?.From;
                var toAddress = "seazkidayo@gmail.com";

                var subject = string.Format("Enquiry from: {0}", model.Name);
                var body = "<p>"+ model.Message +"</p>" + "<br/><p><b>Contact Info:</b></p>" +"<p><b>Email:</b> "+ model.Email +"</p>" + "<p><b>Phone:</b> "+ model.Phone +"</p>";
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