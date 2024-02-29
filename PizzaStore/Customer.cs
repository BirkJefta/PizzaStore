using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore {
    public class Customer {
        


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
