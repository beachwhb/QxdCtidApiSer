namespace QxdCtidApiSer.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntityCtidRecog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CtidRecogs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CustomerNo = c.String(),
                        AppName = c.String(),
                        TerminalNo = c.String(),
                        TimeStamp = c.String(),
                        BusinessSerialNumber = c.String(),
                        ResultCode = c.Int(nullable: false),
                        ResultMessage = c.String(),
                        AuthResult = c.String(),
                        Similarity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReservedData = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CtidRecog_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.CtidRecogs", new[] { "IsDeleted" });
            DropTable("dbo.CtidRecogs",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CtidRecog_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
