using Newtonsoft.Json;
using SeekBooks.Dto;

namespace SeekBooks.Service
{

    public class GoogleBooksService
    {
        private readonly HttpClient _httpClient;

        public GoogleBooksService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Call Google Books API
        public async Task<GoogleBooksResponse> SearchBooksAsync(string query, string apiKey)
        {
            var url = $"https://www.googleapis.com/books/v1/volumes?q={query}&key={apiKey}";
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<GoogleBooksResponse>(response);
        }
    }
}
