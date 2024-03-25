using System.Diagnostics;


namespace OOP_lab2_request_to_server
{
    class SyncRequest : BaseRequest
    {
        public SyncRequest(string url) : base(url) { }
        Stopwatch ssw = Stopwatch.StartNew();
        public void GETrequest()
        {
            using (var Httpclient = new HttpClient())
            {
                try
                {
                    var result = Httpclient.GetAsync(uri).Result;
                    var json = result.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }

    }
}



