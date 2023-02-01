using System;
using System.Collections;

namespace G12_20220714
{
	public class MyStack : ICollection
	{
		private object[] _items;

		public MyStack()
		{
			_items = new object[0];
		}

		private object[] Resize(ref object[] array, object value)
		{

			if ((value is null || value is " " || value is "") || array is null)
				throw new ArgumentNullException("This value is null!");


			object[] objects = new object[array.Length];

			objects = array;

			array = new object[array.Length + 1];

			for (int i = 0; i < objects.Length; i++)
				array[i + 1] = objects[i];

			array[0] = value;

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
		public virtual object Peek()
		{
			return _items[0];
		}

		public virtual object Pop()
		{
			return ResizeDescending(ref _items);
		}

		public virtual void Push(object obj)
		{
			if (obj is null || obj is " " || obj is "")
				throw new ArgumentNullException("This value is null!");

			Resize(ref _items, obj);
		}

		public int Count => _items.Length;

		public IEnumerator GetEnumerator()
		{
			MyEnumerator myEnumerator = new MyEnumerator(_items);

			return myEnumerator;
		}

		public void CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		//__________________________________________________________________
		public bool IsSynchronized => throw new NotImplementedException();

		public object SyncRoot => throw new NotImplementedException();
	}


	class MyEnumerator1 : IEnumerator
	{
		private int _index;
		private object[] _data;

		public MyEnumerator1(object[] data)
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
