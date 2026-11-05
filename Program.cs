string palavra = "banana";
string mostrada = "";
int i = 0;
while (i < palavra.Length)
{
    mostrada = mostrada + "_ ";
    i = i + 1;
}

Console.WriteLine(mostrada);
Console.WriteLine("Pressione qualquer tecla para sair...");



Console.ReadLine();