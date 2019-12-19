using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesOrdersProject.Models
{
    public class ShoppingCartModel
    {
        private List<ShoppingCartItemModel> items = new List <ShoppingCartItemModel>(); 
            public IEnumerable<ShoppingCartItemModel> Items
            {
                get { return items; }
            }

        public void AddItem(Product product, int quantity)
        {
            ShoppingCartItemModel item = Items.SingleOrDefault(
                p => p.Product.ProductID ==
                product.ProductID);

            if (item == null)
            {
                items.Add(new ShoppingCartItemModel
                {
                    Product= product,
                    Quantity = quantity
                }
                );
            }

            else
            {
                item.Quantity += quantity;
            }
        }

        public void RemoveItem(int productID)
        {
            items.RemoveAll(p => p.Product.ProductID == productID);
        }

        public decimal GetCartTotal()
        {
            return (decimal)items.Sum(s => s.Product.ProductPrice * s.Quantity);
        }
        public void Clear()
        {
            items.Clear();
        }

        public ShippingInfo ShippingInfo { get; set; }
        public BillingInfo BillingInfo { get; set; }

    }
}