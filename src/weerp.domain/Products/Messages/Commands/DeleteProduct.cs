using System;
using System.Collections.Generic;
using System.Text;

namespace weerp.domain.Products.Messages.Commands
{
    public class DeleteProduct : ProductBaseCommand
    {
        public DeleteProduct(Guid id) : base()
        {
            this.Id = id;
        }

        public override Guid Id { get; }
    }
}
