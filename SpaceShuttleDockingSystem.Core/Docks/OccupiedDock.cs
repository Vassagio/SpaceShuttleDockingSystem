namespace SpaceShuttleDockingSystem.Core.Docks
{
	internal class OccupiedDock : IDock
	{
		public int Index { get; }

		public OccupiedDock(int index) => Index = index;
	}
}