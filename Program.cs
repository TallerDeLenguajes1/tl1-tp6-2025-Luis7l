Console.Write("Ingrese una frase:");
string frase = Console.ReadLine();
int longitud = frase.Length;
Console.WriteLine("La longitud de la frase es: " + longitud);
Console.Write("Ingrese otra Frase:");
string frase2 = Console.ReadLine();
string fraseConcatenada = string.Concat(frase, " ", frase2);
Console.WriteLine("La frase concatenada es:" + fraseConcatenada);
Console.WriteLine("Subcadena de la frase concatenada del índice 8 al " + (longitud - 1) + ": " + frase.Substring(8, longitud - 5));

Console.WriteLine("Palabras de la primera frase:");
foreach (string palabra in fraseConcatenada.Split(' '))
{
    Console.WriteLine(palabra);
}

Console.WriteLine("La frase en mayúsculas es: " + frase.ToUpper());
Console.WriteLine("La frase en minúsculas es: " + frase.ToLower());
