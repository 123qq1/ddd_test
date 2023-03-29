using ddd_test.core;
using ddd_test.customer.domain.events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddd_test.customer.domain
{
    public class customer : Aggregate
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string DiscordName { get; private set; }
        public string AccountName { get; private set; }

        protected override void When(object @event)
        {

            switch (@event)
            {

                case createdCustomer x:
                    OnCreated(x);
                    break;

            }
        }

        public void Create(Guid customerId, string customerName, string accountName, string discordName)
        {
            if (Version >= 0) throw new NotImplementedException();

            Apply(new createdCustomer { 
                customerID = customerId,
                customerName = customerName, 
                accountName = accountName,
                discordName = discordName 
            });
        }



        #region Event Handlers

        private void OnCreated(createdCustomer @event)
        {
            Id = @event.customerID;
            DiscordName = @event.discordName;
            AccountName = @event.accountName;
            Name = @event.customerName;
        }

        #endregion

    }
}
