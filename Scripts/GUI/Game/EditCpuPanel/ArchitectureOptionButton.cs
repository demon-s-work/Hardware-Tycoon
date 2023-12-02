using Godot;
using HardwareTycoon.Scripts.Models;

namespace HardwareTycoon.Scripts.GUI.Game.EditCpuPanel
{
	public partial class ArchitectureOptionButton : OptionButton
	{
		public override void _Ready()
		{
			Constants.Architectures.ForEach(a => {
				AddItem(a.Name, a.Id);
			});
		}

		public override void _Process(double delta)
		{
		}
	}
}