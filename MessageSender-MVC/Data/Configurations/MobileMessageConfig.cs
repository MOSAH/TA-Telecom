namespace MessageSender_MVC.Data.Configurations
{
    using MessageSender_MVC.Domain;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MobileMessageConfig : IEntityTypeConfiguration<MobileMessage>
    {
        public void Configure(EntityTypeBuilder<MobileMessage> builder)
        {
            builder.HasKey(mm => mm.Id);

            builder.Property(mm => mm.Message).HasMaxLength(100);

            builder.HasOne(mm => mm.MobileContact);
        }
    }
}
