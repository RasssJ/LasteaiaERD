using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class PositionID
    {
        [Key]
        public string PositionType { get; set; }
        public string PositionName { get; set; }

    }
}
