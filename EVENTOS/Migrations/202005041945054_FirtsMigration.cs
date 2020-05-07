namespace EVENTOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirtsMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Eventoes", "Evento1_Id", "dbo.Eventoes");
            DropIndex("dbo.Eventoes", new[] { "Evento1_Id" });
            AddColumn("dbo.Eventoes", "Ciudad_Id", c => c.Int());
            CreateIndex("dbo.Eventoes", "Ciudad_Id");
            AddForeignKey("dbo.Eventoes", "Ciudad_Id", "dbo.Ciudads", "Id");
            DropColumn("dbo.Eventoes", "Evento1_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Eventoes", "Evento1_Id", c => c.Int());
            DropForeignKey("dbo.Eventoes", "Ciudad_Id", "dbo.Ciudads");
            DropIndex("dbo.Eventoes", new[] { "Ciudad_Id" });
            DropColumn("dbo.Eventoes", "Ciudad_Id");
            CreateIndex("dbo.Eventoes", "Evento1_Id");
            AddForeignKey("dbo.Eventoes", "Evento1_Id", "dbo.Eventoes", "Id");
        }
    }
}
