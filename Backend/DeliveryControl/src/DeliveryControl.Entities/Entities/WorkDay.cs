using System;   
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using DeliveryControl.Entities.Notifications;

namespace DeliveryControl.Entities.Entities
{
    [Table("WorkDays")]
    public class WorkDay : Base
    {
        public DateTime Date { get; set; }
        public decimal InitialMileage { get; set; }
        public decimal FinalMileage { get; set; }
        public decimal TotalMileage { get; set; }
    }
}