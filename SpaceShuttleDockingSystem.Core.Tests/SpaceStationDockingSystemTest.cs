using SpaceShuttleDockingSystem.UI.Implementation;
using Xunit;

namespace SpaceShuttleDockingSystem.Core.Tests
{
	public class SpaceStationDockingSystemTest
	{
		[Fact]
		public void Initialize()
		{
			var dockingSystem = new SpaceStationDockingSystem();

			Assert.IsAssignableFrom<IDockingSystem>(dockingSystem);
		}
	}
}