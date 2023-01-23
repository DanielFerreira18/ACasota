using Microsoft.AspNetCore.Identity;

namespace ACasotaBlazorServer.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Nif { get; set; }
        public string CCnumber { get; set; }
        public string Morada { get; set; }
        public int NumTelemovel { get; set; }
        public DateTime Data_Nasc { get; set; }
    }
}
