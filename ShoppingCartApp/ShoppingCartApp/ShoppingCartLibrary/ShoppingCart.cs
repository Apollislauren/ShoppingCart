using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLibrary
{
    public class ShoppingCart
    {
        private List<ShoppingCartItem> _items = new List<ShoppingCartItem>();

        public void AddItem(ShoppingCartItem item)
        {
            _items.Add(item);

        }


        
        public List<ShoppingCartItem> GetItems()
        {
            return _items;
        }

        
        public double SubTotal()
        {
            double total = 0;
            foreach (ShoppingCartItem item in _items)
            {

                total += item.Price;

            }
            return total;
        }
        

        public double Vat()
        {
            double myvat = 0;
            foreach (ShoppingCartItem item in _items)
            {
                myvat = SubTotal() + (SubTotal() * 0.05);

            }
            return myvat;
        }







    }

}

