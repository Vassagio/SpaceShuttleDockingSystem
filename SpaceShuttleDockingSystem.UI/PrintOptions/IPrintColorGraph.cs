using System.Drawing;
using SpaceShuttleDockingSystem.UI.Implementation;

namespace SpaceShuttleDockingSystem.UI.PrintOptions
{
	internal interface IPrintColorGraph : IPrintOption
	{
		IPrintColorGraph WithOccupiedBackground(Color background);
		IPrintColorGraph WithUnoccupiedBackground(Color background);
	}
}