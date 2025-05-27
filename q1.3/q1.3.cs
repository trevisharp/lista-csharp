// O output do código a seguir é "Olá, mundo!Olá, mundo!".
// Explique em suas palavras o porquê dessa saída.

var b = new B();
b.X.X = "Olá, mundo!";
b.X = null;
b.X.X += "Olá, mundo!";
Console.WriteLine(b.X.X);

public class A
{
    static string text = "";
    public string X
    {
        get => text;
        set => text = value;
    }
}

public class B
{
    private A a = null;
    public A X
    {
        get
        {
            if (a is null)
                a = new A();
            return a;
        }
        set => a = value;
    }
}