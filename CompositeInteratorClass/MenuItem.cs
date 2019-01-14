using System;
using System.Collections;
using System.Collections.Generic;

namespace CompositeInteratorClass
{
    public class MenuItem
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _vegetarian;
        private readonly decimal _price;

        public MenuItem(string name, string description, bool vegetarian, decimal price)
        {


            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;

        }


        public string GetName()
        {
            return _name;
        }

        public string GetDescripion()
        {
            return _description;    
        }

        public bool IsVegetarian()
        {
            return _vegetarian;
        }

        public decimal GetPrice()
        {
            return _price;
        }
    }
}
