using SpaceShuttleDockingSystem.Core;
using SpaceShuttleDockingSystem.UI.Implementation;
using SpaceShuttleDockingSystem.UI.InputOutputs;
using SpaceShuttleDockingSystem.UI.PrintOptions;

namespace SpaceShuttleDockingSystem.UI
{
	internal sealed class Bootstrapper
	{
		public void Initialize()
		{
			Container.RegisterType<IApplication, Application>();
			Container.RegisterType<IDockingSystem, SpaceStationDockingSystem>();
			Container.RegisterType<IInputOutput, ConsoleInputOutput>();
			Container.RegisterType<IPrintOptionFactory, PrintOptionFactory>();
		}
	}
}