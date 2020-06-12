namespace LIDER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCategory : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (Name,Hide,Ranking) VALUES ('T-Shirt',0,1)");
            Sql("INSERT INTO CATEGORIES (Name,Hide,Ranking) VALUES ('Shirt',0,2)");
            Sql("INSERT INTO CATEGORIES (Name,Hide,Ranking) VALUES ('Hoodie',0,3)");
            Sql("INSERT INTO CATEGORIES (Name,Hide,Ranking) VALUES ('Jacket',0,4)");
            Sql("INSERT INTO CATEGORIES (Name,Hide,Ranking) VALUES ('Pant',0,5)");
            Sql("INSERT INTO CATEGORIES (Name,Hide,Ranking) VALUES ('Shoes',0,6)");
            Sql("INSERT INTO CATEGORIES (Name,Hide,Ranking) VALUES ('Accessories',0,7)");
        }
        public override void Down()
        {
        }
    }
}
