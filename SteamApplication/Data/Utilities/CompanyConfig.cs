using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SteamApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Data.Utilities
{
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(90).HasColumnName("Company").IsRequired();
            builder.HasMany(x => x.Game).WithOne(g => g.Company).HasForeignKey(g => g.CompanyId);
            builder.HasOne(x => x.Country).WithMany(x => x.Company).HasForeignKey(x => x.CountryId);
        }
    }
}
