using NZPost.VoucherService.EfRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.CreateDatabase
{
    class Program
    {        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting to create database.");
                Database.SetInitializer(new DropAndSeedDatabaseInitialiser());
                DatabaseUnitOfWork context = new DatabaseUnitOfWork("name=VoucherService");
                context.Database.Initialize(false);
                Console.WriteLine("done!");
                Console.WriteLine("(Press any key to close)");
                Console.Read();
            
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }

        }
    }
}
