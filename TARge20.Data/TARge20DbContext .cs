using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<CookID> CookIDs { get; set; }
        public DbSet<EatingHistory> EatingHistories { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<KitchenMenu> KitchenMenus { get; set; }
        public DbSet<PositionID> PositionIDs { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkerProffession> WorkerProffessions { get; set; }


    }
}