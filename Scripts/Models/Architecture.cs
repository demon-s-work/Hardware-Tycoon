using Godot;

namespace HardwareTycoon.Scripts.Models
{
	public partial class Architecture : GodotObject
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int InventionYear { get; set; }
	}
		/*
		a9090,
		x86,
		ARM32,
		ARM64,
		AVR,
		AVR32,
		POWER,
		EKARMA,
*/
}