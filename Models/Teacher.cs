using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTopicWeb.Models
{
    public class Teacher: User
    {
        public string Phone { get; set; }
        public ICollection<Discipline> Disciplines { get; set; }
    }
}
