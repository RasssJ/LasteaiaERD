using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class EatingHistory
    {
        [Key]
        public string Date { get; set; }
        public string Dish { get; set; }
        public string Portions { get; set; }

    }
}
