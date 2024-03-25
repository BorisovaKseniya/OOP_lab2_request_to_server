namespace OOP_lab2_request_to_server
{
    abstract class BaseRequest
    {
        public string uri;

        public BaseRequest(string url)
        {
            uri = url;
        }


        virtual async public Task GET_3_requests() { }




    }
}
