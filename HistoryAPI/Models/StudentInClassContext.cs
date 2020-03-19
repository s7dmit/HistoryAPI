using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HistoryAPI.Models
{
    public class StudentInClassContext : DbContext
    {
        public DbSet<StudentInClass> StudentsInClasses { get; set; }

        public System.Data.Entity.DbSet<HistoryAPI.Models.Class> Classes { get; set; }

        public System.Data.Entity.DbSet<HistoryAPI.Models.Student> Students { get; set; }
    }
}