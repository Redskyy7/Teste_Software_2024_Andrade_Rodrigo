namespace Teste_Software_2024_Andrade_Rodrigo;
public class MyClass
{
    public void MyFunction(string parameter)
    {
        if (parameter == null)
        {
            throw new ArgumentNullException(nameof(parameter));
        }
    }
}
