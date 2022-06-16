using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IES9012.UI.Data;
using IES9012.core.Modelos;

namespace IES9012.UI.Pages.Estudiantes
{
    public class DeleteModel : PageModel
    {
        private readonly IES9012.UI.Data.IES9012Context _context;

        public DeleteModel(IES9012.UI.Data.IES9012Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Estudiante Estudiante { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Estudiantes == null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiantes.FirstOrDefaultAsync(m => m.EstudianteId == id);

            if (estudiante == null)
            {
                return NotFound();
            }
            else 
            {
                Estudiante = estudiante;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Estudiantes == null)
            {
                return NotFound();
            }
            var estudiante = await _context.Estudiantes.FindAsync(id);

            if (estudiante != null)
            {
                Estudiante = estudiante;
                _context.Estudiantes.Remove(Estudiante);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
