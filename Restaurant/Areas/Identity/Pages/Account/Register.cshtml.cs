using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Restaurant.Models;
using Restaurant.Utility;

namespace Restaurant.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        //our data
        private readonly RoleManager<IdentityRole> _roleManager;
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            //Add New property

            [Required]
            public string Name { get; set; }

            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string city { get; set; }
            public string State { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                //var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var user = new ApplicationUser
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    Name = Input.Name,
                    city = Input.city,
                    State = Input.State,
                    PhoneNumber = Input.PhoneNumber
                };

                //Get Radio btn value
                string role = Request.Form["rdUserRole"].ToString();
                //End

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    //user Role for Customer
                    if (!await _roleManager.RoleExistsAsync(StaticDetails.CustomerEndUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(StaticDetails.CustomerEndUser));
                    }

                    //Manager User Role
                    if (!await _roleManager.RoleExistsAsync(StaticDetails.ManagerUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(StaticDetails.ManagerUser));
                    }

                    //Front End User
                    if (!await _roleManager.RoleExistsAsync(StaticDetails.FrontDeskUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(StaticDetails.FrontDeskUser));
                    }

                    //Kitchen User
                    if (!await _roleManager.RoleExistsAsync(StaticDetails.KitchenUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(StaticDetails.KitchenUser));
                    }


                    //end Assign roles to new reg.users

                    if (role == StaticDetails.KitchenUser)
                    {
                        await _userManager.AddToRoleAsync(user, StaticDetails.KitchenUser);
                        return RedirectToAction("Index", "Home", new { area = "Customer" });
                    }

                    else if (role == StaticDetails.FrontDeskUser)
                    {
                        await _userManager.AddToRoleAsync(user, StaticDetails.FrontDeskUser);
                        return RedirectToAction("Index", "user", new { area = "Admin" });
                    }

                    else if (role == StaticDetails.ManagerUser)
                    {
                        await _userManager.AddToRoleAsync(user, StaticDetails.ManagerUser);
                        return RedirectToAction("Index", "user", new { area = "Admin" });
                    }

                    else
                    {
                        await _userManager.AddToRoleAsync(user, StaticDetails.CustomerEndUser);
                        await _signInManager.SignInAsync(user, isPersistent: false);
                    }

                    //for some reason as still we in development we will assign default manager user

                    //await _userManager.AddToRoleAsync(user, StaticDetails.ManagerUser);

                    /*
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                    */
                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}