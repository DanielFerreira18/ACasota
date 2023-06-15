namespace ACasotaBlazorServer.Data
{
    public class TransactionType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        //List of Transactions witht the same type
        public List<Transaction>? Transactions { get; set; }
    }
}
