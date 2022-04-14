using EduHome.Models;
using EduHome.Services.Interfaces;
using EduHome.ViewModels.Accaunt;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace EduHome.Controllers
{
    public class AccauntController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IEmailService _emailService;
        public AccauntController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            AppUser newUser = new AppUser()
            {
                FullName = registerVM.FullName,
                UserName = registerVM.Username,
                Email = registerVM.Email
            };

            IdentityResult result = await _userManager.CreateAsync(newUser, registerVM.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(registerVM);
            }

           

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);

            var link = Url.Action(nameof(VerifyEmail), "Account", new { userId = newUser.Id, token = code }, Request.Scheme, Request.Host.ToString());

            string html = $"<a href ={link}>Click here</a>";

            string content = "Email for register confirmation";

            await _emailService.SendEmailAsync(newUser.Email, newUser.UserName, html, content);

            return RedirectToAction(nameof(EmailVerification));
        }

        public async Task<IActionResult> VerifyEmail(string userId, string token)
        {
            if (userId == null || token == null) return BadRequest();

            AppUser user = await _userManager.FindByIdAsync(userId);

            if (user is null) return BadRequest();


            await _userManager.ConfirmEmailAsync(user, token);

            await _signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult EmailVerification()
        {
            return View();
        }

        // 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
        //public async Task SendEmail(string emailAddress, string url)
        //{
        //    var apiKey = "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";
        //    var client = new SendGridClient(apiKey);
        //    var from = new EmailAddress("asgaraa@code.edu.az", "Asgar");
        //    var subject = "Sending with SendGrid is Fun";
        //    var to = new EmailAddress(emailAddress, "Example User");
        //    var plainTextContent = "and easy to do anywhere, even with C#";
        //    var htmlContent = $"<a href ={url}>Click Here</a>";
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        //    var response = await client.SendEmailAsync(msg);
        //}





        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {

            if (!ModelState.IsValid) return View(loginVM);

            AppUser user = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);

            if (user is null)
            {
                user = await _userManager.FindByNameAsync(loginVM.UserNameOrEmail);
            }

            if (user is null)
            {
                ModelState.AddModelError("", "Email or password is wrong");
                return View();
            }

            if (!user.IsActivated)
            {
                ModelState.AddModelError("", "Contact with admin");
                return View(loginVM);
            }

            SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

            if (!signInResult.Succeeded)
            {
                if (signInResult.IsNotAllowed)
                {
                    ModelState.AddModelError("", "Please confirm your account");
                    return View();
                }
                ModelState.AddModelError("", "Email or password is wrong");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM forgotPasswordVM)
        {
            if (!ModelState.IsValid) return View(forgotPasswordVM);

            var user = await _userManager.FindByEmailAsync(forgotPasswordVM.Email);

            if (user is null)
            {
                ModelState.AddModelError("", "This email hasn't been registrated");
                return View(forgotPasswordVM);
            }


            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            var link = Url.Action(nameof(ResetPassword), "Account", new { email = user.Email, token = code }, Request.Scheme, Request.Host.ToString());

            string html = $"<a href ={link}>Click here for forgot password</a>";

            string content = "Email for forgot password";


            await _emailService.SendEmailAsync(user.Email, user.UserName, html, content);

            return RedirectToAction(nameof(ForgotPasswordConfirm));
        }

        [HttpGet]
        public IActionResult ResetPassword(string email, string token)
        {
            var resetPasswordModel = new ResetPasswordVM { Email = email, Token = token };
            return View(resetPasswordModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        {
            if (!ModelState.IsValid) return View(resetPasswordVM);

            var user = await _userManager.FindByEmailAsync(resetPasswordVM.Email);

            if (user is null) return NotFound();

            IdentityResult result = await _userManager.ResetPasswordAsync(user, resetPasswordVM.Token, resetPasswordVM.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(resetPasswordVM);

            }


            return RedirectToAction(nameof(Login));
        }

        public IActionResult ForgotPasswordConfirm()
        {
            return View();
        }

    }

   

}

