namespace bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into CATEGORIES (id,name) values (1,'development')");
            Sql("insert into CATEGORIES (id,name) values (2,'business')");
            Sql("insert into CATEGORIES (id,name) values (3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
