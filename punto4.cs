Console.Write("Ingrese una frase:");
string frase = Console.ReadLine();
int longitud = frase.Length;
Console.WriteLine("La longitud de la frase es: " + longitud);
Console.Write("Ingrese otra Frase:");
string frase2 = Console.ReadLine();
string fraseConcatenada = string.Concat(frase, " ", frase2);
Console.WriteLine("La frase concatenada es:" + fraseConcatenada);
string[] palabras = fraseConcatenada.Split(' ');
        Console.WriteLine("Palabras de la primera frase:");
        foreach (string palabra in palabras)
        {
            Console.WriteLine(palabra);
        }
        
