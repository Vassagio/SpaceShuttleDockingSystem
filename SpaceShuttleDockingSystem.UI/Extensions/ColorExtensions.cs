using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SpaceShuttleDockingSystem.UI.Extensions
{
	public static class ColorExtensions
	{
		private static readonly IReadOnlyDictionary<ConsoleColor, Color> COLORS = new Dictionary<ConsoleColor, Color>
		{
			{ConsoleColor.Black, Color.Black},
			{ConsoleColor.DarkBlue, Color.DarkBlue},
			{ConsoleColor.DarkGreen, Color.DarkGreen},
			{ConsoleColor.DarkCyan, Color.DarkCyan},
			{ConsoleColor.DarkRed, Color.DarkRed},
			{ConsoleColor.DarkMagenta, Color.DarkMagenta},
			{ConsoleColor.DarkYellow, Color.Goldenrod},
			{ConsoleColor.Gray, Color.Gray},
			{ConsoleColor.DarkGray, Color.DarkGray},
			{ConsoleColor.Blue, Color.Blue},
			{ConsoleColor.Green, Color.Green},
			{ConsoleColor.Cyan, Color.Cyan},
			{ConsoleColor.Red, Color.Red},
			{ConsoleColor.Magenta, Color.Magenta},
			{ConsoleColor.Yellow, Color.Yellow},
			{ConsoleColor.White, Color.White}
		};

		public static Color ToColor(this ConsoleColor consoleColor) => COLORS[consoleColor];
		public static ConsoleColor ToConsoleColor(this Color color) => COLORS.FirstOrDefault(c => c.Value == color).Key;
	}
}