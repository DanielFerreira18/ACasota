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
        public string Colour { get; set; }

        //FK to the owner of the animal
        public string? UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
