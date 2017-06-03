using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace TestEnum
{
    public class Progression : IEnumerable<int>
    {
        private readonly int _itemCount;
        private readonly int _power;

        public Progression(int itemCount, int power)
        {
            _itemCount = itemCount;
            _power = power;
        }



        public IEnumerator<int> GetEnumerator()
        {
            return new ProgressionIterator(_itemCount, _power);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
