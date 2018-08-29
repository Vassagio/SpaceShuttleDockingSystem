namespace SpaceShuttleDockingSystem.Core.Docks
{
	internal class EmptyDock : IEmptyDock
	{
		public int Index { get; }
		public int MinimumBuffer { get; set; } = 0;
		public int MaximumBuffer { get; set; } = 0;

		public EmptyDock(int index) => Index = index;

		public override string ToString() => $"{Index}: {MinimumBuffer}-{MaximumBuffer}";
	}
}