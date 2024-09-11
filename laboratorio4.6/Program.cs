class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite el numero del radio del circulo");
        double radio = double.Parse(Console.ReadLine());

        double area = Math.Pow(radio, 2) * Math.PI;
    }
}