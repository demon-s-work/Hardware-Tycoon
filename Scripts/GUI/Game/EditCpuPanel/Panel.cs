using System.Linq;
using Godot;
using HardwareTycoon.Scripts.Models;

namespace HardwareTycoon.Scripts.GUI.Game.EditCpuPanel;

public partial class Panel : Godot.Panel
{
	private CpuModel _newCpu = new CpuModel();

	[Signal]
	public delegate void CpuAddedEventHandler(CpuModel cpu);

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

	private void _on_confirm_button_pressed()
	{
		_newCpu = GetCpuFromInputs();
		EmitSignal(SignalName.CpuAdded, _newCpu);
		Visible = false;
	}

	private CpuModel GetCpuFromInputs()
	{
		var name = GetNode<LineEdit>("MainLayout/GridContainer/IName");
		var cores = GetNode<SpinBox>("MainLayout/GridContainer/ICores");
		var arch = GetNode<OptionButton>("MainLayout/GridContainer/IArch");

		return new CpuModel
		{
			Name = name.Text,
			Cores = (int)cores.Value,
			Architecture = Constants.Architectures.First(a => a.Id == arch.Selected)
		};
	}
}