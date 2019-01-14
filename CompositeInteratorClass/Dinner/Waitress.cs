// 
namespace CompositeInteratorClass
{
    public class Waitress
    {
        private PancakeHouseMenu _pancakeHouseMenu;
        private DinnerMenu _dinnerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinnerMenu dinnerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinnerMenu = dinnerMenu;
        }

        public void PrintMenu()
        {

            var pancakeInterator = _pancakeHouseMenu.CreateIterator();
            var dinnerIterator = _dinnerMenu.CreateIterator();
            




        }
    }
}