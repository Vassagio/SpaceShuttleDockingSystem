using SpaceShuttleDockingSystem.UI.PrintOptions;

namespace SpaceShuttleDockingSystem.UI
{
	internal sealed class Program
	{
		private static void Main()
		{
			new Bootstrapper().Initialize();
			var printOptionFactory = Container.Resolve<IPrintOptionFactory>();
			var application = Container.Resolve<IApplication>()
			                           .AddPrintOption(printOptionFactory.CreateColorGraph())
			                           .AddPrintOption(printOptionFactory.CreateNumericGraph())
			                           .Start();

			do
			{
				application.Play();
				application.PlayAgain();
			} while (application.IsRunning());
		}
	}
}