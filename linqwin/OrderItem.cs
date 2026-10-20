using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqwin
{
    internal class OrderItem : IEquatable<OrderItem>
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string ProductName {  get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public OrderItem(int id, string customerName, string productName, string category, decimal price, int quantity)
        {
            Id = id;
            CustomerName = customerName;
            ProductName = productName;
            Category = category;
            Price = price;
            Quantity = quantity;
        }

        public bool Equals(OrderItem other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(ProductName, other.ProductName , StringComparison.OrdinalIgnoreCase);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj as OrderItem);
        }

        public override int GetHashCode()
        {
            return ProductName != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(ProductName) : 0;
        }
    }
}
