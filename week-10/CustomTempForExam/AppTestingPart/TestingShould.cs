using CustomTempForExam;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppTestingPart
{
    public class TestingShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public TestingShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        //[Fact]
        //public async Task ReturnStatusOkOnArrays()
        //{
        //    var response = await Client.GetAsync("/arrays");
        //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        //}

        //[Fact]
        //public async Task ReturnResult8WhenMultiply124()
        //{
        //    var operation = new //Example Model
        //    {
        //        What = "multiply",
        //        Numbers = new int?[] { 1, 2, 4 }
        //    };

        //    var ops = JsonConvert.SerializeObject(operation);

        //    var stringContent = new StringContent(ops.ToString(), Encoding.UTF8, "application/json");

        //    var response = await Client.PostAsync("/arrays", stringContent);

        //    string responseJson = await response.Content.ReadAsStringAsync();

        //    Assert.Equal("{\"result\":8}", responseJson);
        //}
    }
}
