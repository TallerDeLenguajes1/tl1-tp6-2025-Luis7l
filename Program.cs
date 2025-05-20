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



