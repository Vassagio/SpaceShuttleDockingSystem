using SpaceShuttleDockingSystem.UI.Implementation;

namespace SpaceShuttleDockingSystem.UI.Results
{
	internal sealed class ValidInputResult : IValidResult
	{
		public int[] Configuration { get; }
		public ValidInputResult(int[] configuration) => Configuration = configuration;
	}
}