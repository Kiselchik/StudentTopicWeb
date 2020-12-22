using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTopicWeb.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public int WorkId { get; set; }
        public string TopicName { get; set; }
        public bool Status { get; set; }

        public ICollection<StudentTopic> StudentTopics { get; set; }
        public Work Work { get; set; }
    }
}
