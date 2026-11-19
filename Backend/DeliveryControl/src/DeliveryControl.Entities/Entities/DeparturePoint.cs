using System;   
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;
using DeliveryControl.Entities.Notifications;

namespace DeliveryControl.Entities.Entities
{
    [Table("DeparturePoint")]
    public class DeparturePoint : Base
    {
        public string Name { get; set; }
        public bool Active { get; set; }

        [ForeignKey("Address")]
        [Column(Order = 1)]
        public int AddressId { get; set; }
        
        [JsonIgnore]
        public virtual Address? Address { get; set;}
    }
}