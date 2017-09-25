using System;
using System.Collections.Generic;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Order
    {
        public Customer Customer { get; set; }
        public string Number { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }
        public IList<OrderItem> Items { get; set; }
        public IList<Delivery> Deliveries { get; set; }

        // To Place An Order
        public void Place() { }
    }
}