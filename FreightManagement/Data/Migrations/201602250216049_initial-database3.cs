namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabase3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Carriers", "State", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Carriers", "State", c => c.String(maxLength: 2, fixedLength: true, unicode: false));
        }
    }
}
