namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Desc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "Desc");
        }
    }
}
