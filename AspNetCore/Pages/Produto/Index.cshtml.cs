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
    public class IndexModel : PageModel
    {
        private readonly Entrevista.Data.ApplicationDbContext _context;

        public IndexModel(Entrevista.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produtos> Produtos { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produtos.ToListAsync();
        }
    }
}
