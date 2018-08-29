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

		[Fact]
		public void Dock_WhenNull_ReturnEmptyArray()
		{
			var dockingSystem = new SpaceStationDockingSystem();

			var result = dockingSystem.Dock(null);

			Assert.Empty(result);
		}

		[Fact]
		public void Dock_WhenEmptyArray_ReturnEmptyArray()
		{
			var dockingSystem = new SpaceStationDockingSystem();

			var result = dockingSystem.Dock(new int[] { });

			Assert.Empty(result);
		}
	}
}