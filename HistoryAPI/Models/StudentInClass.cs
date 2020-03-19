using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryAPI.Models
{
    public class StudentInClass:BaseEntity
    {
        public bool relevance { get; set; }

        public DateTime StartDate { get; set; }
        
        public DateTime EndingDate { get; set; }

        public Class Class { get; set; }

        public Student Student{ get; set; }

        public int? StudentId { get; set; }

        public int? ClassId { get; set; }

    }
}