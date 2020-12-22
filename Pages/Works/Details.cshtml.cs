using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentTopicWeb.Data;
using StudentTopicWeb.Models;

namespace StudentTopicWeb.Pages.Works
{
    public class DetailsModel : PageModel
    {
        private readonly StudentTopicWeb.Data.StudentTopicWebContext _context;

        public DetailsModel(StudentTopicWeb.Data.StudentTopicWebContext context)
        {
            _context = context;
        }

        public Work Work { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Work = await _context.Work
                .Include(w => w.Type).FirstOrDefaultAsync(m => m.WorkId == id);

            if (Work == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
