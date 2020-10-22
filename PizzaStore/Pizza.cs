using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        private string _name;
        private int _id;
        private string _size;
        private double _price;
        private List<Ingredients> _ingredients;

        public Pizza()
        {
            _ingredients = new List<Ingredients>();
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public List<Ingredients> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }

        public void AddIngredients(Ingredients ingredient)
        {
            _ingredients.Add(ingredient);
        }

        public void ListPizzaIngredients()
        {
            
            foreach (Ingredients i in _ingredients)
            {
                Console.WriteLine($"-IngredientID: {Id} | Type: {i.Name} | Price: {i.Price}");
            }


        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
