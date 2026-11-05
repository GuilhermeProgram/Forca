string palavra = "banana";
string mostrada = "";
int i = 0;
while (i < palavra.Length)
{
    mostrada = mostrada + "_ ";
    i = i + 1;
}

Console.WriteLine(mostrada);

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine().ToLower();

if (letra.Length != 1)
{
    Console.WriteLine("Digite apenas UMA letra.");
}
else if (palavra.Contains(letra))
{
    Console.WriteLine("Tem essa letra!");
}
else
{
    Console.WriteLine("Não tem essa letra.");
}

Console.WriteLine("Pressione qualquer tecla para sair...");



Console.ReadLine();