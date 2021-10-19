using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PC3_TEO.Data
{
    public class ProductoContext: IdentityDbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext> options)
            : base(options)
        {
        }
        public DbSet<PC3_TEO.Models.Producto> Productos {get;set;}
        
    }
}