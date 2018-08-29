using System.Collections.Generic;
using SpaceShuttleDockingSystem.Core.Docks;

namespace SpaceShuttleDockingSystem.Core.PositionSelectionStrategies
{
	internal interface IPositionSelectionStrategy
	{
		int Find(ICollection<IDock> docks);
	}
}