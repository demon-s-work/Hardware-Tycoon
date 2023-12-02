using Godot;

namespace HardwareTycoon.Scripts.Models
{
	public partial class CpuModel : GodotObject
	{
		public string Name { get; set; }
		public int Cores { get; set; }
		public Architecture Architecture { get; set; }
	}
}