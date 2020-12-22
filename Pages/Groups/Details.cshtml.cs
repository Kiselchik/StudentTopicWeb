using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentTopicWeb.Data;
using StudentTopicWeb.Models;

namespace StudentTopicWeb.Pages.Groups
{
    public class DetailsModel : PageModel
    {
        private readonly StudentTopicWeb.Data.StudentTopicWebContext _context;

        public DetailsModel(StudentTopicWeb.Data.StudentTopicWebContext context)
        {
            _context = context;
        }

        public Group Group { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Group = await _context.Group.FirstOrDefaultAsync(m => m.GroupId == id);

            if (Group == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
