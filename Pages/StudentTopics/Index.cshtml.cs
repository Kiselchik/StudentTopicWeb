﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly StudentTopicWeb.Data.StudentTopicWebContext _context;

        public IndexModel(StudentTopicWeb.Data.StudentTopicWebContext context)
        {
            _context = context;
        }

        public IList<StudentTopic> StudentTopic { get;set; }

        public async Task OnGetAsync()
        {
            StudentTopic = await _context.StudentTopic
                .Include(s => s.Topic).ToListAsync();
        }
    }
}
