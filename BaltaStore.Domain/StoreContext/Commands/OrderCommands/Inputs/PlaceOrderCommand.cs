using System;
using System.Collections.Generic;
using BaltaStore.Shared.Commands;
using FluentValidator;
using FluentValidator.Validation;

namespace BaltaStore.Domain.StoreContext.OrderCommands.Inputs
{
    public class PlaceOrderCommand : Notifiable, ICommand
    {
        public PlaceOrderCommand()
        {
            OrderItems = new List<OrderItemCommand>();
        }

        public Guid Customer { get; set; }
        public IList<OrderItemCommand> OrderItems { get; set; }

        public bool Valid()
        {
            AddNotifications(new ValidationContract()
                .HasLen(Customer.ToString(), 36, "Customer", "Identificador do Cliente inválido")
                .IsGreaterThan(OrderItems.Count, 0, "Items", "Nenhum item do pedido foi encontrado")
            );
            return IsValid;
        }
    }

    public class OrderItemCommand
    {
        public Guid Product { get; set; }
        public decimal Quantity { get; set; }
    }
}