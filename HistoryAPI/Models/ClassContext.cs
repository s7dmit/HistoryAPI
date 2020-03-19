using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HistoryAPI.Models
{
    public class ClassContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }

        public System.Data.Entity.DbSet<HistoryAPI.Models.School> Schools { get; set; }
    }

}