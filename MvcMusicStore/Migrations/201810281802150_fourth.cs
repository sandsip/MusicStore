namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.Albums", "RDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Albums", "RDate", c => c.DateTime(nullable: false));
        }
    }
}
