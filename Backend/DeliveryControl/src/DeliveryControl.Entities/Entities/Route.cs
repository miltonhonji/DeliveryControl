using System;   
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;
using DeliveryControl.Entities.Notifications;

namespace DeliveryControl.Entities.Entities
{
    [Table("Route")]
    public class Route : Base
    {        
        [ForeignKey("WorkDay")]
        [Column(Order = 1)]
        public int WorkDayId { get; set; }
        public int EstimatedDuration { get; set;}
        public decimal CompensationAmount { get; set; }
        public int TotalPackages { get; set; }
        public int SuccessfulDeliveries { get; set; }
        public int UnsuccessfulDeliveries { get; set; }
        public int NumbersOfStops { get; set; }
        [JsonIgnore]
        public virtual WorkDay? WorkDay { get; set; }
    }
}