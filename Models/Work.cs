using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTopicWeb.Models
{
    public class Work
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MaxStudents { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool StudentTopicAllow { get; set; }
        public int MaxTopics { get; set; }
        public int TypeId { get; set; }

        public int DisciplineId { get; set; }
        public int GroupId { get; set; }

        public DisciplineGroup DisciplineGroup { get; set; }
        public Models.Type Type { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}
