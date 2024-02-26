using System;

namespace PizzaStore {
    public class Program {
        static void Main(string[] args)
        {
            //Laver en ny store objekt kaldet bigmamaspizza
            Store bigMammasPizza = new Store();
            Menu menu = bigMammasPizza.getmenu();

            //kører metoden start, der opretter 3 pizzaer, 3 costumers og 3 orders
            bigMammasPizza.Start();
            
            //metoden henter menuen
            menu.SeeMenu();
            

        }
    }
}
