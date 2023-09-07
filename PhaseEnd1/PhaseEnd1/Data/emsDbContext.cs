using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMS_Full_App_Req.Models;

namespace PhaseEnd1.Data
{
    public class emsDbContext : DbContext
    {
        public emsDbContext (DbContextOptions<emsDbContext> options)
            : base(options)
        {
        }

        public DbSet<EMS_Full_App_Req.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<EMS_Full_App_Req.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
