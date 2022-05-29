using System.Net;
using System.Text;
using Ex_01.Services;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Ex_01_test;

public class IntegrationTest
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public async Task Test1()
  {
    await using var factory = new Ex_01_Factory();
    var client = factory.CreateClient();
    //when
    var response = await client.GetAsync("/api/controller");

    //then
    Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    // Assert.AreEqual("[]", await response.Content.ReadAsStringAsync());
  }

  // [Test]
  // public async Task Test2()
  // {
  //   //given
  //   var jsonTO_DO = "{\"Id\":1,\"title\": \"string\",\"CreateDate\": \"DateTime\"}";
  //   using var jsonContent = new StringContent(jsonTO_DO, Encoding.UTF8, "application/json");
  //   // jsonContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

  //   await using var factory = new Ex_01_Factory();
  //   var client = factory.CreateClient();
  //   //when
  //   var response = await client.PostAsync("/api/{id}", jsonContent);


  //   //then
  //   Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
  //   Assert.AreEqual("{\"Id\":1,\"Title\":\"string\",\"CreateDate\":\"DateTime\"}", await response.Content.ReadAsStringAsync());
  // }
}

