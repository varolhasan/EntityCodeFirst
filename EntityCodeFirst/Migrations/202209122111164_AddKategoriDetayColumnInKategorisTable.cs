namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKategoriDetayColumnInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriDetay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategoris", "KategoriDetay");
        }
    }
}
