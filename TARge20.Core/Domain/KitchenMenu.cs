using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class KitchenMenu
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public string Dish { get; set; }
        public string Amount { get; set; }
        public string ToGroup { get; set; }
    }
}
