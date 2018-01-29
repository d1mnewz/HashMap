using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace HashMap.Tests
{
	public class HashMapTests
	{
		[InlineData(1, "hello")]
		[InlineData(2, "world")]
		[InlineData(42, "something")]
		[InlineData(69, "bang")]
		[InlineData(146, "wtf")]
		[Theory]
		public void AddOneElementToEmptyMap(int key, string value)
		{
			var map = new HashMap<int, string>();
			map.Add(key, value);
			Assert.True(map.Contains(key));
		}

		[ClassData(typeof(HashMapWithCollisionContainsGenerator))]
		[Theory]
		public void HashMapContains(IMap<int, string> map, int key)
		{
			Assert.True(map.Contains(key));
		}

		[ClassData(typeof(HashMapWithCollisionNotContainsGenerator))]
		[Theory]
		public void HashMapContainsMustBeFalse(IMap<int, string> map, int key)
		{
			Assert.True(!map.Contains(key));
		}


		public class HashMapWithCollisionContainsGenerator : IEnumerable<object[]>
		{
			private readonly List<object[]> _data = new List<object[]>
			{
				new object[] { GenerateHashMapWithCollision(), 1 },
				new object[] { GenerateHashMapWithCollision(), 6 },
				new object[] { GenerateHashMapWithCollision(), 11 },
			};

			public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

			IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		}

		public class HashMapWithCollisionNotContainsGenerator : IEnumerable<object[]>
		{
			private readonly List<object[]> _data = new List<object[]>
			{
				new object[] { GenerateHashMapWithCollision(), 2 },
				new object[] { GenerateHashMapWithCollision(), 42 },
				new object[] { GenerateHashMapWithCollision(), 80 },
			};

			public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

			IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		}


		private static HashMap<int, string> GenerateHashMapWithCollision()
		{
			var map = new HashMap<int, string>();
			map.Add(1, 1.ToString());
			map.Add(6, 6.ToString());
			map.Add(11, 11.ToString());
			return map;
		}
	}
}