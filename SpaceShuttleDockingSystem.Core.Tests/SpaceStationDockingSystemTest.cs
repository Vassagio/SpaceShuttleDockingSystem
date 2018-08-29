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

		[Theory]
		[InlineData(new[] {0}, new[] {1})]
		[InlineData(new[] {1, 0}, new[] {1, 1})]
		[InlineData(new[] {1, 0, 0}, new[] {1, 0, 1})]
		public void Dock_WhenValid_ReturnsNewConfiguration(int[] configuration, int[] expected)
		{
			var dockingSystem = new SpaceStationDockingSystem();

			var result = dockingSystem.Dock(configuration);

			Assert.Equal(expected, result);
		}
	}
}