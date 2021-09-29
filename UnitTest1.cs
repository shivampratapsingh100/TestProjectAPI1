using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using RestSharp;

namespace TestProjectAPI1
{   [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new RestClient("https://reqres.in/api/users/4");
            var request = new RestRequest("posts/{postid}", Method.GET);
            request.AddUrlSegment("first_name", "Eve");
            request.AddUrlSegment("last_name", "Holt");
            var content = client.Execute(request).Content;

        }
        public static void TestMethod2()
        {
            var client = new RestClient("https://reqres.in/api/users/6");
            var request = new RestRequest("posts/{postid}", Method.GET);
            request.AddUrlSegment("first_name", "Sergio");
            request.AddUrlSegment("last_name", "Ramos");
            var content = client.Execute(request).Content;

        }
        public static void TestMethod3()
        {
            var client = new RestClient("https://reqres.in/api/users/23");
            var request = new RestRequest("posts/{postid}", Method.GET);
            
            var content = client.Execute(request).Content;

        }




    }
}