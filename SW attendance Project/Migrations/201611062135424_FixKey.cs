namespace SW_attendance_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attendances", "LectureId", "dbo.Lectures");
            DropPrimaryKey("dbo.Lectures");
            AlterColumn("dbo.Lectures", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Lectures", "Id");
            AddForeignKey("dbo.Attendances", "LectureId", "dbo.Lectures", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "LectureId", "dbo.Lectures");
            DropPrimaryKey("dbo.Lectures");
            AlterColumn("dbo.Lectures", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Lectures", "Id");
            AddForeignKey("dbo.Attendances", "LectureId", "dbo.Lectures", "Id", cascadeDelete: true);
        }
    }
}
