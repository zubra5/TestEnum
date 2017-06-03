using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace TestEnum
{
    public class ProgressionIterator : IEnumerator<int>
    {
        private readonly int _itemCount;
        private int _position;
        private int _current;
        private int _power;
        

        public ProgressionIterator(int itemCount, int power)
        {
            _itemCount = itemCount;
            _current = 1;
            _position = 0;
            _power = power;
        }

        public int Current
        {
            get { return _current; }
        }

        public void Dispose()
        {
            //обязаны очистить те неуправляемые ресурсы, к которым имели доступ - БД, файл
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        /// <summary>
        /// движение по последовательности и вычисление текущего элемента
        /// </summary>
        /// <returns>bool</returns>
        public bool MoveNext()
        {
            if (_position > 0) 
            {
                _current += _power;
            }
            //можно ли взять следующий элемент
            if (_position < _itemCount) 
            {
                _position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _current = 1;
            _position = 0;
        }
    }
}
