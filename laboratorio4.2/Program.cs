static void Main(string[] args)
{
    int fac = 1, n;
    string linea;
    Console.WriteLine("ingrese un numero entero:");
    linea = Console.ReadLine();
    n = int.Parse(linea);
    for(int i = 1; 1 <= n; i++)
    {
        fac = fac * 1;
    }
    Console.WriteLine("la factorial es: " + fac);
    Console.ReadKey();
}