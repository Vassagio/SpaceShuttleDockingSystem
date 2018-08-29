namespace SpaceShuttleDockingSystem.UI.PrintOptions
{
	internal interface IPrintOptionFactory
	{
		IPrintNumericGraph CreateNumericGraph();
		IPrintColorGraph CreateColorGraph();
	}
}