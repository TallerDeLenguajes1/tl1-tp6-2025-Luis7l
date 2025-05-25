// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
int num;
Console.WriteLine("De un numero:");
bool numero = int.TryParse(Console.ReadLine(), out num);
int Darvuelta(int num)
{
    int resultado = 0;
    while (num > 0)
    {
        resultado = resultado * 10 + num % 10;
        num /= 10;
    }
    return resultado;
}
Console.WriteLine("El numero al reves es: " + Darvuelta(num));