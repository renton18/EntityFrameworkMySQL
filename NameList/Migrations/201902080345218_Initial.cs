namespace NameList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.m_department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        departmentId = c.Int(nullable: false),
                        phoneNumber = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        upPersonId = c.Int(nullable: false),
                        createdDateTime = c.DateTime(nullable: false, precision: 0),
                        updatedDateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.m_person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        personId = c.Int(nullable: false),
                        personName = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        departmentId = c.Int(nullable: false),
                        mailAddress = c.String(unicode: false),
                        phoneNumber = c.String(maxLength: 100, storeType: "nvarchar"),
                        detail = c.String(maxLength: 100, storeType: "nvarchar"),
                        createdDateTime = c.DateTime(nullable: false, precision: 0),
                        updatedDateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.m_person");
            DropTable("dbo.m_department");
        }
    }
}
