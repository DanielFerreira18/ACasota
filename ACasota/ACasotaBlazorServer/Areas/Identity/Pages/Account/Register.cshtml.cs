using ACasotaBlazorServer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ACasotaBlazorServer.Areas.Identity.Pages.Account
{
	public class RegisterModel : PageModel
	{
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly UserManager<ApplicationUser> _userManager;

		[BindProperty]
		public InputModel Input { get; set; }
		public string ReturnUrl { get; set; }

		public RegisterModel(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
		{
			_signInManager = signInManager;
			_userManager = userManager;
		}

		public void OnGet() => ReturnUrl = Url.Content("/");


		public async Task<IActionResult> OnPostAsync()
		{
			ReturnUrl = Url.Content("/");

			if (Input.Password.Equals(Input.Password))
			{
				if (ModelState.IsValid)
				{
					var identity = new ApplicationUser
					{
						FirstName = Input.FirstName,
						LastName = Input.LastName,
						Date_Birth= Input.Date_Birth,
						UserName = Input.Email, 
						Email = Input.Email
					};
					var result = await _userManager.CreateAsync(identity, Input.Password);

					if (result.Succeeded)
					{
						await _signInManager.SignInAsync(identity, isPersistent: false);
						return LocalRedirect(ReturnUrl);
					}
				}
			}

			return Page();
		}

		public class InputModel
		{
			[Required]
			[DataType(DataType.Text)]
			public string FirstName { get; set; }

			[Required]
			[DataType(DataType.Text)]
			public string LastName { get; set; }

			[Required]
			[DataType(DataType.DateTime)]
			public DateTime Date_Birth { get; set; }

			[Required]
			[EmailAddress]
			public string Email { get; set; }

			[Required]
			[DataType(DataType.Password)]
			[StringLength(15, MinimumLength = 5)]
			public string Password { get; set; }

			[Required]
			[DataType(DataType.Password)]
			[StringLength(15, MinimumLength = 5)]
			public string PasswordConf { get; set; }
		}
	}
}
