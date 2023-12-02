using System.Collections.Generic;

namespace HardwareTycoon.Scripts.Models
{
	public static class Constants
	{
		public static List<Architecture> Architectures = new List<Architecture>
		{
			new Architecture
			{
				Id = 0,
				Name = "8080",
				InventionYear = 1974
			},
			new Architecture
			{
				Id = 1,
				Name = "x86",
				InventionYear = 1978
			},
			new Architecture
			{
				Id = 2,
				Name = "ARM32",
				InventionYear = 1983
			}
		};
	}
}