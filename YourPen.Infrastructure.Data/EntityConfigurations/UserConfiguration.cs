using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;
using YourPen.Domain.Core.Entities.Entries;
using YourPen.Domain.Core.Entities.Users;

namespace YourPen.Infrastructure.Data.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(m => m.Id);

            builder.OwnsOne<Email>("Email", m => m.Property(p => p.EmailAddress));

            builder.Property(m => m.Role)
                   //.HasColumnName("Role")
                   .HasConversion(new EnumToNumberConverter<Roles, byte>());

            //builder.ToTable("Users", "dbo");
        }
    }
}
