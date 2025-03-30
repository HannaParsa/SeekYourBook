using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeekBooks.Dto;
using SeekBooks.Service;

namespace SeekBooks.Pages
{
    public class IndexModel : PageModel
    {
        private readonly GoogleBooksService _googleBooksService;
        private const string GoogleApiKey = "AIzaSyBlR3-JhFcVB-HqUrnd2LDjeILJl_TqWD8";

        public IndexModel(GoogleBooksService googleBooksService)
        {
            _googleBooksService = googleBooksService;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        public GoogleBooksResponse Books { get; set; }

        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(SearchQuery))
            {
                Books = await _googleBooksService.SearchBooksAsync(SearchQuery, GoogleApiKey);
            }
        }

    }
}