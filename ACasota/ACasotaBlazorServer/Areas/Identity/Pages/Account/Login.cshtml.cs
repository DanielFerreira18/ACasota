using ACasotaBlazorServer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ACasotaBlazorServer.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {

        private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginModel(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
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

			if (ModelState.IsValid)
            {
				Microsoft.AspNetCore.Identity.SignInResult result;

                if (Input.RememberMe)
                {
					result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, true, false);
                }
                else
                {
                    result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, false);
				}

                if(result.Succeeded)
                {
                    return LocalRedirect(ReturnUrl);
                }
                else
                {
					ViewData["Errors"] = "Email ou password errado!!";

					return Page();
                }
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
