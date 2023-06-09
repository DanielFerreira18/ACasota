namespace ACasotaBlazorServer.Data
{
	public class Event
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime InitialDate { get; set; }
		public DateTime EndDate { get; set;}

		//FK to the creator of the event
		public string UserId { get; set; }
		public ApplicationUser User { get; set; }

		//List of Users subscribed
		public List<EventUser> EventUsers { get; set; }

	}
}
