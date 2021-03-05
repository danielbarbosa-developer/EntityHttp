using EntityHttp.Json.Test.Entities;
using NUnit.Framework;

namespace EntityHttp.Json.Test
{
    [TestFixture]
    public class GetOperationsTest : BaseTest
    {
        [SetUp]
        public void Set_EntityHttp_Configurations()
        {

        }
        [Test]
        public async void Simple_Get_Operation_Test()
        {
            EntityHttpResource client = new EntityHttpResource();
            var response = await client.GetAsync<ZipCodeResponse>();
            Assert.IsNotNull(response);
        }
        /*
        [Test]
        public Task Simple_Get_Operation_With_Request_Parameters_Test()
        {

        }
        [Test]
        public Task Simple_Get_With_Request_Parameters_And_Headers_Operation_Test()
        {

        }
        */
    }
}