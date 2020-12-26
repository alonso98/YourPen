using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;
using YourPen.Domain.Core.Entities.Entries;

namespace YourPen.Infrastructure.Data.EntityConfigurations
{
    public class EntryConfiguration : IEntityTypeConfiguration<Entry>
    {
        public void Configure(EntityTypeBuilder<Entry> builder)
        {
            builder.HasKey(m => m.Id);

            //builder.Property(m => m.Links)
            //       .HasField("links")
            //       .UsePropertyAccessMode(PropertyAccessMode.Field);

            builder.Property(m => m.Type)
                   //.HasColumnName("Type")
                   .HasConversion(new EnumToNumberConverter<EntryTypes, byte>());

            //builder.ToTable("Entries", "dbo");
        }
    }
}
