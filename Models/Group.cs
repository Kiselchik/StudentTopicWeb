using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTopicWeb.Models
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupId { get; set; }
        public string GroupNumb { get; set; }

       public ICollection<Student> Students { get; set; }
       public ICollection<DisciplineGroup> DisciplineGroup { get; set; }
    }
}
