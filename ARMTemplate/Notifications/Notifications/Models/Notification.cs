using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifications.Models
{
    public class Notification
    {
        public string Category { get; set; }
        public string City { get; set; }
        public string Subcategory { get; set; }
        public string District { get; set; }
        public string AparmentNumber { get; set; }
        public string Street2 { get; set; }
        public string NotificationType { get; set; }
        public long CreateDate { get; set; }
        public string SiebelEventId { get; set; }
        public string Source { get; set; }
        public float YCoordOracle { get; set; }
        public string Street { get; set; }
        public string DeviceType { get; set; }
        public object[] Statuses { get; set; }
        public float XCoordOracle { get; set; }
        public string NotificationNumber { get; set; }
        public int YCoordWGS84 { get; set; }
        public string Event { get; set; }
    }
}