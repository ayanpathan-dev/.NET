using Day10_EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_EntityFrameWork.DAL
{
    public class DBContext : DbContext
    {
        public DbSet<Emp> emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Service to read config file.
            // A service to read appsettings.json file
            var builder = new ConfigurationBuilder();

            //string dirPath = Directory.GetCurrentDirectory();//// Path =" /bin/debug/net8.0" 
            builder.SetBasePath(Directory.GetCurrentDirectory());

            // Add the JSON file to the configuration and copy appsettings.json file to the output directory
            builder.AddJsonFile("appsettings.json");

            // Build the configuration
            IConfiguration config = builder.Build();

            // // Read the config file
            //string connectionString = config.GetConnectionString("IETDb");

            optionsBuilder.UseSqlServer(config.GetConnectionString("IETDb"));
        }
    }
}
