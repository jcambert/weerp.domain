using Newtonsoft.Json;
using System;

namespace weerp.domain.Orders.Messsages.Commands
{

    public class CreateOrder : OrderBaseCommand
    {
        public override Guid Id { get; }
        public Guid CustomerId { get; }

        [JsonConstructor]
        public CreateOrder(Guid id, Guid customerId) : base() 
        {
            Id = id;
            CustomerId = customerId;
        }
    }
}
