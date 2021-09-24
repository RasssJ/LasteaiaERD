using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Worker
    {
        [Key]
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Worker> Workers_ID { get; set; }
        public ICollection<WorkerProffession> WorkerProffession_ID { get; set; }
        public ICollection<Absence> Absence_ID { get; set; }
        public ICollection<KitchenMenu> KitchenMenu_ID { get; set; }
        public ICollection<Child> Children_ID { get; set; }
        public ICollection<Vacation> Vacations_ID { get; set; }
        public ICollection<PositionID> Position_IDs { get; set; }
        public ICollection<CookID> Cook_IDs { get; set; }
        public ICollection<EatingHistory> EatingHistory_ID { get; set; }
        public ICollection<Group> Group_ID { get; set; }
    }
}
