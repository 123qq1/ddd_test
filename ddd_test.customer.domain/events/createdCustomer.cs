using System;

namespace ddd_test.customer.domain.events
{
    public  class createdCustomer
    {
        public Guid customerID { get; set; }
        public string customerName { get; set; }
        public string discordName { get; set; }
        public string accountName { get; set; }
    }
}
