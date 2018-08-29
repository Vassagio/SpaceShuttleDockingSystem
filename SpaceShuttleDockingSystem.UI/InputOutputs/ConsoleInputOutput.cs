using System;
using System.Drawing;
using SpaceShuttleDockingSystem.UI.Extensions;

namespace SpaceShuttleDockingSystem.UI.InputOutputs
{
	internal class ConsoleInputOutput : IInputOutput
	{
		private Color _backgroundColor;
		private Color _foregroundColor;

		public ConsoleInputOutput()
		{
			_backgroundColor = Console.BackgroundColor.ToColor();
			_foregroundColor = Console.ForegroundColor.ToColor();
		}

		public void WriteLine(string format = "") => Console.WriteLine(format);
		public void Write(string format = "") => Console.Write(format);

		public string ReadLine()
		{
			var result = Console.ReadLine();
			return result ?? string.Empty;
		}

		public void Clear() => Console.Clear();
		public Color GetBackgroundColor() => _backgroundColor;
		public Color GetForegroundColor() => _foregroundColor;

		public void SetBackgroundColor(Color backgroundColor)
		{
			_backgroundColor = backgroundColor;
			Console.BackgroundColor = _backgroundColor.ToConsoleColor();
		}

		public void SetForegroundColor(Color foregroundColor)
		{
			_foregroundColor = foregroundColor;
			Console.ForegroundColor = _foregroundColor.ToConsoleColor();
		}
	}
}