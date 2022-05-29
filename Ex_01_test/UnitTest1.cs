using Ex_01.Services;

namespace Ex_01_test;

public class Tests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void Test1()
  {
    Service service = new Service();
    int resultado = service.Soma(1, 2);
    Assert.AreEqual(3, resultado);
  }
}