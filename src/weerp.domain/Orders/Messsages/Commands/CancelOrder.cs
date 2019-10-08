using MicroS_Common.Messages;
using Newtonsoft.Json;
using System;

namespace weerp.domain.Orders.Messsages.Commands
{
    public class CancelOrder : OrderBaseCommand
    {
        public override Guid Id { get; }
        public Guid CustomerId { get; }

        [JsonConstructor]
        public CancelOrder(Guid id, Guid customerId)
        {
            Id = id;
            CustomerId = customerId;
        }
    }
}
