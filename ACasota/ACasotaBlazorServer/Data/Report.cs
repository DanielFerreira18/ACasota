namespace ACasotaBlazorServer.Data
{
    public class Report
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DateCreated { get; set; }
        public string AnimalRace { get; set; }
        public bool State { get; set; }

        //FK to the user that made the Report
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
