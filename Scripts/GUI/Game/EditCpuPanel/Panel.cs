using Godot;

namespace HardwareTycoon.Scripts.GUI.Game.EditCpuPanel;

public partial class Panel : Godot.Panel
{
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
	}

	private void _on_close_button_pressed()
	{
		Visible = false;
	}

	private void _on_new_cpu_button_pressed()
	{
		Visible = true;
	}
}