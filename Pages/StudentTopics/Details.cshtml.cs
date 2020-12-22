using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentTopicWeb.Data;
using StudentTopicWeb.Models;

namespace StudentTopicWeb.Pages.StudentTopics
{
    public class DetailsModel : PageModel
    {
        private readonly StudentTopicWeb.Data.StudentTopicWebContext _context;

        public DetailsModel(StudentTopicWeb.Data.StudentTopicWebContext context)
        {
            _context = context;
        }

        public StudentTopic StudentTopic { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudentTopic = await _context.StudentTopic
                .Include(s => s.Topic).FirstOrDefaultAsync(m => m.UserId == id);

            if (StudentTopic == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
