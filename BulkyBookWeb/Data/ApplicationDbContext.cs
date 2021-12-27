using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        //Setup to configure DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
        }

        //Create a database Model here - This is the table name that will be created in the database
        //Here table name is Category
        public DbSet<Category> Categories { get; set; }
    }
}
