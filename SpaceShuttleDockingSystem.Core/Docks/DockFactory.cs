using System;

namespace SpaceShuttleDockingSystem.Core.Docks
{
	internal class DockFactory
	{
		public IDock Create(int occupiedStatus, int index)
		{
			switch (occupiedStatus)
			{
				case 0:  return new EmptyDock(index);
				case 1:  return new OccupiedDock(index);
				default: throw new ArgumentException();
			}
		}
	}
}