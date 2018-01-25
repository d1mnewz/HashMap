namespace HashMap
{
	public interface IMap<in TKey, T>
	{
		void Add(TKey key, T value);
		T Get(TKey key);
		void Remove(TKey key);
		bool Contains(TKey key);
		T this[TKey key] { get; }
	}
}