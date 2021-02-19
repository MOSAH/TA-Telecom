using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MessageSender_MVC.Domain
{
    public class MobileContact : DomainEntity<int>
    {
        public string MoblieNumber { get; private set; }


        public static MobileContact New()
        {
            return new MobileContact();
        }
        
        public static List<MobileContact> NewList()
        {
            return new List<MobileContact>();
        }
        
        public MobileContact Update(int id, string mobileNumber)
        {
            Id = id;
            MoblieNumber = mobileNumber;
            return this;
        }

        public static List<MobileContact> SeedMobileNumbers()
        {
            var file = @"D:\Tasks\TA-Telecom\MessageSender-MVC\MobileNumbers.txt";

            if (File.Exists(file))
            {
                var contacts = NewList();
                
                var lines = File.ReadAllLines(file);

                var id = 0;

                foreach (var line in lines)
                {
                    id++;
                    var contact = New().Update(id, line);
                    contacts.Add(contact);
                }
                return contacts;
            }
            return NewList();
        }
    }
}
