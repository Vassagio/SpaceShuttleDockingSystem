using System.Collections.Generic;
using SpaceShuttleDockingSystem.UI.ApplicationStates;
using SpaceShuttleDockingSystem.UI.Implementation;
using SpaceShuttleDockingSystem.UI.InputOutputs;
using SpaceShuttleDockingSystem.UI.PrintOptions;

namespace SpaceShuttleDockingSystem.UI
{
	internal sealed class Application : IApplication, IApplicationStart
	{
		private readonly IDockingSystem _dockingSystem;
		private readonly IInputOutput _io;
		private readonly ISet<IPrintOption> _printOptions = new HashSet<IPrintOption>();

		private IApplicationState _state;

		public Application(IDockingSystem dockingSystem, IInputOutput io)
		{
			_dockingSystem = dockingSystem;
			_io = io;
		}

		public IApplication AddPrintOption(IPrintOption printOption)
		{
			if (printOption != null)
				_printOptions.Add(printOption);
			return this;
		}

		public IApplicationStart Start()
		{
			_state = new ApplicationStatePlay(_dockingSystem, _io, _printOptions);
			return this;
		}

		public bool IsRunning() => !(_state is ApplicationStateStop);
		public void Play() => _state = _state.Play();
		public void PlayAgain() => _state = _state.PlayAgain();
	}

	internal interface IApplication
	{
		IApplication AddPrintOption(IPrintOption printOption);
		IApplicationStart Start();
	}

	internal interface IApplicationStart
	{
		bool IsRunning();
		void Play();
		void PlayAgain();
	}
}