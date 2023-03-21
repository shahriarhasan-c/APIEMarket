using API.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Model.DataConnection
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext>options):base(options){ } 
        DbSet<User> Users { get; set; }
        DbSet<Admin> Admins { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
    }
}
