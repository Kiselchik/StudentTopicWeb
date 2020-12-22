using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentTopicWeb.Data;
using StudentTopicWeb.Models;

namespace StudentTopicWeb.Pages.DisciplineGroups
{
    public class EditModel : PageModel
    {
        private readonly StudentTopicWeb.Data.StudentTopicWebContext _context;

        public EditModel(StudentTopicWeb.Data.StudentTopicWebContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DisciplineGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DisciplineGroupExists(DisciplineGroup.DisciplineId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DisciplineGroupExists(int id)
        {
            return _context.DisciplineGroup.Any(e => e.DisciplineId == id);
        }
    }
}
