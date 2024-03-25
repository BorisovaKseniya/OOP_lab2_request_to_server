
namespace OOP_lab2_request_to_server
{
    class AsyncRequest : BaseRequest
    {
        public AsyncRequest(string url) : base(url) { }
        public async Task GETrequest()
        {
            using (var Httpclient = new HttpClient())
            {
                try
                {
                    var result = await Httpclient.GetAsync(uri);
                    var json = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
