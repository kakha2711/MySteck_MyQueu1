using System.Collections;

namespace G12_20220714
{
    internal class MyQueue : ICollection
    {
        private object[] _items;

        public MyQueue()
        {
            _items = new object[0];
        }

        private object[] Resize(ref object[] array, object value)
        {
            object[] objects = new object[array.Length];

            objects = array;

            array = new object[array.Length + 1];

            for (int i = 0; i < objects.Length; i++)
                array[i] = objects[i];

            array[array.Length - 1] = value;

            return array;
        }

        private object ResizeDescending(ref object[] array)
        {
            object[] objects = new object[array.Length];

            objects = array;

            array = new object[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
                array[i] = objects[i + 1];

            return objects[0];
        }

        public virtual void Enqueue(object obj)
        {
            if (obj is null || obj is " " || obj is "")
                throw new ArgumentNullException("This value is null!");

            Resize(ref _items, obj);
        }

        public virtual object Dequeue()
        {
            return ResizeDescending(ref _items);
        }

        public virtual object Peek()
        {
            return _items[0];
        }

        public int Count => _items.Length;

        public int Count_count => _items.Count();

        public IEnumerator GetEnumerator()
        {
            MyEnumerator myEnumerator=new MyEnumerator(_items);

            return myEnumerator;
        }

        public void CopyTo(Array array, int index)
        {
            if (array is null)
                return;

            var newArray=array as object[];

            for (int i = 0; i < _items.Length; i++)
            {
                newArray[index + i] = _items[i];
            }
        }

        //__________________________________________________________________
        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();
    }

    class MyEnumerator : IEnumerator
    {
        private int _index;
        private object[] _data;

        public MyEnumerator(object[] data)
        {
            _index = -1;
            _data = data;
        }
        public object Current => _data[_index];

        public bool MoveNext()
        {
            if (_index < _data.Length - 1)
            {
                _index++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
