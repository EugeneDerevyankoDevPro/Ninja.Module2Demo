using System;
using System.Collections.Generic;
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
			InsertNinja();
			Console.ReadKey();
		}

		private static void InsertNinja() {
			var ninja = new Ninja {
				Name = "A Name",
				ServedInOniwaban = true,
				DateOfBirth = new DateTime(1980, 1, 1),
				ClanId = 1
			};

			using (var context = new NinjaContext()) {
				context.Database.Log = Console.WriteLine;
				context.Ninjas.Add(ninja);
				context.SaveChanges();
			}
		}

	}
}
