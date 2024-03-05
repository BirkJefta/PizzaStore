using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore {
    public class Customer {
        
        //The customer class lets you write a name of the customer.
        //this name is returned as a ToString which is used in the order class

        private string _customerName;

        public Customer() 
        {
            _customerName = "";
        }
        
        public string CustomerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                _customerName = value;
            }
        }

        public override string ToString()
        {
            return $"Customer name: {_customerName}";
        }
    }
}
