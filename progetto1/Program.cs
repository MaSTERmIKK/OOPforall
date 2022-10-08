internal class Program
{
    private static void Main(string[] args)
    {

        var x = 10;
        Console.WriteLine("Variabile x " + x);

        double y = x;
        Console.WriteLine("Variabile y " + y);

        float x1 = 12000f;
        Console.WriteLine("Variabile x1 " + x1);

        int y1 = (int)x1;
        Console.WriteLine("Variabile y1 " + y1);

        int y2 = y1++;
        Console.WriteLine("Variabile y2 " + y2);

        String s = Convert.ToString(x1);
        Console.WriteLine("Variabile s " + s);

        float x2 = Convert.ToSingle(s);
        Console.WriteLine("Variabile x2 " + x2);





    }
}