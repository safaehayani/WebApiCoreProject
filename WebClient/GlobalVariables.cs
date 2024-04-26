using System.Net.Http.Headers;

namespace WebClient
{
    public class GlobalVariables
    {
        public static HttpClient WebApiClient=new HttpClient();
        public GlobalVariables()
        {
            //WebApiClient.BaseAddress = new Uri("https://localhost:7002/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
