namespace AdvertsWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madePriceRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Adverts", "Name", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Adverts", "Name", c => c.String());
        }
    }
}
