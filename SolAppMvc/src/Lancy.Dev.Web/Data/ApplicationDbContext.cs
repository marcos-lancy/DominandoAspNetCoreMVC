using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lancy.Dev.Web.ViewModels;

namespace Lancy.Dev.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Lancy.Dev.Web.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
    }
}
