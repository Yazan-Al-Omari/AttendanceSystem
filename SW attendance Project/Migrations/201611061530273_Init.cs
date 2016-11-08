namespace SW_attendance_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        LectureId = c.Int(nullable: false),
                        Time = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => new { t.StudentId, t.LectureId })
                .ForeignKey("dbo.Lectures", t => t.LectureId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.LectureId);
            
            CreateTable(
                "dbo.Lectures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.Time(nullable: false, precision: 7),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        InstructorId = c.Int(nullable: false),
                        Location = c.String(nullable: false, maxLength: 50),
                        TimeInDay = c.Double(nullable: false),
                        Duration = c.Short(nullable: false),
                        StartDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructors", t => t.InstructorId)
                .Index(t => t.InstructorId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 16),
                        UserType = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Number = c.String(nullable: false, maxLength: 11, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Id", "dbo.Users");
            DropForeignKey("dbo.Instructors", "Id", "dbo.Users");
            DropForeignKey("dbo.Attendances", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Lectures", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.Attendances", "LectureId", "dbo.Lectures");
            DropIndex("dbo.Students", new[] { "Id" });
            DropIndex("dbo.Instructors", new[] { "Id" });
            DropIndex("dbo.Courses", new[] { "InstructorId" });
            DropIndex("dbo.Lectures", new[] { "CourseId" });
            DropIndex("dbo.Attendances", new[] { "LectureId" });
            DropIndex("dbo.Attendances", new[] { "StudentId" });
            DropTable("dbo.Students");
            DropTable("dbo.Instructors");
            DropTable("dbo.Users");
            DropTable("dbo.Courses");
            DropTable("dbo.Lectures");
            DropTable("dbo.Attendances");
        }
    }
}
