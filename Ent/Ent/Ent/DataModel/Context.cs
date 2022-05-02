﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.DataModel
{
    public class Context: DbContext
    {
       public DbSet<Student> Students { get; set; }   
        public DbSet<Class> Class { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=myDataBase;Trusted_Connection=True;");
       
        
        
        }
    }
}
