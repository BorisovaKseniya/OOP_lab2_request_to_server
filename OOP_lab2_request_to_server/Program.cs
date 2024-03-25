using OOP_lab2_request_to_server;
using System.Diagnostics;



class OOP_lab2
{
    static async Task Main(String[] args)
    {
        Console.WriteLine("Какие запросы хотите?");
        Console.WriteLine(" 1 - синхронные");
        Console.WriteLine(" 2 - ассинхронные");
        int m;
        m = Convert.ToInt32(Console.ReadLine());
        switch (m)
        {
            case 1:
                {
                    Stopwatch ssw = new Stopwatch();
                    ssw.Start();
                    SyncRequest sync1 = new SyncRequest("https://dummyjson.com/products");
                    SyncRequest sync2 = new SyncRequest("https://dummyjson.com/products/1");
                    SyncRequest sync3 = new SyncRequest("https://dummyjson.com/products/2");

                    sync1.GETrequest();
                    sync2.GETrequest();
                    sync3.GETrequest();
                    ssw.Stop();
                    Console.WriteLine(ssw.ElapsedMilliseconds);
                    break;
                }
            case 2:
                {


                    Stopwatch asw = Stopwatch.StartNew();
                    asw.Start();
                    AsyncRequest async1 = new AsyncRequest("https://dummyjson.com/products");
                    AsyncRequest async2 = new AsyncRequest("https://dummyjson.com/products");
                    AsyncRequest async3 = new AsyncRequest("https://dummyjson.com/products");


                    var task = new List<Task> { async1.GETrequest(), async2.GETrequest(), async3.GETrequest() };
                    await Task.WhenAll(task);
                    asw.Stop();
                    Console.WriteLine(asw.ElapsedMilliseconds);
                    break;
                }
        }









    }
}
