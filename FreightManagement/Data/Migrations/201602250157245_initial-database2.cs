namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabase2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carriers", "Cnpj", c => c.String(nullable: false, maxLength: 14, unicode: false));
            AddColumn("dbo.Carriers", "Ie", c => c.String(maxLength: 12, unicode: false));
            DropColumn("dbo.Carriers", "PersonType");
            DropColumn("dbo.Carriers", "CpfCnpj");
            DropColumn("dbo.Carriers", "RgIe");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carriers", "RgIe", c => c.String(maxLength: 12, unicode: false));
            AddColumn("dbo.Carriers", "CpfCnpj", c => c.String(nullable: false, maxLength: 14, unicode: false));
            AddColumn("dbo.Carriers", "PersonType", c => c.Int(nullable: false));
            DropColumn("dbo.Carriers", "Ie");
            DropColumn("dbo.Carriers", "Cnpj");
        }
    }
}
