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

		[Fact]
		public void Dock_WhenOneEntry_ReturnOccupiedArray()
		{
			var dockingSystem = new SpaceStationDockingSystem();

			var result = dockingSystem.Dock(new[] {0});

			Assert.Equal(new[] {1}, result);
		}

		[Fact]
		public void Dock_WhenOneUnoccupiedEntry_ReturnAllOccupiedArray()
		{
			var dockingSystem = new SpaceStationDockingSystem();

			var result = dockingSystem.Dock(new[] {1, 0});

			Assert.Equal(new[] {1, 1}, result);
		}

		[Fact]
		public void Dock_WhenLeftMostEntryUnoccupied_ReturnLeftMostEntryOccupiedArray()
		{
			var dockingSystem = new SpaceStationDockingSystem();

			var result = dockingSystem.Dock(new[] {0, 1, 0});

			Assert.Equal(new[] {1, 1, 0}, result);
		}

		[Fact]
		public void Dock_WhenMultipleUnoccupiedEntries_ReturnEntryOccupiedWithMostBufferArray()
		{
			var dockingSystem = new SpaceStationDockingSystem();

			var result = dockingSystem.Dock(new[] {1, 0, 0});

			Assert.Equal(new[] {1, 0, 1}, result);
		}
	}
}