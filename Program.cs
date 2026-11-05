string palavra = "banana";
string acertadas = "";
int erros = 0;
bool ganhou = false;

while (erros < 6 && !ganhou)
{
    string mostrada = "";
    int i = 0;

    while (i < palavra.Length)
    {
        if (acertadas.Contains(palavra[i].ToString()))
        {
            mostrada = mostrada + palavra[i] + " ";
        }
        else
        {
            mostrada = mostrada + "_ ";
        }
        i = i + 1;
    }

    Console.WriteLine(mostrada);

    if (!mostrada.Contains("_"))
    {
        ganhou = true;
    }
    else
    {
        Console.WriteLine("Digite uma letra:");
        string letra = Console.ReadLine().ToLower();

        if (letra.Length != 1)
        {
            Console.WriteLine("Digite apenas UMA letra.");
        }
        else if (palavra.Contains(letra))
        {
            Console.WriteLine("Tem essa letra!");
            acertadas = acertadas + letra;
        }
        else
        {
            Console.WriteLine("Não tem essa letra.");
            erros = erros + 1;
        }
    }
}

if (ganhou)
{
    Console.WriteLine("Você ganhou!");
}
else
{
    Console.WriteLine("Você perdeu! A palavra era " + palavra);
}

Console.ReadLine();