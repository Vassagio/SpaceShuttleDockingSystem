using SpaceShuttleDockingSystem.UI.Implementation;

namespace SpaceShuttleDockingSystem.Core
{
	public class SpaceStationDockingSystem : IDockingSystem
	{
		public int[] Dock(int[] configuration) => 
			configuration == null ? 
				new int[0] : 
				null;
	}
}