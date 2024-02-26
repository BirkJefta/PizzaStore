using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore {
    public class Pizza
    {
        //indeholder kriterierne for at lave en pizza



        string _name;
        int _price;
        string _ingredients;
        string _ID;


        public Pizza()
        {
            _name = "";
            _price = 0;
            _ingredients = "";
            _ID = "";
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }

        public string PizzaID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} kr. Ingredients: {Ingredients} ";
        }



    }
}
