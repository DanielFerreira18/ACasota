namespace ACasotaBlazorServer.Data
{
    public class HouseType
    {
        public string Id { get; set; }
        public string Type { get; set; }

        public List<AdoptionHouse>? Houses { get; set; }
    }
}
