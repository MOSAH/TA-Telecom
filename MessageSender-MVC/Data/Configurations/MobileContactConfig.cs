namespace MessageSender_MVC.Data.Configurations
{
    using MessageSender_MVC.Domain;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MobileContactConfig : IEntityTypeConfiguration<MobileContact>
    {
        public void Configure(EntityTypeBuilder<MobileContact> builder)
        {
            builder.HasKey(mc => mc.Id);

            builder.Property(mc => mc.MoblieNumber).HasMaxLength(30);
        }
    }
}
