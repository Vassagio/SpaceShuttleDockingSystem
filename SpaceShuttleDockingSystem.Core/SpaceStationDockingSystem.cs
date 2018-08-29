using System;
using System.Linq;
using SpaceShuttleDockingSystem.UI.Implementation;

namespace SpaceShuttleDockingSystem.Core
{
	public class SpaceStationDockingSystem : IDockingSystem
	{
		public int[] Dock(int[] configuration)
		{
			if (configuration == null) return new int[0];
			if (!configuration.Any()) return new int[0];

			var bestIndex = Array.IndexOf(configuration, 0);
			var maxBufferLength = 0;
			for (var unoccupiedIndex = 0; unoccupiedIndex < configuration.Length; unoccupiedIndex++)
			{
				if (configuration[unoccupiedIndex] == 1) continue;

				for (var occupiedIndex = 0; occupiedIndex < configuration.Length; occupiedIndex++)
				{
					if (configuration[occupiedIndex] == 0) continue;

					var bufferLength = Math.Abs(unoccupiedIndex - occupiedIndex);
					if (maxBufferLength >= bufferLength) continue;

					maxBufferLength = bufferLength;
					bestIndex = unoccupiedIndex;
				}
			}

			configuration[bestIndex] = 1;
			return configuration;
		}
	}
}