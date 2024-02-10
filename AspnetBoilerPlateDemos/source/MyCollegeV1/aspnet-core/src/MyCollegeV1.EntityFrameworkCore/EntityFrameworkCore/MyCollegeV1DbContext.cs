using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyCollegeV1.Authorization.Roles;
using MyCollegeV1.Authorization.Users;
using MyCollegeV1.MultiTenancy;
using MyCollegeV1.Models;

namespace MyCollegeV1.EntityFrameworkCore
{
    public class MyCollegeV1DbContext : AbpZeroDbContext<Tenant, Role, User, MyCollegeV1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyCollegeV1DbContext(DbContextOptions<MyCollegeV1DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Abp.Localization.ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }

        public virtual DbSet<Student> Students { get; set; }
    }
}
