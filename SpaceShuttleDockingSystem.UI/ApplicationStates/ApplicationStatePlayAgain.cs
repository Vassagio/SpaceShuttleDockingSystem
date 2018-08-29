using System;
using System.Collections.Generic;
using SpaceShuttleDockingSystem.UI.Implementation;
using SpaceShuttleDockingSystem.UI.InputOutputs;
using SpaceShuttleDockingSystem.UI.PrintOptions;
using SpaceShuttleDockingSystem.UI.Properties;

namespace SpaceShuttleDockingSystem.UI.ApplicationStates
{
	internal sealed class ApplicationStatePlayAgain : IApplicationState
	{
		private readonly IDockingSystem _dockingSystem;
		private readonly IInputOutput _io;
		private readonly IEnumerable<IPrintOption> _printOptions;

		public ApplicationStatePlayAgain(IDockingSystem dockingSystem, IInputOutput io, IEnumerable<IPrintOption> printOptions)
		{
			_dockingSystem = dockingSystem;
			_io = io;
			_printOptions = printOptions;
		}

		public IApplicationState Play() => this;

		public IApplicationState PlayAgain()
		{
			_io.WriteLine(Settings.Default.PlayAgainQuestion);
			var result = PlayAgain(_io.ReadLine());
			_io.Clear();

			if (result) return new ApplicationStatePlay(_dockingSystem, _io, _printOptions);

			return new ApplicationStateStop();
		}

		private static bool PlayAgain(string result) =>
			!string.IsNullOrWhiteSpace(result) &&
			result.Trim().Equals("Y", StringComparison.OrdinalIgnoreCase);
	}
}