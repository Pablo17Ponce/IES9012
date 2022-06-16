using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IES9012.UI.Data;
using IES9012.core.Modelos;

namespace IES9012.UI.Pages.Estudiantes
{
    public class CreateModel : PageModel
    {
        private readonly IES9012.UI.Data.IES9012Context _context;

        public CreateModel(IES9012.UI.Data.IES9012Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Estudiante Estudiante { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Estudiantes == null || Estudiante == null)
            {
                return Page();
            }

            _context.Estudiantes.Add(Estudiante);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
