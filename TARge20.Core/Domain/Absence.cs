using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Absence
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime Reason { get; set; }
    }
}
