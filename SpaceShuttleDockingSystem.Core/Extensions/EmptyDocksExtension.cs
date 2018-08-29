using System.Collections.Generic;
using System.Linq;
using SpaceShuttleDockingSystem.Core.Docks;

namespace SpaceShuttleDockingSystem.Core.Extensions
{
	internal static class EmptyDocksExtension
	{
		public static IEnumerable<IEmptyDock> GetMaxMinBuffer(this IEnumerable<IEmptyDock> emptyDocks)
		{
			var items = emptyDocks.ToList();
			var maxMinimum = items.GroupBy(d => d).Select(g => g.Max(s => s.MinimumBuffer)).Max();
			return items.Where(d => d.MinimumBuffer == maxMinimum);
		}

		public static IEnumerable<IEmptyDock> GetMaxMaxBuffer(this IEnumerable<IEmptyDock> emptyDocks)
		{
			var items = emptyDocks.ToList();
			var maxMaximum = items.GroupBy(d => d).Select(g => g.Max(s => s.MaximumBuffer)).Max();
			return items.Where(d => d.MaximumBuffer == maxMaximum);
		}
	}
}