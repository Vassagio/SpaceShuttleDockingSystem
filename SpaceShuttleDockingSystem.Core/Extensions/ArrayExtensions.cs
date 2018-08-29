using System.Collections.Generic;
using System.Linq;
using SpaceShuttleDockingSystem.Core.Docks;

namespace SpaceShuttleDockingSystem.Core.Extensions
{
	internal static class ArrayExtensions
	{
		public static bool IsValid(this int[] items) =>
			!(items is null) &&
			items.Any();

		public static IEnumerable<IDock> AsDocks(this int[] items)
		{
			var factory = new DockFactory();
			for (var i = 0; i < items.Length; i++)
				yield return factory.Create(items[i], i);
		}
	}
}