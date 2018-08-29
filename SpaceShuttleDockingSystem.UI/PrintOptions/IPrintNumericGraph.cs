using System.Drawing;
using SpaceShuttleDockingSystem.UI.Implementation;

namespace SpaceShuttleDockingSystem.UI.PrintOptions
{
	internal interface IPrintNumericGraph : IPrintOption
	{
		IPrintNumericGraph WithForeground(Color foreground);
		IPrintNumericGraph WithBackground(Color background);
		IPrintNumericGraph DelimitedBy(string delimiter);
	}
}