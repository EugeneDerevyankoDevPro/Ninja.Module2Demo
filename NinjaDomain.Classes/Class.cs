using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NinjaDomain.Classes.Enums;

namespace NinjaDomain.Classes
{
	// This project can output the Class library as a NuGet Package.
	// To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
	public class Ninja
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool ServedInOniwaban { get; set; }
		public Clan Clan { get; set; }
		public int ClanId { get; set; }
		public List<NinjaEquipment> EquipmentOwed { get; set; }
		public DateTime DateOfBirth { get; set; }
	}

	public class Clan
	{
		public int Id { get; set; }
		public string ClasnName { get; set; }
		public List<Ninja> Ninjas { get; set; }
	}

	public class NinjaEquipment
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public EquipmentType Type { get; set; }
		[Required]
		public Ninja Ninja { get; set; }
	}

}
