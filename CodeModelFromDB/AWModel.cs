namespace CodeModelFromDB
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class AWModel : DbContext
	{
		public AWModel()
			: base("name=AWModel")
		{
		}

		public virtual DbSet<user> users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
