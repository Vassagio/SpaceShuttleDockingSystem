namespace SpaceShuttleDockingSystem.UI.ApplicationStates
{
	internal interface IApplicationState
	{
		IApplicationState Play();
		IApplicationState PlayAgain();
	}
}