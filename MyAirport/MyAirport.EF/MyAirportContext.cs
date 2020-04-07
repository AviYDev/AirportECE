using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Extensions.Logging;

namespace IA.MyAirport.EF
{
    public class MyAirportContext : DbContext
    {
        public DbSet<Bagage>? Bagages { get; set; }
        public DbSet<Vol>? Vols { get; set; }

        public MyAirportContext(DbContextOptions<MyAirportContext> options) : base(options)
        { }

        public static readonly ILoggerFactory MyAirportLoggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyAirport;Trusted_Connection=True;");
////            optionsBuilder.UseLoggerFactory(MyAirportLoggerFactory);

//        }


    }
}
