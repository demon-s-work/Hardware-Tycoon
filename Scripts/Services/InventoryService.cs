using System.Collections.Generic;
using Godot;
using HardwareTycoon.Scripts.Models;

namespace HardwareTycoon.Scripts.Services
{
	public partial class InventoryService : Node
	{
		private List<CpuModel> _releasedCpus = new List<CpuModel>();
		private void _on_edit_cpu_panel_cpu_added(CpuModel cpu)
		{
			_releasedCpus.Add(cpu);
		}
	}
}