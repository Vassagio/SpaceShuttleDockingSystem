using System;
using System.Collections.Generic;
using System.Linq;
using SpaceShuttleDockingSystem.Core.Docks;

namespace SpaceShuttleDockingSystem.Core.Extensions
{
	internal static class OccupiedDocksExtension
	{
		public static (int, int) GetBuffers(this IEnumerable<OccupiedDock> occupiedDocks, IEmptyDock emptyDock, int totalDocks)
		{
			const int MINIMUM_BUFFER = 1;
			var items = occupiedDocks.ToList();
			var previousOccupancy = items.LastOrDefault(d => d.Index < emptyDock.Index);
			var nextOccupancy = items.FirstOrDefault(d => d.Index > emptyDock.Index);
			var previousSafety = previousOccupancy != null ? Math.Abs(emptyDock.Index - previousOccupancy.Index) : MINIMUM_BUFFER;
			var nextSafety = nextOccupancy != null ? Math.Abs(emptyDock.Index - nextOccupancy.Index) : MINIMUM_BUFFER;
			return (Math.Min(previousSafety, nextSafety), Math.Max(previousSafety, nextSafety));
		}
	}
}