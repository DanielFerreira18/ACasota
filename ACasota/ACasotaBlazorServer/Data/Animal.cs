using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Security.Principal;

namespace ACasotaBlazorServer.Data
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Age { get; set; }
        public string Colour { get; set; }
    }
}
