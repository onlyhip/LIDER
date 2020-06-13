namespace LIDER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedProduct : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('T-Shirt 1',600000,'/Content/Images/T-Shirt/1.jpg',0,1,2)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('T-Shirt 2',600000,'/Content/Images/T-Shirt/2.jpg',0,1,2)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('T-Shirt 3',600000,'/Content/Images/T-Shirt/3.jpg',0,1,2)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('T-Shirt 4',600000,'/Content/Images/T-Shirt/4.jpg',0,1,2)");
         
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Shirt 1',900000,'/Content/Images/Shirt/5.jpg',0,2,3)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Shirt 2',900000,'/Content/Images/Shirt/6.jpg',0,2,3)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Shirt 3',900000,'/Content/Images/Shirt/7.jpg',0,2,3)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Shirt 4',900000,'/Content/Images/Shirt/8.jpg',0,2,3)");

            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Hoodie 1',1000000,'/Content/Images/Hoodie/17.jpg',0,3,4)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Hoodie 2',1000000,'/Content/Images/Hoodie/18.jpg',0,3,4)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Hoodie 3',1000000,'/Content/Images/Hoodie/19.jpg',0,3,4)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Hoodie 4',1000000,'/Content/Images/Hoodie/20.jpg',0,3,4)");

            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Jacket 1',1200000,'/Content/Images/Jacket/9.jpg',0,4,5)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Jacket 2',1200000,'/Content/Images/Jacket/10.jpg',0,4,5)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Jacket 3',1200000,'/Content/Images/Jacket/11.jpg',0,4,5)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Jacket 4',1200000,'/Content/Images/Jacket/12.jpg',0,4,5)");

            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Pant 1',1100000,'/Content/Images/Pant/13.jpg',0,5,6)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Pant 2',1100000,'/Content/Images/Pant/14.jpg',0,5,6)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Pant 3',1100000,'/Content/Images/Pant/15.jpg',0,5,6)");
            Sql("INSERT INTO PRODUCTS (Name,Price,Img,Hide,Ranking,CategoryID) VALUES ('Pant 4',1100000,'/Content/Images/Pant/16.jpg',0,5,6)");
        }
        
        public override void Down()
        {
        }
    }
}
