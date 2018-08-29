using System;
using System.Collections.Generic;
using System.Linq;
using Application.Utilities;
using SpaceShuttleDockingSystem.UI.Extensions;
using SpaceShuttleDockingSystem.UI.Implementation;
using SpaceShuttleDockingSystem.UI.InputOutputs;
using SpaceShuttleDockingSystem.UI.PrintOptions;
using SpaceShuttleDockingSystem.UI.Properties;
using SpaceShuttleDockingSystem.UI.Results;

namespace SpaceShuttleDockingSystem.UI.ApplicationStates
{
	internal sealed class ApplicationStatePlay : IApplicationState
	{
		private static readonly IReadOnlyList<int> VALID_STALL_ENTRIES = new[] {0, 1};
		private readonly IDockingSystem _dockingSystem;
		private readonly IInputOutput _io;
		private readonly IEnumerable<IPrintOption> _printOptions;

		public ApplicationStatePlay(IDockingSystem dockingSystem, IInputOutput io, IEnumerable<IPrintOption> printOptions)
		{
			_dockingSystem = dockingSystem;
			_io = io;
			_printOptions = printOptions;
		}

		public IApplicationState Play()
		{
			Run().Handle(RunValidStalls, DisplayInvalidMessage);
			return new ApplicationStatePlayAgain(_dockingSystem, _io, _printOptions);
		}

		public IApplicationState PlayAgain() => this;

		private Either<IValidResult, IInvalidResult> Run()
		{
			const char DELIMITER = ',';
			_io.WriteLine(Settings.Default.ConfigurationQuestion);
			var stallConfig = _io.ReadLine();
			if (string.IsNullOrWhiteSpace(stallConfig)) return new EmptyInputResult();

			var tokens = stallConfig.Trim(DELIMITER).Split(DELIMITER);
			var stalls = Array.ConvertAll(tokens, int.Parse);
			if (stalls.Any(s => !VALID_STALL_ENTRIES.Contains(s))) return new InvalidInputResult();

			return new ValidInputResult(stalls);
		}

		private void RunValidStalls(IValidResult result)
		{
			var configuration = result.Configuration;
			_io.WriteLine();
			configuration.Print(_printOptions);
			_io.WriteLine();
			_io.ReadLine();

			do
			{
				configuration = _dockingSystem.Dock(configuration);
				configuration.Print(_printOptions);
				_io.WriteLine();
			} while (configuration.Count(s => s == 0) != 0);
		}

		private void DisplayInvalidMessage(IInvalidResult result) => _io.WriteLine(result.Message);
	}
}