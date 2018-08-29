using System.Linq;
using SpaceShuttleDockingSystem.UI.Implementation;

namespace SpaceShuttleDockingSystem.Core
{
	public class SpaceStationDockingSystem : IDockingSystem
	{
		public int[] Dock(int[] configuration)
		{
			if (configuration == null || !configuration.Any()) return new int[0];
			
			return new[] {1};
		}
	}
}