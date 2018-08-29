using SpaceShuttleDockingSystem.UI.InputOutputs;

namespace SpaceShuttleDockingSystem.UI.PrintOptions
{
	internal class PrintOptionFactory : IPrintOptionFactory
	{
		private readonly IInputOutput _io;

		public PrintOptionFactory(IInputOutput io) => _io = io;

		public IPrintNumericGraph CreateNumericGraph() => new PrintNumericGraph(_io);

		public IPrintColorGraph CreateColorGraph() => new PrintColorGraph(_io);
	}
}