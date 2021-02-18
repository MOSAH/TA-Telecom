namespace MessageSender_MVC.Data
{
    using MessageSender_MVC.Domain;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public partial class MessageSenderDbContext : DbContext
    {
        public MessageSenderDbContext(DbContextOptions<MessageSenderDbContext> options)
            : base(options){}

        public DbSet<MobileContact> MobileContacts { get; private set; }

        public DbSet<MobileMessage> MoblieMessages { get; private set; }
    }
}
