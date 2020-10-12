using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using housing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace housing.Pages
{
    public class IndexModel : PageModel
    {
        private dataContext _context { get; set; }
        public IndexModel(dataContext context)
        {
            _context = context;
        }
        public List<data> datas { get; set; }

        public async Task OnGet()
        {
            datas = await _context.Datas.ToListAsync();
        }
    }
}
