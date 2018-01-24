namespace HashMap
{
	public class HashMap<TKey, T> : IMap<TKey, T>
	{
		private long _size;
		private Entry<TKey, T>[] _entries;

		public HashMap(long size)
		{
			_size = size;
			_entries = new Entry<TKey, T>[_size];
		}


		public void Insert(TKey key, T value)
		{
			throw new System.NotImplementedException();
		}

		public T Get(TKey key)
		{
			throw new System.NotImplementedException();
		}

		public void Remove(TKey key)
		{
			throw new System.NotImplementedException();
		}

		public bool Contains(TKey key)
		{
			throw new System.NotImplementedException();
		}

		public void Upsert(TKey key, T value)
		{
			throw new System.NotImplementedException();
		}
	}

	public class Entry<TKey, T>
	{
		private T _value;
		private TKey _key;
		private Entry<TKey, T> _next;

		public Entry(TKey key, T value)
		{
			_value = value;
			_key = key;
			_next = null;
		}

		public void AddNext(Entry<TKey, T> next)
		{
			if (!(next is null) && _next is null)
				_next = next;
		}
	}
}