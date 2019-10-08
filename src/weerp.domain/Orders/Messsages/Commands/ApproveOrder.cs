using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace weerp.domain.Orders.Messsages.Commands
{
    public class ApproveOrder:OrderBaseCommand
    {
        public override Guid Id { get; }

        [JsonConstructor]
        public ApproveOrder(Guid id):base()
        {
            Id = id;
        }
    }
}
