using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Security.Principal;

namespace ACasotaBlazorServer.Data
{
    public class Animal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string Size { get; set; }
        public bool IsSterile { get; set; }
        public bool IsVacinated { get; set; }
        public string? AnimalPicture { get; set; }
        public string? CoverPicture { get; set; }

        //FK to the owner of the animal
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        //List of Adoption Forms made
        public List<Adoption>? Adoptions { get; set; }
    }
}
