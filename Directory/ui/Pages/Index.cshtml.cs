using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data;
using domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ui.Models;

namespace ui.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Search SearchTerm { get; set; }

        private readonly IDirectoryData _data;

        public List<Business> Businesses { get; set; }

        public IndexModel(IDirectoryData directoryData)
        {
            _data = directoryData;
            SearchTerm = new Search();
        }
        public async Task OnGetAsync()
        {
            Businesses = _data.GetBusinesses().ToList();
        }

        public async Task OnPostAsync()
        {
            if (!string.IsNullOrWhiteSpace(SearchTerm.SearchTerm))
                Businesses = _data.FindBusinesses(SearchTerm.SearchTerm).ToList();
        }
    }
}
