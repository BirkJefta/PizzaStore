using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore {
    public class Order
    {
        
        
        private Pizza _pizza;
        private Customer _customer;
        


        public Order(Pizza pizza, Customer customer)
        {
            _pizza = pizza;
            _customer = customer;
        }

        public Customer Customer
        {
            get
            {
                return _customer;
            }
        }

        public Pizza Pizza
        {
            get
            {
                return _pizza;
            }
           
        }

        public double CalculateTotalPrice()
        {
            double pizzaTax = Pizza.Price * 0.25;
            double pizzaDelivery = 49;
            double totalPrice = Pizza.Price + pizzaTax + pizzaDelivery;
            return totalPrice;
        }

        public override string ToString()
        {

            return $"{Customer} \n" +
                   $"Order: {Pizza} \n" +
                   $"The total price including tax and delivery fee of 49 kr is: {CalculateTotalPrice()} kr.\n";
        }
    }
}
