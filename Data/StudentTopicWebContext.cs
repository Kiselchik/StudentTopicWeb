using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentTopicWeb.Models;

namespace StudentTopicWeb.Data
{
    public class StudentTopicWebContext : DbContext
    {
        public StudentTopicWebContext (DbContextOptions<StudentTopicWebContext> options)
            : base(options)
        {
        }

        public DbSet<StudentTopicWeb.Models.Topic> Topic { get; set; }

        public DbSet<StudentTopicWeb.Models.Discipline> Discipline { get; set; }

        public DbSet<StudentTopicWeb.Models.Group> Group { get; set; }

        public DbSet<StudentTopicWeb.Models.Type> Type { get; set; }

        public DbSet<StudentTopicWeb.Models.Teacher> Teacher { get; set; }

        public DbSet<StudentTopicWeb.Models.Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentTopic>()
                .HasKey(c => new { c.UserId, c.TopicId });
           modelBuilder.Entity<DisciplineGroup>()
               .HasKey(c => new { c.DisciplineId, c.GroupId });





        }

        public DbSet<StudentTopicWeb.Models.StudentTopic> StudentTopic { get; set; }

        public DbSet<StudentTopicWeb.Models.Work> Work { get; set; }

        public DbSet<StudentTopicWeb.Models.DisciplineGroup> DisciplineGroup { get; set; }
    }
}
