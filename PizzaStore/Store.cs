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
        //Laver en nyt Menu-object
        private Menu _menu;

      
        //Laver pizza objekter og tilføjer dem til menuen
        //Laver nye kunder
        //laver nye ordre
        public void Start()
        {
            Pizza pizza1 = new Pizza();
            
            pizza1.Name = "margherita";
            pizza1.Price = 69;
            pizza1.Ingredients = "Tomato and Cheese";
            pizza1.PizzaID = "1";
            _menu.AddToMenu(pizza1.PizzaID,pizza1);

            

            Pizza pizza2 = new Pizza();

            pizza2.Name = "Calzone";
            pizza2.Price = 75;
            pizza2.Ingredients = "Tomatom";
            pizza2.PizzaID = "2";
            _menu.AddToMenu(pizza2.PizzaID, pizza2);

        }


        //Henter menuen 
        public Menu getmenu()
        {
            return _menu;
        }
        







    }
}
