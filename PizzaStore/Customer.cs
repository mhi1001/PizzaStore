using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        private string _name;
        private string _address;
        private string _phone;
        private string _email;
        private int _id;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
