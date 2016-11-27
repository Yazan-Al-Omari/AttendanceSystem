namespace SW_attendance_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Absents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbsentNotifications",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Percentage = c.Int(nullable: false),
                        IsSent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentId, t.CourseId, t.Percentage })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AbsentNotifications", "StudentId", "dbo.Students");
            DropForeignKey("dbo.AbsentNotifications", "CourseId", "dbo.Courses");
            DropIndex("dbo.AbsentNotifications", new[] { "CourseId" });
            DropIndex("dbo.AbsentNotifications", new[] { "StudentId" });
            DropTable("dbo.AbsentNotifications");
        }
    }
}
