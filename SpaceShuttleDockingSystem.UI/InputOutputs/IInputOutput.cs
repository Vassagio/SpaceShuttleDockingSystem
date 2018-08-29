using System.Drawing;

namespace SpaceShuttleDockingSystem.UI.InputOutputs
{
	internal interface IInputOutput
	{
		void WriteLine(string format = "");
		void Write(string format = "");
		string ReadLine();
		void Clear();
		Color GetBackgroundColor();
		Color GetForegroundColor();
		void SetBackgroundColor(Color backgroundColor);
		void SetForegroundColor(Color foregroundColor);
	}
}