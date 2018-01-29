namespace HashMap.Tests.Infrastructure
{
	internal static class HashMapGeneratorHelper
	{
		public static HashMap<int, string> GenerateHashMapWithCollision()
		{
			var map = new HashMap<int, string>();
			map.Add(1, 1.ToString());
			map.Add(6, 6.ToString());
			map.Add(11, 11.ToString());
			return map;
		}
	}
}