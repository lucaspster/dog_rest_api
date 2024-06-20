using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Entrevista.Data;
using Entrevista.Models;

namespace Entrevista.Pages.Produto
{
    public class CreateModel : PageModel
    {
        private readonly Entrevista.Data.ApplicationDbContext _context;

        public CreateModel(Entrevista.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Produtos Produtos { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produtos.Add(Produtos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
