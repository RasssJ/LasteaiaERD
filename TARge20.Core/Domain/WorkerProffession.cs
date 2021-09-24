using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class WorkerProffession
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
