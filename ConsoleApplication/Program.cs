using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjaDomain.Classes;
using NinjaDomain.DataModel;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args) {
			Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
			InsertNinja();
			Console.ReadKey();
		}

		private static void InsertNinja() {
			var ninja = new Ninja
			{
				Name = "C Name",
				ServedInOniwaban = true,
				DateOfBirth = new DateTime(1990, 1, 1),
				ClanId = 1
			};
			var ninja1 = new Ninja
			{
				Name = "C Name",
				ServedInOniwaban = true,
				DateOfBirth = new DateTime(1990, 1, 1),
				ClanId = 1
			};

			using (var context = new NinjaContext()) {
				context.Database.Log = Console.WriteLine;
				context.Ninjas.AddRange(new [] { ninja, ninja1 });
				context.SaveChanges();
			}
		}

	}
}
