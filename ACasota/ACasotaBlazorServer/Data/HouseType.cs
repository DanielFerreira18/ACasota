using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ACasotaBlazorServer.Data
{
    public class HouseType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        //List with the Houses of the same type
        public List<AdoptionHouse>? Houses { get; set; }
    }
}
