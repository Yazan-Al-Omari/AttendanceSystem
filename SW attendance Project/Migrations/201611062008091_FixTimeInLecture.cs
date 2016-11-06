namespace SW_attendance_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTimeInLecture : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lectures", "StartTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lectures", "StartTime", c => c.Time(nullable: false, precision: 7));
        }
    }
}
