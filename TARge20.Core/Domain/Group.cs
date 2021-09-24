using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
        public class Group
        {
            [Key]
            public Guid ID { get; set; }
            public string GroupType { get; set; }
            public string NumberOfPeople { get; set; }
        }

}
