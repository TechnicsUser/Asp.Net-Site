namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.String(nullable: false, maxLength: 128),
                        Type = c.Int(nullable: false),
                        UserId = c.String(),
                        CreatedOn = c.String(),
                        RemovedOn = c.String(),
                        CommentOn = c.String(),
                        CommentTitle = c.String(),
                        CommentText = c.String(),
                        CommentViews = c.Int(nullable: false),
                        Removed = c.Boolean(nullable: false),
                        Reports = c.Int(nullable: false),
                        Likes = c.Int(nullable: false),
                        DisLikes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId);
            
            CreateTable(
                "dbo.CoralConnections",
                c => new
                    {
                        ConnectionId = c.Int(nullable: false, identity: true),
                        CoralId = c.Int(nullable: false),
                        UserId = c.String(),
                        CreatedOn = c.String(),
                        RemovedOn = c.String(),
                        Removed = c.Boolean(nullable: false),
                        FragTo = c.String(),
                        FragFrom = c.String(),
                        ColonyTo = c.String(),
                        ColonyFrom = c.String(),
                    })
                .PrimaryKey(t => t.ConnectionId);
            
            CreateTable(
                "dbo.CoralPhotoes",
                c => new
                    {
                        CoralPhotoId = c.Int(nullable: false, identity: true),
                        Photo = c.Binary(),
                        CoralId = c.Int(nullable: false),
                        UserId = c.String(),
                        CommentId = c.String(),
                        Likes = c.Int(nullable: false),
                        DisLikes = c.Int(nullable: false),
                        Views = c.Int(nullable: false),
                        CreatedOn = c.String(),
                        RemovedOn = c.String(),
                        Removed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CoralPhotoId);
            
            CreateTable(
                "dbo.Corals",
                c => new
                    {
                        CoralId = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Light = c.Int(nullable: false),
                        Flow = c.Int(nullable: false),
                        Food = c.Int(nullable: false),
                        Growth = c.Int(nullable: false),
                        Name = c.String(),
                        ScientificName = c.String(),
                        Details = c.String(),
                        Photo = c.Binary(),
                        UploadedBy = c.String(),
                        UploadedOn = c.String(),
                        Price = c.String(),
                        Size = c.String(),
                        FragSize = c.String(),
                        CommentId = c.String(),
                        Likes = c.Int(nullable: false),
                        DisLikes = c.Int(nullable: false),
                        Views = c.Int(nullable: false),
                        SoldOut = c.Boolean(nullable: false),
                        FragAvailable = c.Boolean(nullable: false),
                        FragAvailableFrom = c.String(),
                    })
                .PrimaryKey(t => t.CoralId);
            
            CreateTable(
                "dbo.Fish",
                c => new
                    {
                        FishId = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        TankSize = c.Int(nullable: false),
                        Name = c.String(),
                        ScientificName = c.String(),
                        Details = c.String(),
                        Photo = c.Binary(),
                        UploadedBy = c.String(),
                        UploadedOn = c.String(),
                        Price = c.String(),
                        Size = c.String(),
                        FishSize = c.String(),
                        CommentId = c.String(),
                        Likes = c.Int(nullable: false),
                        DisLikes = c.Int(nullable: false),
                        Views = c.Int(nullable: false),
                        SoldOut = c.Boolean(nullable: false),
                        FishAvailable = c.Boolean(nullable: false),
                        FishAvailableFrom = c.String(),
                    })
                .PrimaryKey(t => t.FishId);
            
            CreateTable(
                "dbo.fishPhotoes",
                c => new
                    {
                        FishPhotoId = c.Int(nullable: false, identity: true),
                        Photo = c.Binary(),
                        FishId = c.Int(nullable: false),
                        UserId = c.String(),
                        CommentId = c.String(),
                        Likes = c.Int(nullable: false),
                        DisLikes = c.Int(nullable: false),
                        Views = c.Int(nullable: false),
                        CreatedOn = c.String(),
                        RemovedOn = c.String(),
                        Removed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FishPhotoId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        MessageType = c.Int(nullable: false),
                        Title = c.String(),
                        Subject = c.String(),
                        Content = c.String(),
                        IsReply = c.Boolean(nullable: false),
                        MessageTo = c.String(),
                        MessageFrom = c.String(),
                        UserId = c.String(),
                        IsDismissed = c.Boolean(nullable: false),
                        SenderDeleted = c.Boolean(nullable: false),
                        RecieverDeleted = c.Boolean(nullable: false),
                        IsReported = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MessageId);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        NotificationId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        NotificationType = c.Int(nullable: false),
                        Controller = c.String(),
                        Action = c.String(),
                        UserId = c.String(),
                        IsDismissed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.NotificationId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CssTheme = c.String(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IdUserName = c.String(),
                        LocationLon = c.String(),
                        LocationLat = c.String(),
                        UserPhoto = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Notifications");
            DropTable("dbo.Messages");
            DropTable("dbo.fishPhotoes");
            DropTable("dbo.Fish");
            DropTable("dbo.Corals");
            DropTable("dbo.CoralPhotoes");
            DropTable("dbo.CoralConnections");
            DropTable("dbo.Comments");
        }
    }
}
