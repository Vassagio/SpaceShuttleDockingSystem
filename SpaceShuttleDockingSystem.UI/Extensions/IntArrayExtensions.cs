using System.Collections.Generic;
using System.Linq;
using SpaceShuttleDockingSystem.UI.Implementation;
using SpaceShuttleDockingSystem.UI.PrintOptions;

namespace SpaceShuttleDockingSystem.UI.Extensions
{
	internal static class IntArrayExtensions
	{
		public static string Join(this int[] configuration, string delimiter = "") =>
			configuration.Aggregate(string.Empty, (current, stall) => current + Format(stall, delimiter))
			             .TrimEnd(delimiter.ToCharArray());

		private static string Format(int position, string delimiter = null) => $"{position}{delimiter}";

		public static void Print(this int[] configuration, IEnumerable<IPrintOption> printOptions)
		{
			foreach (var printOption in printOptions)
				printOption.Print(configuration);
		}
	}
}