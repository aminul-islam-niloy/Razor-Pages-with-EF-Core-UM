using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EF_with_Razor.Data;
using EF_with_Razor.Models;

namespace EF_with_Razor.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly EF_with_Razor.Data.ApplicationDbContext _context;

        public IndexModel(EF_with_Razor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Courses != null)
            {
                Course = await _context.Courses.ToListAsync();
            }
        }
    }
}
