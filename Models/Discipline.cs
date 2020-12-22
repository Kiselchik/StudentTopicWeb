using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTopicWeb.Models
{
    public class Discipline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DisciplineId { get; set; }
        public string DiscName { get; set; }

        public int UserId { get; set; }

       public ICollection<Teacher> Teacher { get; set; }
       public ICollection<DisciplineGroup> DisciplineGroup { get; set; }
    }
}
