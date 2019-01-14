// 

using System.Collections.Generic;

namespace CompositeInteratorClass
{
    public class DinerMenuIterator:IIterator
    {
        private int _position = 0;
        private List<MenuItem> _itens;

        public DinerMenuIterator(List<MenuItem> itens)
        {
            this._itens = itens;
        }

        public bool HasNext()
        {
            return _position < _itens.Count && _itens[_position] != null;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = _itens[_position];
            _position++;
            return menuItem;
        }
    }
}