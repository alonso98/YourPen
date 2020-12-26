using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using YourPen.Domain.Core.Entities.Entries;
using YourPen.Domain.Core.Entities.Topics;
using YourPen.Domain.Core.Entities.Users;
using YourPen.Infrastructure.Data.EntityConfigurations;

namespace YourPen.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Entry> Entries { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new TopicConfiguration());
            //modelBuilder.ApplyConfiguration(new EntryConfiguration());
        }
    }
}
