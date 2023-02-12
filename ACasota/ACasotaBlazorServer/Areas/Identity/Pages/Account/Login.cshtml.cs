using ACasotaBlazorServer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace ACasotaBlazorServer.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly UserManager<ApplicationUser> _userManager;

		public LoginModel(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
			_userManager = userManager;
		}      

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet()
        {
            ReturnUrl = Url.Content("/");
        }

        public async Task<IActionResult> OnPostAsync()
        {
			ReturnUrl = Url.Content("/");

            ApplicationUser? user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName.Equals(Input.Email));

			if (ModelState.IsValid)
            {
                if (user != null)
                {
                    if (user.IsEnabled)
                    {
                        SignInResult result;

                        if (Input.RememberMe)
                        {
                            result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, true, false);
                        }
                        else
                        {
                            result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, false);
                        }

                        if (result.Succeeded)
                        {
                            return LocalRedirect(ReturnUrl);
                        }
                        else
                        {
                            ViewData["Errors"] = "Email ou password errado!!";

                            return Page();
                        }
                    }

					ViewData["Errors"] = "Utilizador Bloqueado!!";

                    return Page();
				}

				ViewData["Errors"] = "Utilizador Inexistente!!";
			}

            return Page();
        }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required]
            public bool RememberMe { get; set; }
        }

    }
}
