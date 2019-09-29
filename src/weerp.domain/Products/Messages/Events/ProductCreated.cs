using MicroS_Common.Messages;
using System;

namespace weerp.domain.Products.Messages.Events
{
    public class ProductCreated : Domain.Product, IEvent
    {
        public ProductCreated(Guid id, string name, string description, string vendor, decimal price, int quantity) : base(id, name, description, vendor, price, quantity)
        {
        }
    }
}
