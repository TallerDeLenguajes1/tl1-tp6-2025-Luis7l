int num1;
Console.Write("Ingrese un numero: ");
string? sNum1 = Console.ReadLine();
bool R1 = int.TryParse(sNum1, out num1);
if (R1)
{
    string mAbs = $"Valor Absoluto: {Math.Abs(num1)}";
    string mSq = $"Cuadrado: {Math.Pow(num1, 2)}";
    string? mSqrt=null;
    if(num1>0){
         mSqrt = $"Raiz Cuadrada: {Math.Sqrt(num1)}";
    }else{
         mSqrt = $"No existe la Raiz cuadrada del numero {num1} ";
    }
    string mSin = $"El seno del numero es: {Math.Sin(num1)}";
    string mCos = $"El coseno del numero es: {Math.Cos(num1)}";
    Console.WriteLine(mAbs);
    Console.WriteLine(mSq);
    Console.WriteLine(mSqrt);
    Console.WriteLine(mSin);
    Console.WriteLine(mCos);
}
int num2, num3;
Console.WriteLine("Ingrese otro numerico: ");
sNum1 = Console.ReadLine();
Console.WriteLine("Ingrese otro numerico: ");
string? sNum2 = Console.ReadLine();
R1 = int.TryParse(sNum1, out num2);
bool R2 = int.TryParse(sNum2, out num3);
if (R1 && R2)
{
int num1, num2;
Console.Write("Ingrese la operacion  (+,-,/,*): ");
string? op = Console.ReadLine();
do
{
    Console.Write("Ingrese un numero: ");
    string? sNum1 = Console.ReadLine();
    Console.Write("Ingrese el otro numero: ");
    string? sNum2 = Console.ReadLine();


    bool R1 = int.TryParse(sNum1, out num1);
    bool R2 = int.TryParse(sNum2, out num2);
    int? resultado = null;
    if (R1 && R2)
    {

        switch (op)
        {
            case "+":
                resultado = num1 + num2;

                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    resultado = null;
                }
                break;
        }
    }
    Console.WriteLine(resultado);
    Console.WriteLine("Ingrese la operacion  (+,-,/,*): ");
    op = Console.ReadLine();
} while (op =="/" || op =="*" || op =="-" || op =="+");




    string mMax = $"El mayor numero es: {Math.Max(num2, num3)}";
    string mMin = $"El menor numero es: {Math.Min(num2, num3)}";
        Console.WriteLine(mMax);
        Console.WriteLine(mMin);
}