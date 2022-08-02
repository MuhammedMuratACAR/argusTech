using argusTech.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace argusTech.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Name).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Surname).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Email).HasMaxLength(150);
            builder.Property(I => I.PhoneNumber).HasMaxLength(20);
            builder.Property(I => I.Gender).HasMaxLength(1);
        }
    }
}
