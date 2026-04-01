using System.Security.Cryptography;

string[] palavras = [
        "ABACATE",
        "ABACAXI",
        "ACEROLA",
        "ACAI",
        "ARACA",
        "BACABA",
        "BACURI",
        "BANANA",
        "CAJA",
        "CAJU",
        "CARAMBOLA",
        "CUPUACU",
        "GRAVIOLA",
        "GOIABA",
        "JABUTICABA",
        "JENIPAPO",
        "MACA",
        "MANGABA",
        "MANGA",
        "MARACUJA",
        "MURICI",
        "PEQUI",
        "PITANGA",
        "PITAYA",
        "SAPOTI",
        "TANGERINA",
        "UMBU",
        "UVA",
        "UVAIA"
];

int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

string palavraSecreta = palavras[indiceAleatorio];

char[] letrasCorretas = new char[palavraSecreta.Length];

for (int contadorLetras = 0; contadorLetras < palavraSecreta.Length; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
}

int contadorErros = 0;

bool jogadorAcertou = false;
bool jogadorPerdeu = false;

while (true)
{
    Console.Clear();
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Jogo da Forca");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Erros cometidos: " + contadorErros + " erros");
    Console.WriteLine("Chutes: ");

    for (int contadorLetras = 0; contadorLetras < palavraSecreta.Length; contadorLetras++)
    {
        Console.Write(letrasCorretas[contadorLetras]);
    }

    Console.WriteLine("\n--------------------------------------------");

    if (contadorErros == 0)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 1)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 2)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |         |        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 3)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 4)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 5)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |        / \       ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 6)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |        / \       ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    Console.WriteLine("\n--------------------------------------------");

    if (jogadorAcertou)
    {
        Console.WriteLine($"Parabéns, você acertou! A palavra secreta era: {palavraSecreta}");
        break;
    }
    else if (jogadorPerdeu)
    {
        Console.WriteLine($"Que pena, você perdeu! A palavra era: {palavraSecreta}");
        break;
    }

    Console.Write("\nDigite uma letra: ");
    char chute = Convert.ToChar(Console.ReadLine());

    bool letraFoiEncontada = false;

    for (int contadorPalavraSecreta = 0; contadorPalavraSecreta < palavraSecreta.Length; contadorPalavraSecreta++)
    {
        char letraSecretaAtual = palavraSecreta[contadorPalavraSecreta];

        if (chute == letraSecretaAtual)
        {
            letrasCorretas[contadorPalavraSecreta] = chute;
            letraFoiEncontada = true;
        }
    }
    if (!letraFoiEncontada)
        contadorErros++;
    // mudar a condicao de vitoria
    // [_,_,_,_,_,_,_] palavraSecreta = ABACATE

    string letrasCorretasCompleta = string.Join("", letrasCorretas);

    if (palavraSecreta == letrasCorretasCompleta)
        jogadorAcertou = true;

    if (contadorErros > 5)
        jogadorPerdeu = true;

}

Console.WriteLine("Digite ENTER para sair...");
Console.ReadLine();