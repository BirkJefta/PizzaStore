using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore {
    public class Menu
    {

      
        private Dictionary <string,Pizza > _menuItems;

        

        public Menu()
        {
            _menuItems = new Dictionary <string,Pizza > ();
        }

        public void AddToMenu(string pizzaID, Pizza pizza)
        {
            _menuItems.Add(pizzaID,pizza);
        }

        public void SeeMenu()
        {
            foreach (var item in _menuItems)
            {
                Pizza pizza = item.Value;
                Console.WriteLine($"{item.Key}. {pizza.Name} - {pizza.Price}kr.");
                Console.WriteLine($"Ingredients: {pizza.Ingredients}");
                Console.WriteLine("");
            }
        }



    }
}
