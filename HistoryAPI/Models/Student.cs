using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryAPI.Models
{
    public class Student:BaseEntity
    {
        public Student()
        {
            StudentsInClasses = new List<StudentInClass>();
        }

        public string Firstname { get; set; }

        public string Secondname { get; set; }

        public string Thirdname { get; set; }

        public DateTime BirthDay { get; set; }

        public string Address { get; set; }


        [JsonIgnore]
        public virtual ICollection<StudentInClass> StudentsInClasses { get; set; }
    }
}