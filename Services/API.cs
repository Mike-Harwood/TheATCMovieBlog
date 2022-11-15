using Newtonsoft.Json;
using TheATCMovieBlog.MovieDTO;

namespace TheATCMovieBlog.Services
{
    public class API : IAPI
    {

        public async Task<Root> MovieAPI(string Id)
        {
            Root root;





            string apiKey = "fa1c9ffde1a15a88733a757e677e85ab";
            string URL = "https://api.themoviedb.org/3/movie/" + Id + "?api_key=" + apiKey;
            try
            {
                HttpClient client = new HttpClient();
                string responseBody = null;




                responseBody = await client.GetStringAsync(URL);
                root = JsonConvert.DeserializeObject<Root>(responseBody);
            }

            catch (Exception ex)
            {
                root = null;


            }



            return root;



        }


        //public async Task<ApiMovie> MovieAPI()
        //{
        //    HttpClient client = new HttpClient();
        //    string responseBody = null;
        //    string apiKey = "fa1c9ffde1a15a88733a757e677e85ab";
        //    string URL =
        //   "https://api.themoviedb.org/3/movie/550?api_key=fa1c9ffde1a15a88733a757e677e85ab";
        //    responseBody = await client.GetStringAsync(URL);
        //    ApiMovie root = JsonConvert.DeserializeObject<ApiMovie>(responseBody);
        //    return root;
        //}


    }
}
