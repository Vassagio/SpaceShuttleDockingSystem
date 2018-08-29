using System.Collections.Generic;
using System.Linq;
using SpaceShuttleDockingSystem.Core.Docks;

namespace SpaceShuttleDockingSystem.Core.PositionSelectionStrategies
{
	internal class LeftMostPosition : IPositionSelectionStrategy
	{
		public int Find(ICollection<IDock> docks) => docks.OfType<IEmptyDock>().First().Index;
	}
}