namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_new_table : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table test(
                   id int primary key identity(1,1),
                   name varchar(255) not null,
                   address nvarchar(255) not null)   
");
        }
        
        public override void Down()
        {
        }
    }
}
