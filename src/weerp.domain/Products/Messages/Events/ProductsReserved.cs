﻿using MicroS_Common.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace weerp.domain.Products.Messages.Events
{
    public class ProductsReserved : IEvent
    {
        public Guid OrderId { get; set; }
        public IDictionary<Guid, int> Products { get; }

        [JsonConstructor]
        public ProductsReserved(Guid orderId, IDictionary<Guid, int> products)
        {
            OrderId = orderId;
            Products = products;
        }
    }
}