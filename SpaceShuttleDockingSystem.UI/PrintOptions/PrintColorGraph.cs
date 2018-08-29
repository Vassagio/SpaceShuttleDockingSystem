using System;
using System.Drawing;
using SpaceShuttleDockingSystem.UI.InputOutputs;

namespace SpaceShuttleDockingSystem.UI.PrintOptions
{
	internal sealed class PrintColorGraph : IPrintColorGraph, IEquatable<PrintColorGraph>
	{
		private readonly IInputOutput _io;
		private Color _backgroundOccupied = Color.DarkRed;
		private Color _backgroundUnoccupied = Color.DarkGreen;

		public PrintColorGraph(IInputOutput io) => _io = io;

		public bool Equals(PrintColorGraph other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;

			return _backgroundOccupied == other._backgroundOccupied &&
			       _backgroundUnoccupied == other._backgroundUnoccupied;
		}

		public void Print(int[] configuration)
		{
			var currentBackground = _io.GetBackgroundColor();
			_io.Write("     ");

			foreach (var position in configuration)
			{
				_io.SetBackgroundColor(position == 1 ? _backgroundOccupied : _backgroundUnoccupied);
				_io.Write(" ");
			}

			_io.SetBackgroundColor(currentBackground);
		}

		public IPrintColorGraph WithOccupiedBackground(Color background)
		{
			_backgroundOccupied = background;
			return this;
		}

		public IPrintColorGraph WithUnoccupiedBackground(Color background)
		{
			_backgroundUnoccupied = background;
			return this;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;

			return obj is PrintColorGraph other && Equals(other);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = _backgroundOccupied.GetHashCode();
				hashCode = (hashCode * 397) ^ _backgroundUnoccupied.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(PrintColorGraph left, PrintColorGraph right) => Equals(left, right);
		public static bool operator !=(PrintColorGraph left, PrintColorGraph right) => !Equals(left, right);
	}
}