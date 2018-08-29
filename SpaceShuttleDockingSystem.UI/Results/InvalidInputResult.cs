using SpaceShuttleDockingSystem.UI.Implementation;

namespace SpaceShuttleDockingSystem.UI.Results
{
	internal sealed class InvalidInputResult : IInvalidResult
	{
		public string Message => "You have used an invalid representation of occupancy.  Please enter a (1) for occupied and (0) for unoccupied.";
	}
}