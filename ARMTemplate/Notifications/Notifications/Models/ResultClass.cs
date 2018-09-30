using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications.Models
{
    public class ResultClass
    {
        public Notification[] Notifications { get; set; }
        public string ResponseDesc { get; set; }
        public string ResponseCode { get; set; }
    }
}
