using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageSender_MVC.Domain
{
    public class MobileContact : DomainEntity<int>
    {
        public string MoblieNumber { get; private set; }
    }
}
