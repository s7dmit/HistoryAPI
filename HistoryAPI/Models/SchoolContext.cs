using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HistoryAPI.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
    }

}