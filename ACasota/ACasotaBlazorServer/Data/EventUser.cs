namespace ACasotaBlazorServer.Data
{
	public class EventUser
	{
		//FK of the event
		public string EventId { get; set; }
		public Event Event { get; set; }

		//FK to the creator of the event
		public string UserId { get; set; }
		public ApplicationUser User { get; set; }
	}
}
