using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTopicWeb.Models
{
    public class StudentTopic
    {
        public int UserId { get; set; }

        public int TopicId { get; set; }

        public Student Student { get; set; }
        public Topic Topic { get; set; }
    }
}
