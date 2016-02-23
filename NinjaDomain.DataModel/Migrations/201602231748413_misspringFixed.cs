namespace NinjaDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class misspringFixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clans", "ClanName", c => c.String());
			DropColumn("dbo.Clans", "ClasnName");
			Sql("insert into clans (ClanName) values ('Vermont Ninjas')");
		}
        
        public override void Down()
        {
            AddColumn("dbo.Clans", "ClasnName", c => c.String());
            DropColumn("dbo.Clans", "ClanName");
        }
    }
}
