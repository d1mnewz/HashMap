using System.Collections;
using System.Collections.Generic;

namespace HashMap.Tests.Infrastructure
{
	public class HashMapWithCollisionContainsGenerator : IEnumerable<object[]>
	{
		private readonly List<object[]> _data = new List<object[]>
		{
			new object[] { HashMapGeneratorHelper.GenerateHashMapWithCollision(), 1 },
			new object[] { HashMapGeneratorHelper.GenerateHashMapWithCollision(), 6 },
			new object[] { HashMapGeneratorHelper.GenerateHashMapWithCollision(), 11 },
		};

		public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}