using Xunit;
using FluentAssertions;
using HashMap.Tests.Infrastructure;

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
			map.Contains(key).Should().BeTrue();
		}

		[ClassData(typeof(HashMapWithCollisionContainsGenerator))]
		[Theory]
		public void HashMapContains(IMap<int, string> map, int key)
		{
			map.Contains(key).Should().BeTrue();
		}

		[ClassData(typeof(HashMapWithCollisionNotContainsGenerator))]
		[Theory]
		public void HashMapContainsMustBeFalse(IMap<int, string> map, int key)
		{
			map.Contains(key).Should().BeFalse();
		}
	}
}