using BaltaStore.Shared.Entities;
using FluentValidator;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Product : Entity
    {
        public Product(
            string title,
            string description,
            string image,
            decimal price,
            decimal quantity)
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantity;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public decimal Price { get; private set; }
        public decimal QuantityOnHand { get; private set; }

        public override string ToString()
        {
            return Title;
        }

        public void DecreaseQuantity(decimal quantity)
        {
            QuantityOnHand -= quantity;
        }
    }
}