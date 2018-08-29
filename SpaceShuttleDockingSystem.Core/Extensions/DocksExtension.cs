using System.Collections.Generic;
using SpaceShuttleDockingSystem.Core.Docks;
using SpaceShuttleDockingSystem.Core.PositionSelectionStrategies;

namespace SpaceShuttleDockingSystem.Core.Extensions
{
	internal static class DocksExtension
	{
		public static int Find(this ICollection<IDock> docks, IPositionSelectionStrategy strategy) => strategy.Find(docks);
	}
}