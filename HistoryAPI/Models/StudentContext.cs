﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HistoryAPI.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

}