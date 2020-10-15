namespace RepositoryDesignPattern.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressToPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Address_Id", c => c.Long());
            CreateIndex("dbo.People", "Address_Id");
            AddForeignKey("dbo.People", "Address_Id", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.People", new[] { "Address_Id" });
            DropColumn("dbo.People", "Address_Id");
        }
    }
}
