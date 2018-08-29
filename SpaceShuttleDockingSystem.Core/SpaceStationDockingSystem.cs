using System.Linq;
using SpaceShuttleDockingSystem.Core.Extensions;
using SpaceShuttleDockingSystem.Core.PositionSelectionStrategies;
using SpaceShuttleDockingSystem.UI.Implementation;

namespace SpaceShuttleDockingSystem.Core
{
	public class SpaceStationDockingSystem : IDockingSystem
	{
		private const int OCCUPIED = 1;
		private static readonly int[] EMPTY_CONFIGURATION = new int[0];

		public int[] Dock(int[] configuration)
		{
			if (!configuration.IsValid()) return EMPTY_CONFIGURATION;

			var docks = configuration.AsDocks().ToList();

			var safestPosition = docks.Find(new SafestPosition());

			configuration[safestPosition] = OCCUPIED;
			return configuration;
		}
	}
}