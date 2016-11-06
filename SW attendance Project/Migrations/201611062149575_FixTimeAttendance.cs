namespace SW_attendance_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTimeAttendance : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Attendances", "Time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Attendances", "Time", c => c.Time(nullable: false, precision: 7));
        }
    }
}
