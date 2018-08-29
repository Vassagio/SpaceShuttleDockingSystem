using System;
using System.Drawing;
using SpaceShuttleDockingSystem.UI.Extensions;
using SpaceShuttleDockingSystem.UI.InputOutputs;

namespace SpaceShuttleDockingSystem.UI.PrintOptions
{
	internal sealed class PrintNumericGraph : IPrintNumericGraph, IEquatable<PrintNumericGraph>
	{
		private readonly IInputOutput _io;
		private Color _background = Color.Black;
		private string _delimiter = string.Empty;

		private Color _foreground = Color.White;

		public PrintNumericGraph(IInputOutput io) => _io = io;

		public bool Equals(PrintNumericGraph other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;

			return _foreground == other._foreground &&
			       _background == other._background &&
			       string.Equals(_delimiter, other._delimiter);
		}

		public void Print(int[] configuration)
		{
			var currentForeground = _io.GetForegroundColor();
			var currentBackground = _io.GetBackgroundColor();
			_io.SetForegroundColor(_foreground);
			_io.SetBackgroundColor(_background);
			_io.Write("     ");

			var result = configuration.Join(_delimiter);

			_io.Write(result);
			_io.SetForegroundColor(currentForeground);
			_io.SetBackgroundColor(currentBackground);
		}

		public IPrintNumericGraph WithForeground(Color foreground)
		{
			_foreground = foreground;
			return this;
		}

		public IPrintNumericGraph WithBackground(Color background)
		{
			_background = background;
			return this;
		}

		public IPrintNumericGraph DelimitedBy(string delimiter)
		{
			_delimiter = delimiter;
			return this;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;

			return obj is PrintNumericGraph other && Equals(other);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = _foreground.GetHashCode();
				hashCode = (hashCode * 397) ^ _background.GetHashCode();
				hashCode = (hashCode * 397) ^ _delimiter.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(PrintNumericGraph left, PrintNumericGraph right) => Equals(left, right);
		public static bool operator !=(PrintNumericGraph left, PrintNumericGraph right) => !Equals(left, right);
	}
}