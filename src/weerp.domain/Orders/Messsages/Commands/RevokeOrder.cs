using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace weerp.domain.Orders.Messsages.Commands
{
    public class RevokeOrder : OrderBaseCommand
    {
        public override Guid Id { get; }
        public Guid CustomerId { get; }

        [JsonConstructor]
        public RevokeOrder(Guid id, Guid customerId):base()
        {
            Id = id;
            CustomerId = customerId;
        }
    }
}
