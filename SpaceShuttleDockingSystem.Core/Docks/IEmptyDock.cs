namespace SpaceShuttleDockingSystem.Core.Docks
{
	internal interface IEmptyDock : IDock
	{
		int MinimumBuffer { get; }
		int MaximumBuffer { get; }
	}
}