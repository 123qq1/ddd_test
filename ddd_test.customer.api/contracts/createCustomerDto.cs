namespace ddd_test.customer.api.contracts
{
    public class createCustomerDto
    {
        public Guid customerID { get; set; }
        public string customerName { get; set; }
        public string discordName { get; set; }
        public string accountName { get; set; }
    }
}
