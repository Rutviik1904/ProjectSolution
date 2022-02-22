using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;

namespace Project.Data
{
    public class ApplicationDbContext
        :IdentityDbContext<MyIdentityUser, MyIdentityRole, Guid>
    {
        public DbSet<UserInfo> UserInfos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
