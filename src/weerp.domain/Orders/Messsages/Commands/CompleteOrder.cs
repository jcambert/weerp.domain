using Newtonsoft.Json;
using System;

namespace weerp.domain.Orders.Messsages.Commands
{

    public class CompleteOrder : OrderBaseCommand
    {
        public override Guid Id { get; }
        public Guid CustomerId { get; }

        [JsonConstructor]
        public CompleteOrder(Guid id, Guid customerId) : base()
        {
            Id = id;
            CustomerId = customerId;
        }
    }
}
