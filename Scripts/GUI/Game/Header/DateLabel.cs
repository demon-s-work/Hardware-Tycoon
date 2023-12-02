using System;
using Godot;

namespace HardwareTycoon.Scripts.GUI.Game.Header
{
	public partial class DateLabel : Label
	{
		private const string Prefix = "CurrentDate: ";
		public override void _Ready()
		{
		}

		public override void _Process(double delta)
		{
		}

		private void _on_date_service_current_date_changed(long old, long @new)
		{
			Text = $"{Prefix}{DateTime.FromBinary(@new):d}";
		}
	}
}