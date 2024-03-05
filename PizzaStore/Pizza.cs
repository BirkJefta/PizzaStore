using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore {
    public class Pizza
    {

        //the pizzaclass gives the option write a name and a price. 
        // with this information it returns a ToString with name and price of the pizza
        // this ToString is used in the order class

        string _name;
        double _price;



        public Pizza()
        {
            _name = "";
            _price = 0;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }


        public override string ToString()
        {
            return $"{_name}, Price: {_price} kr.";
        }
    }
}
