namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                    })
                .PrimaryKey(t => t.GroupId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        DisplayName = c.String(),
                        Group_GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.Username)
                .ForeignKey("dbo.Groups", t => t.Group_GroupId)
                .Index(t => t.Group_GroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Group_GroupId", "dbo.Groups");
            DropIndex("dbo.Users", new[] { "Group_GroupId" });
            DropTable("dbo.Users");
            DropTable("dbo.Groups");
        }
    }
}
