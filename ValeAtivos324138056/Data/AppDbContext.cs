using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ValeAtivos324138056.Models;

namespace ValeAtivos324138056.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options){}
        public DbSet<Equipamentos> Equipamentos{get; set;} 
    }
}