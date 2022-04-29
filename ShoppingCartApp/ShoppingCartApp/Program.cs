using System;
using ShoppingCartLibrary;
using System.Collections.Generic;



namespace shoppingCartApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
           
            ShoppingCart cart = new ShoppingCart();

            

            ShoppingCartItem item = new ShoppingCartItem("ps5", 1234);
            cart.AddItem(item);



            item = new ShoppingCartItem("Ps4", 3443);
            cart.AddItem(item);
            item = new ShoppingCartItem("Nintendo", 3443);
            cart.AddItem(item);

            foreach (ShoppingCartItem sci in cart.GetItems())
            {
                Console.WriteLine(sci.Name + "\t" + sci.Price);
            }


            Console.WriteLine("Subtotal:" + cart.SubTotal());
            Console.WriteLine("With Vat:" + cart.Vat());




        }
    }

}
