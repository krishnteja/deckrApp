using DeCKR_WebAPI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Configuration;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace DeCKR_WebAPI
{
   // [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            string apiKey = ConfigurationManager.AppSettings["sendgrid-api"];
            //const string sandBox = "sandbox5c2ed57ac7b94f0ea5d372f3194b026c.mailgun.org";
            //byte[] apiKeyAuth = Encoding.ASCII.GetBytes($"api:{apiKey}");
            //var httpClient = new HttpClient { BaseAddress = new Uri("https://api.mailgun.net/v3/") };
            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
            //    Convert.ToBase64String(apiKeyAuth));

            //var form = new Dictionary<string, string>
            //{
            //    ["from"] = "postmaster@sandbox5c2ed57ac7b94f0ea5d372f3194b026c.mailgun.org",
            //    ["to"] = message.Destination,
            //    ["subject"] = message.Subject,
            //    ["text"] = message.Body
            //};

            //HttpResponseMessage response =
            //    httpClient.PostAsync(sandBox + "/messages", new FormUrlEncodedContent(form)).Result;
            //return Task.FromResult((int)response.StatusCode);
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("deckr@team.com", "DeCKR Team"),
                Subject = message.Subject,
                PlainTextContent = message.Body,
                HtmlContent = "<strong>" + message.Body + "</strong>"
            };

            msg.AddTo(new EmailAddress(message.Destination, "DeCKR User"));
            var response = client.SendEmailAsync(msg).Result;
            return Task.FromResult((int)response.StatusCode);
        }
    }

    //public class SmsService : IIdentityMessageService
    //{
    //    public Task SendAsync(IdentityMessage message)
    //    {
    //        // Plug in your SMS service here to send a text message.
    //        return Task.FromResult(0);
    //    }
    //}

    // Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.

    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
            : base(store)
        {
        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context) 
        {
            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(context.Get<ApplicationDbContext>()));
            // Configure validation logic for usernames
            manager.UserValidator = new UserValidator<ApplicationUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            // Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = true,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };

            // Configure user lockout defaults
            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            // Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
            // You can write your own provider and plug it in here.
            //manager.RegisterTwoFactorProvider("Phone Code", new PhoneNumberTokenProvider<ApplicationUser>
            //{
            //    MessageFormat = "Your security code is {0}"
           // //});
           // manager.RegisterTwoFactorProvider("Email Code", new EmailTokenProvider<ApplicationUser>
           // {
           //     Subject = "Security Code",
           //     BodyFormat = "Your security code is {0}"
           // });

           manager.EmailService = new EmailService();

            //manager.SmsService = new SmsService();
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = 
                    new DataProtectorTokenProvider<ApplicationUser>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }
    }

    // Configure the application sign-in manager which is used in this application.
    public class ApplicationSignInManager : SignInManager<ApplicationUser, string>
    {
        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager, OAuthDefaults.AuthenticationType);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }
    }
}
