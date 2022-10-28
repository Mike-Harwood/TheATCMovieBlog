using Newtonsoft.Json;
using static TheATCMovieBlog.DTO.MovieDTO;

namespace TheATCMovieBlog.Services
{
    public class API : IAPI
    {
        public async Task<Root> MovieAPI()
        {
            HttpClient client = new HttpClient();
            string responseBody = null;
            string apiKey = "fa1c9ffde1a15a88733a757e677e85ab";
            string URL =
           "https://api.themoviedb.org/3/movie/550?api_key=fa1c9ffde1a15a88733a757e677e85ab" + apiKey;
            responseBody = await client.GetStringAsync(URL);
            Root root = JsonConvert.DeserializeObject<Root>(responseBody);
            return root;
        }


    }
}
