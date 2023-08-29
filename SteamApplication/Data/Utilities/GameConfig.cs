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
    public class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Company).WithMany(x => x.Game).HasForeignKey(x => x.CompanyId);
            builder.HasOne(x => x.Category).WithMany(x => x.Games).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Platform).WithMany(x => x.Games).HasForeignKey(x => x.PlatformId);
        }
    }
}
