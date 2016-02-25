namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabase4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Carriers", "Cnpj", c => c.String(nullable: false, maxLength: 18, unicode: false));
            AlterColumn("dbo.Carriers", "Ie", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.Carriers", "Cep", c => c.String(nullable: false, maxLength: 9, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Carriers", "Cep", c => c.String(nullable: false, maxLength: 8, unicode: false));
            AlterColumn("dbo.Carriers", "Ie", c => c.String(maxLength: 12, unicode: false));
            AlterColumn("dbo.Carriers", "Cnpj", c => c.String(nullable: false, maxLength: 14, unicode: false));
        }
    }
}
