using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YourPen.Domain.Core.Entities.Topics;

namespace YourPen.Infrastructure.Data.EntityConfigurations
{
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(topic => topic.Id);
            //builder.ToTable("Topics", "dbo");
        }
    }
}
