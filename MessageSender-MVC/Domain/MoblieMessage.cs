namespace MessageSender_MVC.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MobileMessage : DomainEntity<int>
    {
        public string Message { get; private set; }

        public virtual MobileContact MobileContact { get; private set; }
    }
}
