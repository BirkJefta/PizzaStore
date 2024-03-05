using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore 
{
    public class Store
    {
        //Start() method creates 3 pizzaobjects, 3 customer objects, and 3 order objects.
        // For each pizza object a name and price is set
        // for each customer object a name is set
        //in the order object, Console.WriteLine is used to print the order class' ToString

        public void Start()
        {

            Pizza pizza1 = new()
            {
                Name = "Margherita", 
                Price = 55
            };

            Pizza pizza2 = new ()
            {
                Name = "vesuvio", 
                Price = 60
            };
            

            Pizza pizza3 = new ()
            {
            Price = 64,
            Name = "Calzone"
            };

            Customer customer1 = new()
            {
            CustomerName = "Frederik"
            };

            Customer customer2 = new ()
            {
            CustomerName = "Mary"
            };

            Customer customer3 = new ()
            {
            CustomerName = "Margrethe"
            };


            Order order1 = new (pizza1, customer1);
            Console.WriteLine(order1);

            Order order2 = new (pizza2, customer2);
            Console.WriteLine(order2);

            Order order3 = new (pizza3, customer3);
            Console.WriteLine(order3);
            
        }
        



        







    }
}
