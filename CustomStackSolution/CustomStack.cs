using System;
namespace CustomStackSolution
{
    public class CustomStack
    {

        private object[] _items;

        public int Count { get; private set; }
        public int Capacity
        {
            get
            {
                return _items.Length;
            }
        }

        public CustomStack()
        {
            const int defaultCapacity = 4;
            _items = new object[defaultCapacity]; 
        }

        public CustomStack(int capacity)
        {
            _items = new object[capacity];
        }

        public void Push(object item)
        {
            if (_items.Length == Count)
            {
                object[] largerArray = new object[ Count * 2 ];
                Array.Copy(_items, largerArray, Count);

                _items = largerArray;
            }

            _items[Count++] = item;
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            _items[--Count] = null;
        }

        public object Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _items[Count - 1];
        }

    }
}

