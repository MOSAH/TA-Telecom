namespace MessageSender_MVC.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public abstract class DomainEntity<TId>  
    {
        public TId Id { get; protected set; }
    }
}
