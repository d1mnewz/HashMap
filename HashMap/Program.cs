using System;

namespace HashMap
{
	class Program
	{
		static void Main()
		{
			IMap<int, string> map = new HashMap<int, string>(5);

			map.Add(1, "hello");
			map.Add(6, "something deep");
			map.Add(11, "really deep");


			var s1 = map.Get(1);
			var s2 = map.Get(6);
			var s3 = map.Get(11);
			var s = map.Get(1);

			map.Remove(6);

			s1 = map.Get(1);
			s2 = map.Get(6);
			s3 = map.Get(11);
			s = map.Get(1);
		}
	}
}