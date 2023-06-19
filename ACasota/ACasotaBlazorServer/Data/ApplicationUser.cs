using Microsoft.AspNetCore.Identity;

namespace ACasotaBlazorServer.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Sex { get; set; }
        public string? Title { get; set; }
        public string? Nif { get; set; }
        public string? CCnumber { get; set; }
        public string? Iban { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public string? ProfilePic { get; set; }
        public string? CoverPic { get; set; }
        public DateTime Date_Birth { get; set; }
        public bool IsEnabled { get; set; }

        //List of Animals the User owns
        public List<Animal>? Animals { get; set; }

        //List of Adoption Forms made
        public List<Adoption>? Adoptions { get; set; }

		//List of Events Subscribed
		public List<EventUser>? EventUsers { get; set; }

        //List of Transactions made
        public List<Transaction>? Transactions { get; set; }

        public List<Report>? Reports { get; set; }
    }
}