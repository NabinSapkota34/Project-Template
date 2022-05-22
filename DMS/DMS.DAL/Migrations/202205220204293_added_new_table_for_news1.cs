namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_new_table_for_news1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table editor(
                  e_id int primary key,
                  e_name varchar(20),
                  e_address varchar(20),
                  e_phonenumber int
)");
        }
        
        public override void Down()
        {
        }
    }
}
