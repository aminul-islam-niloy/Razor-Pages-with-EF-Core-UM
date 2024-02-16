using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EF_with_Razor.Data;
using EF_with_Razor.Models;

namespace EF_with_Razor.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly EF_with_Razor.Data.ApplicationDbContext _context;

        public DetailsModel(EF_with_Razor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

         Student = await _context.Students
        .Include(s => s.Enrollments)
        .ThenInclude(e => e.Course)
        .AsNoTracking()
        .FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            else 
            {
                Student = Student;
            }
            return Page();
        }
    }
}
