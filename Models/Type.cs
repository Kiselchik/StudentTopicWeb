using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTopicWeb.Models
{
    public class Type
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public ICollection<Work> Works { get; set; }
    }
}
