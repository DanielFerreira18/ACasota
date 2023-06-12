namespace ACasotaBlazorServer.Data
{
    public class AdoptionHouse
    {
        public string Id { get; set; }
        public string Tipology { get; set; }
        
        //FK to the type of the house
        public int TypeId { get; set; }
        public HouseType Type { get; set; }

        //FK to the adoptions forms made
        public List<Adoption> Adoptions { get; set; }
    }
}
