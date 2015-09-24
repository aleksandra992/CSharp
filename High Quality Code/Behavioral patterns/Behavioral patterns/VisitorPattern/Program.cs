using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Items;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var someBook = new Book(80, "Title of the book");
            var anotherBook = new Book(150,"Another title");
            var thirdBook = new Book(200, "Neshto");

            ShoppingCart cart = new ShoppingCart();
            cart.Add(someBook);
            cart.Add(anotherBook);

            float totalPrice = cart.CalculateTotal(new ShopingCartPriceVisitor());
            float totalWeight = cart.CalculateTotal(new ShopingCartWeightVisitor());

            Console.WriteLine("The total price of the cart is {0}, and the weight is {1} ", totalPrice, totalWeight);


        }
    }
}
