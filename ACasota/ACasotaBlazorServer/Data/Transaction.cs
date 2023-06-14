namespace ACasotaBlazorServer.Data
{
    public class Transaction
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public string ProofPicture { get; set; }
        public DateTime DateTransaction { get; set; }
        public DateTime DatePayment { get; set; }
        public bool IsPaid { get; set; }

        //FK to the type of transaction
        public string TypeId { get; set; }
        public TransactionType Type { get; set; }
    
        //FK to the User that made the transaction
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
