using System;
using System.Diagnostics;
using Xunit;

namespace HashMap.Tests
{
	public class HashMapTests
	{
		// TODO: cases with a collision 

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

		[InlineData(1)] // TODO: add some predefined maps for theory tests.
		[InlineData(2)]
		[InlineData(42)]
		[InlineData(69)]
		[InlineData(146)]
		[Theory]
		public void HashMapContains(IMap<int, string> map, int key)
		{
		}
	}
}