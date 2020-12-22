using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentTopicWeb.Data;
using StudentTopicWeb.Models;

namespace StudentTopicWeb.Pages.DisciplineGroups
{
    public class DetailsModel : PageModel
    {
        private readonly StudentTopicWeb.Data.StudentTopicWebContext _context;

        public DetailsModel(StudentTopicWeb.Data.StudentTopicWebContext context)
        {
            _context = context;
        }

        public DisciplineGroup DisciplineGroup { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DisciplineGroup = await _context.DisciplineGroup.FirstOrDefaultAsync(m => m.DisciplineId == id);

            if (DisciplineGroup == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
