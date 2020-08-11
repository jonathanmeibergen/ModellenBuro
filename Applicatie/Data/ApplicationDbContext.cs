using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModellenBuro.Models;

namespace ModellenBuro.Data
{
    public class ApplicationDbContext : IdentityDbContext<PhotoModel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhotoModel> FotoModel { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }


    public class IdentityDbContext<TUser> : IdentityDbContext<TUser, IdentityRole, string>
        where TUser : IdentityUser
    {
        public IdentityDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
        }
    }

}
