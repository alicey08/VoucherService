using NZPost.VoucherService.EfRepositories;
using NZPost.VoucherService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.CreateDatabase
{
    public class DropAndSeedDatabaseInitialiser : IDatabaseInitializer<DatabaseUnitOfWork>
    {        
        void IDatabaseInitializer<DatabaseUnitOfWork>.InitializeDatabase(DatabaseUnitOfWork context)
        {
            DropAndCreateDatabase(context);          

            Seed(context);          

        }

        private void DropAndCreateDatabase(DatabaseUnitOfWork context)
        {
            if (context.Database.Exists())
            {
                string databaseName = context.Database.Connection.Database;
                context.Database.ExecuteSqlCommand("ALTER DATABASE " + databaseName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                Console.WriteLine("Database connection dropped");

                context.Database.Delete();
                Console.WriteLine("Database dropped");
            }

            context.Database.Create();
            Console.WriteLine("New database created.");
        }

        private void Seed(DatabaseUnitOfWork context)
        {            
            Organisation firstOrganisation = new Organisation() { Name = "NZ Post", APIKey = "kjfjettj" };
            context.Organisations.Add(firstOrganisation);
            context.SaveChanges();
            Console.WriteLine("Seeding is now done");
        }

    }
}
