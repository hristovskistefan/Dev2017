﻿using MvcAjaxDemo.Data.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MvcAjaxDemo.Data.Context.EntityConfiguration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            // Sets Primary Key on table
            //HasKey(p => p.ProductId);

            //Property(p => p.Name)
            //     .IsRequired()
            //     .HasMaxLength(50);

            //Property(p => p.Description)
            //    .IsRequired()
            //    .HasMaxLength(500);

            //Property(p => p.Price)
            //    .IsRequired()
            //    .HasColumnType("double");

            //Property(p => p.Category)
            //   .IsRequired()
            //   .HasMaxLength(500);
            //;
        }
    }
}