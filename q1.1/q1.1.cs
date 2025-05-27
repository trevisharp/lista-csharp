// O output do código a seguir é 50.
// Explique em suas palavras o porquê dessa saída.

var b = new B();
b.X = "Ola Mundo!";
b.X += "!!";
Console.WriteLine(A.Count);

public class B
{
    A a1 = new A();
    A a2 = new A();

    public string X
    {
        get => a1.X + a2.X;
        set
        {
            var len = value.Length;
            a1.X = "";
            for (int i = 0; i < len / 2; i++)
                a1.X += value[i];
            
            a2.X = "";
            for (int i = len / 2; i < len; i++)
                a2.X += value[i];
        }
    }
}

public class A
{
    public static int Count { get; private set; } = 0;
    string text = "";

    public string X
    {
        get
        {
            Count++;
            return text;
        }
        set
        {
            Count++;
            text = value;
        }
    }
}