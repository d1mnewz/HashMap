using System.Collections;
using System.Collections.Generic;

namespace HashMap.Tests.Infrastructure
{
	public class HashMapWithCollisionNotContainsGenerator : IEnumerable<object[]>
	{
		private readonly List<object[]> _data = new List<object[]>
		{
			new object[] { HashMapGeneratorHelper.GenerateHashMapWithCollision(), 2 },
			new object[] { HashMapGeneratorHelper.GenerateHashMapWithCollision(), 42 },
			new object[] { HashMapGeneratorHelper.GenerateHashMapWithCollision(), 80 },
		};

		public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}