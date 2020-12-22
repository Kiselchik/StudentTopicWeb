using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTopicWeb.Models
{
    public class Student: User
    {
        public int GroupId { get; set; }

        public Group Group { get; set; }
        public ICollection<StudentTopic> StudentTopics { get; set; }
    }
}
