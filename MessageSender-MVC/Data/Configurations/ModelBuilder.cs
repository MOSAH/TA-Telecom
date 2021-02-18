namespace MessageSender_MVC.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public partial class MessageSenderDbContext: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.MobileContactConfig())
                .ApplyConfiguration(new Configurations.MobileMessageConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
