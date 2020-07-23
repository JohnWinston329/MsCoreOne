﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MsCoreOne.Domain.Entities;

namespace MsCoreOne.Infrastructure.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(t => t.Name)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}
