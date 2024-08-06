namespace Teste_Software_2024_Andrade_Rodrigo.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestMethod1()
    {
        var myClass = new MyClass();

        myClass.MyFunction(null);

        // A Assert é implícita pelo [ExpectedException]
    }
}