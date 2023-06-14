namespace ACasotaBlazorServer.Data
{
	public class Event
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime InitialDate { get; set; }
		public DateTime EndDate { get; set;}
		public int Count { get; set; }
		public int MaxAmount { get; set; }
		public int State { get; set; }

		//List of Users subscribed
		public List<EventUser>? EventUsers { get; set; }

	}
}
