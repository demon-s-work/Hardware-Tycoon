using Godot;

namespace PU_Tycoon.Scripts.GUI.MainMenu
{
	public partial class PlayButton : Button
	{
		private PackedScene _scene = ResourceLoader.Load<PackedScene>("res://Scenes/GameScene.tscn");

		public override void _Ready()
		{
		}

		public override void _Process(double delta)
		{
		}

		private void _on_pressed()
		{
			GetTree().ChangeSceneToPacked(_scene);
		}
	}
}