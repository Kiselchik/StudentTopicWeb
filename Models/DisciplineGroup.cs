using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTopicWeb.Models
{
    public class DisciplineGroup
    {
        public int DisciplineId { get; set; }
        public int GroupId { get; set; }

        public ICollection<Work> Work { get; set; }
    }
}
