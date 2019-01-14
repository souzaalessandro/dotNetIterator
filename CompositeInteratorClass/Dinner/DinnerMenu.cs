// 

using System.Collections.Generic;

namespace CompositeInteratorClass
{
    public class DinnerMenu
    {
        private List<MenuItem> _menuItems;

        public DinnerMenu()
        {
            _menuItems = new List<MenuItem>();
            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99m);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99m);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29m);
            AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05m);

        }

        public void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            var item = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(item);

        }

        public List<MenuItem> GetMenuItens()
        {
            return _menuItems;
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}