namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarrierPhoneNumbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarrierId = c.Int(nullable: false),
                        PhoneType = c.Int(nullable: false),
                        PhoneNumber = c.String(maxLength: 20, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carriers", t => t.CarrierId)
                .Index(t => t.CarrierId);
            
            CreateTable(
                "dbo.Carriers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonType = c.Int(nullable: false),
                        CompanyName = c.String(nullable: false, maxLength: 150, unicode: false),
                        TradingName = c.String(nullable: false, maxLength: 120, unicode: false),
                        CpfCnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                        RgIe = c.String(maxLength: 12, unicode: false),
                        Email = c.String(maxLength: 256, unicode: false),
                        Address = c.String(nullable: false, maxLength: 150, unicode: false),
                        Number = c.String(nullable: false, maxLength: 10, unicode: false),
                        Complement = c.String(maxLength: 20, unicode: false),
                        Neighborhood = c.String(nullable: false, maxLength: 80, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 8, unicode: false),
                        State = c.String(maxLength: 2, fixedLength: true, unicode: false),
                        City = c.String(maxLength: 100, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarrierId = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128, unicode: false),
                        Rate = c.Int(nullable: false),
                        Message = c.String(maxLength: 256, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carriers", t => t.CarrierId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.CarrierId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128, unicode: false),
                        Email = c.String(maxLength: 256, unicode: false),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(maxLength: 120, unicode: false),
                        SecurityStamp = c.String(maxLength: 120, unicode: false),
                        PhoneNumber = c.String(maxLength: 120, unicode: false),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256, unicode: false),
                        HastaId = c.String(maxLength: 120, unicode: false),
                        Name = c.String(maxLength: 120, unicode: false),
                        DocumentNumber = c.String(maxLength: 14, unicode: false),
                        Vip = c.Boolean(nullable: false),
                        VipMessage = c.String(maxLength: 120, unicode: false),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 120, unicode: false),
                        ClaimType = c.String(maxLength: 120, unicode: false),
                        ClaimValue = c.String(maxLength: 120, unicode: false),
                        IdentityUser_Id = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128, unicode: false),
                        ProviderKey = c.String(nullable: false, maxLength: 128, unicode: false),
                        UserId = c.String(nullable: false, maxLength: 128, unicode: false),
                        IdentityUser_Id = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.Users", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128, unicode: false),
                        RoleId = c.String(nullable: false, maxLength: 128, unicode: false),
                        IdentityUser_Id = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .ForeignKey("dbo.Users", t => t.IdentityUser_Id)
                .Index(t => t.RoleId)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Name = c.String(nullable: false, maxLength: 256, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarrierPhoneNumbers", "CarrierId", "dbo.Carriers");
            DropForeignKey("dbo.Ratings", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "IdentityUser_Id", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserLogins", "IdentityUser_Id", "dbo.Users");
            DropForeignKey("dbo.UserClaims", "IdentityUser_Id", "dbo.Users");
            DropForeignKey("dbo.Ratings", "CarrierId", "dbo.Carriers");
            DropIndex("dbo.UserRoles", new[] { "IdentityUser_Id" });
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserLogins", new[] { "IdentityUser_Id" });
            DropIndex("dbo.UserClaims", new[] { "IdentityUser_Id" });
            DropIndex("dbo.Ratings", new[] { "UserId" });
            DropIndex("dbo.Ratings", new[] { "CarrierId" });
            DropIndex("dbo.CarrierPhoneNumbers", new[] { "CarrierId" });
            DropTable("dbo.Roles");
            DropTable("dbo.UserRoles");
            DropTable("dbo.UserLogins");
            DropTable("dbo.UserClaims");
            DropTable("dbo.Users");
            DropTable("dbo.Ratings");
            DropTable("dbo.Carriers");
            DropTable("dbo.CarrierPhoneNumbers");
        }
    }
}
