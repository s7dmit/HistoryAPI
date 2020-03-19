using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryAPI.Models
{
    public class Class:BaseEntity
    {
        public Class()

        {
            StudentsInClasses = new List<StudentInClass>();
        }

        public int Number { get; set; }

        public string Litera { get; set; }

        public int? SchoolId { get; set; }

        public School School { get; set; }

        public int? StudentInClassId { get; set; }

        [JsonIgnore]

        public virtual ICollection<StudentInClass> StudentsInClasses { get; set; }
    }
}