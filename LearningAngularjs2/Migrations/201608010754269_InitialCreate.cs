namespace LearningAngularjs2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(maxLength: 250),
                        description = c.String(),
                        link = c.String(),
                        text_link = c.String(maxLength: 20),
                        image = c.String(),
                        ghichu = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        idCategory = c.Int(nullable: false, identity: true),
                        idCategoryParent = c.Int(),
                        idUserCreated = c.String(maxLength: 50),
                        idUserModified = c.String(maxLength: 50),
                        timeCreated = c.DateTime(),
                        timeModified = c.DateTime(),
                        title = c.String(),
                        alias = c.String(),
                        note = c.String(),
                        description = c.String(),
                        published = c.Int(),
                        image = c.String(),
                        tags = c.String(),
                        version = c.String(maxLength: 50),
                        deleted = c.Int(),
                        metadescription = c.String(),
                        metakewords = c.String(),
                        author = c.String(maxLength: 50),
                        robots = c.String(maxLength: 50),
                        Category2_idCategory = c.Int(),
                    })
                .PrimaryKey(t => t.idCategory)
                .ForeignKey("dbo.Categories", t => t.Category2_idCategory)
                .Index(t => t.Category2_idCategory);
            
            CreateTable(
                "dbo.CategoryProducts",
                c => new
                    {
                        idCategory = c.Int(nullable: false, identity: true),
                        idCategoryParent = c.Int(),
                        idUserCreated = c.String(maxLength: 50),
                        idUserModified = c.String(maxLength: 50),
                        timeCreated = c.DateTime(),
                        timeModified = c.DateTime(),
                        title = c.String(),
                        alias = c.String(),
                        note = c.String(),
                        description = c.String(),
                        published = c.Int(),
                        image = c.String(),
                        tags = c.String(),
                        version = c.String(maxLength: 50),
                        deleted = c.Int(),
                        metadescription = c.String(),
                        metakewords = c.String(),
                        author = c.String(maxLength: 50),
                        robots = c.String(maxLength: 50),
                        CategoryProduct2_idCategory = c.Int(),
                    })
                .PrimaryKey(t => t.idCategory)
                .ForeignKey("dbo.CategoryProducts", t => t.CategoryProduct2_idCategory)
                .Index(t => t.CategoryProduct2_idCategory);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        idPost = c.Int(nullable: false, identity: true),
                        idCategory = c.Int(nullable: false),
                        idUserCreated = c.String(maxLength: 50),
                        idUserModified = c.String(maxLength: 50),
                        timeCreated = c.DateTime(),
                        timeModified = c.DateTime(),
                        title = c.String(maxLength: 500),
                        alias = c.String(),
                        content = c.String(),
                        note = c.String(),
                        description = c.String(maxLength: 1000),
                        published = c.Int(),
                        image = c.String(),
                        tags = c.String(),
                        version = c.String(maxLength: 50),
                        deleted = c.Int(),
                        featured = c.Int(),
                        metadescription = c.String(),
                        metakewords = c.String(),
                        author = c.String(maxLength: 50),
                        robots = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.idPost);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        idProduct = c.Int(nullable: false, identity: true),
                        idCategoryProduct = c.Int(),
                        idUserCreated = c.String(maxLength: 50),
                        idUserModified = c.String(maxLength: 50),
                        timeCreated = c.DateTime(),
                        timeModified = c.DateTime(),
                        title = c.String(maxLength: 50),
                        alias = c.String(),
                        content = c.String(),
                        note = c.String(),
                        description = c.String(),
                        price = c.Double(),
                        published = c.Int(),
                        image = c.String(),
                        tags = c.String(),
                        version = c.String(maxLength: 50),
                        deleted = c.Int(),
                        feature = c.String(),
                        metadescription = c.String(),
                        metakewords = c.String(),
                        author = c.String(maxLength: 50),
                        robots = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.idProduct);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 56),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.webpages_Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(maxLength: 250),
                        description = c.String(),
                        link_video = c.String(),
                        link_post = c.String(),
                        note = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.webpages_Membership",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(),
                        ConfirmationToken = c.String(maxLength: 128),
                        IsConfirmed = c.Boolean(),
                        LastPasswordFailureDate = c.DateTime(),
                        PasswordFailuresSinceLastSuccess = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 128),
                        PasswordChangedDate = c.DateTime(),
                        PasswordSalt = c.String(nullable: false, maxLength: 128),
                        PasswordVerificationToken = c.String(maxLength: 128),
                        PasswordVerificationTokenExpirationDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.webpages_OAuthMembership",
                c => new
                    {
                        Provider = c.String(nullable: false, maxLength: 30),
                        ProviderUserId = c.String(nullable: false, maxLength: 100),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Provider, t.ProviderUserId });
            
            CreateTable(
                "dbo.webpages_RolesUser",
                c => new
                    {
                        webpages_Roles_RoleId = c.Int(nullable: false),
                        User_UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.webpages_Roles_RoleId, t.User_UserId })
                .ForeignKey("dbo.webpages_Roles", t => t.webpages_Roles_RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .Index(t => t.webpages_Roles_RoleId)
                .Index(t => t.User_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.webpages_RolesUser", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.webpages_RolesUser", "webpages_Roles_RoleId", "dbo.webpages_Roles");
            DropForeignKey("dbo.CategoryProducts", "CategoryProduct2_idCategory", "dbo.CategoryProducts");
            DropForeignKey("dbo.Categories", "Category2_idCategory", "dbo.Categories");
            DropIndex("dbo.webpages_RolesUser", new[] { "User_UserId" });
            DropIndex("dbo.webpages_RolesUser", new[] { "webpages_Roles_RoleId" });
            DropIndex("dbo.CategoryProducts", new[] { "CategoryProduct2_idCategory" });
            DropIndex("dbo.Categories", new[] { "Category2_idCategory" });
            DropTable("dbo.webpages_RolesUser");
            DropTable("dbo.webpages_OAuthMembership");
            DropTable("dbo.webpages_Membership");
            DropTable("dbo.Videos");
            DropTable("dbo.webpages_Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.Posts");
            DropTable("dbo.CategoryProducts");
            DropTable("dbo.Categories");
            DropTable("dbo.Banners");
        }
    }
}
