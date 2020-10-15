namespace RepositoryDesignPattern.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddresses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Street = c.String(),
                        Town = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addresses");
        }
    }
}
