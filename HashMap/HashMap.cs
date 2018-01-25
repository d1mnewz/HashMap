namespace HashMap
{
	public class HashMap<TKey, T> : IMap<TKey, T>
	{
		private long _size;
		private long _capacity;
		private Entry<TKey, T>[] _entries;

		public HashMap(long capacity)
		{
			_capacity = capacity;
			_entries = new Entry<TKey, T>[_capacity];
		}


		public HashMap()
		{
			_size = 0;
			_capacity = 7;
			_entries = new Entry<TKey, T>[_capacity];
		}

		public void Add(TKey key, T value)
		{
			var innerKey = GetInnerKey(key);
			var presentEntry = _entries[innerKey];
			var entryToInsert = new Entry<TKey, T>(key, value);

			if (presentEntry is null)
			{
				_entries[innerKey] = entryToInsert;
				_size++;
				return;
			}

			while (presentEntry.Next != null)
			{
				if (presentEntry.Key.Equals(key))
				{
					presentEntry.Value = value;
					return;
				}
				else presentEntry = presentEntry.Next;
			}

			presentEntry.Next = entryToInsert;
			_size++;

			// TODO: if size is close to the capacity, then need to recreate array with new bigger capacity.
		}


		public T Get(TKey key)
		{
			var innerKey = GetInnerKey(key);

			var entry = _entries[innerKey];
			while (entry != null)
			{
				if (entry.Key.Equals(key))
					return entry.Value;
				else entry = entry.Next;
			}

			return default(T);
		}

		public T this[TKey key] => Get(key);

		public void Remove(TKey key)
		{
			var innerKey = GetInnerKey(key);
			var entry = _entries[innerKey];

			Entry<TKey, T> prevEntry = null;
			while (entry != null)
			{
				if (entry.Key.Equals(key))
					break;
				prevEntry = entry;
				entry = entry.Next;
			}

			if (entry is null)
			{
				// TODO: NOT FOUND
				return;
			}

			else
			{
				if (prevEntry != null)
				{
					prevEntry.Next = entry.Next;
				}
				else _entries[innerKey] = entry.Next;
			}

			--_size;
		}

		public bool Contains(TKey key)
		{
			var innerKey = GetInnerKey(key);

			var entry = _entries[innerKey];
			while (entry != null)
			{
				if (entry.Key.Equals(key))
					return true;
				else
					entry = entry.Next;
			}

			return false;
		}

		private long GetInnerKey(TKey key)
		{
			return key.GetHashCode() % _capacity;
		}
	}

	public class Entry<TKey, T>
	{
		public T Value;
		public readonly TKey Key;
		public Entry<TKey, T> Next;

		public Entry(TKey key, T value)
		{
			Value = value;
			Key = key;
			Next = null;
		}
	}
}