using System.Collections.Generic;
using System.Linq;
using SpaceShuttleDockingSystem.Core.Docks;
using SpaceShuttleDockingSystem.Core.Extensions;

namespace SpaceShuttleDockingSystem.Core.PositionSelectionStrategies
{
	internal class SafestPosition : IPositionSelectionStrategy
	{
		public int Find(ICollection<IDock> docks)
		{
			foreach (var emptyDock in docks.OfType<EmptyDock>())
				SetBuffers(docks, emptyDock);

			return docks.OfType<IEmptyDock>()
			            .GetMaxMinBuffer()
			            .GetMaxMaxBuffer()
			            .First().Index;
		}

		private static void SetBuffers(ICollection<IDock> docks, EmptyDock emptyDock)
		{
			var (min, max) = docks.OfType<OccupiedDock>().GetBuffers(emptyDock, docks.Count);
			emptyDock.MinimumBuffer = min;
			emptyDock.MaximumBuffer = max;
		}
	}
}