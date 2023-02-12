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
		private readonly RoleManager<IdentityRole> _roleManager;

		[BindProperty]
		public InputModel Input { get; set; }
		public string ReturnUrl { get; set; }

		public RegisterModel(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
		{
			_signInManager = signInManager;
			_userManager = userManager;
			_roleManager = roleManager;
		}

		public void OnGet() => ReturnUrl = Url.Content("/");


		public async Task<IActionResult> OnPostAsync()
		{
			ReturnUrl = Url.Content("/");
			string roleStr = "User";

			if (Input.Password.Equals(Input.PasswordConf))
			{
				if (ModelState.IsValid)
				{
					var identity = new ApplicationUser
					{
						FirstName = Input.FirstName,
						LastName = Input.LastName,
						Date_Birth = Input.Date_Birth,
						UserName = Input.Email,
						Email = Input.Email,
						IsEnabled = true
					};

					var result = await _userManager.CreateAsync(identity, Input.Password);
					
					var addUserRoleResult = await _userManager.AddToRoleAsync(identity, roleStr);

					if (result.Succeeded && addUserRoleResult.Succeeded)
					{
						await _signInManager.SignInAsync(identity, isPersistent: false);
						return LocalRedirect(ReturnUrl);
					}
					else
					{
						List<IdentityError> errorList = result.Errors.ToList();
						var str = "";	

						foreach (var error in errorList)
						{
							str = error.Description.ToString();

							str = str.Split("'")[1];
							str = str.Split("'")[0];

							str = "Email '" + str + "' já esta em uso!!";
						}

						ViewData["Errors"] = str;

						return Page();
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
