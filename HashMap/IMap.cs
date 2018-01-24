namespace HashMap
{
	public interface IMap<in TKey, T>
	{
		void Insert(TKey key, T value);
		T Get(TKey key);
		void Remove(TKey key);
		bool Contains(TKey key);
		void Upsert(TKey key, T value);
	}
}