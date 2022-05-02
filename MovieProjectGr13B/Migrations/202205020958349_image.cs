namespace MovieProjectGr13B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class image : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ImageLink", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ImageLink", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
