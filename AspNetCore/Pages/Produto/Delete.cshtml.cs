using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Entrevista.Data;
using Entrevista.Models;

namespace Entrevista.Pages.Produto
{
    public class DeleteModel : PageModel
    {
        private readonly Entrevista.Data.ApplicationDbContext _context;

        public DeleteModel(Entrevista.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Produtos Produtos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtos = await _context.Produtos.FirstOrDefaultAsync(m => m.ProdutoId == id);

            if (produtos == null)
            {
                return NotFound();
            }
            else
            {
                Produtos = produtos;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtos = await _context.Produtos.FindAsync(id);
            if (produtos != null)
            {
                Produtos = produtos;
                _context.Produtos.Remove(Produtos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
