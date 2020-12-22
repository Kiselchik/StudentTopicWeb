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

namespace StudentTopicWeb.Pages.StudentTopics
{
    public class EditModel : PageModel
    {
        private readonly StudentTopicWeb.Data.StudentTopicWebContext _context;

        public EditModel(StudentTopicWeb.Data.StudentTopicWebContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["TopicId"] = new SelectList(_context.Topic, "TopicId", "TopicId");
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

            _context.Attach(StudentTopic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentTopicExists(StudentTopic.UserId))
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

        private bool StudentTopicExists(int id)
        {
            return _context.StudentTopic.Any(e => e.UserId == id);
        }
    }
}
