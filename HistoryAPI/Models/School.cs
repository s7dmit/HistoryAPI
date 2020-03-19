using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryAPI.Models
{
    public class School:BaseEntity
    {
        public School()
        {
            Classes = new List<Class>();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        [JsonIgnore]

        public virtual ICollection<Class> Classes { get; set; }

    }
}