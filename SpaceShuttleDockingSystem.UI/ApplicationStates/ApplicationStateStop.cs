namespace SpaceShuttleDockingSystem.UI.ApplicationStates
{
	internal sealed class ApplicationStateStop : IApplicationState
	{
		public IApplicationState Play() => this;
		public IApplicationState PlayAgain() => this;
	}
}