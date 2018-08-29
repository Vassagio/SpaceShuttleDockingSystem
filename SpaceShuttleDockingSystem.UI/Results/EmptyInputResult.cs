using SpaceShuttleDockingSystem.UI.Implementation;

namespace SpaceShuttleDockingSystem.UI.Results
{
	internal sealed class EmptyInputResult : IInvalidResult
	{
		public string Message => "You have entered an empty string.  Please enter a configuration: Ones (1) and Zeros (0) delimited by commas (,)";
	}
}