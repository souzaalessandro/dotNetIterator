// 

using System.Collections.Generic;

namespace CompositeInteratorClass
{
    public class PancakeHouseMenu
    {
        private List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();
            
            AddItem("K&B's Pancake BreakFest","Pancakes with scramble eggs, and toast", true,2.99m);
            AddItem("Regular Pancakes", "Pancakes with fried eggs, sausage", false, 2.99m);
            AddItem("Blueberry Pancakes ", "Pancakes with fresh blueberries", true, 3.49m);
            AddItem("Waffles", "Waffles with your choice of blueberrie or strawberries", true, 3.59m);
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