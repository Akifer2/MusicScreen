using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

// band dictionary

Dictionary<string, List<int>> bandList = new Dictionary<string, List<int>>();

void defaultBandList()
{
    bandList["Linkin Park"].AddRange(new List<int> { 8, 7, 9, 8, 7 });
    bandList["Queen"].AddRange(new List<int> { 9, 9, 9, 8, 10 });
    bandList["The Beatles"].AddRange(new List<int> { 10, 10, 9, 10, 8 });
    bandList["Led Zeppelin"].AddRange(new List<int> { 9, 8, 8, 7, 9 });
    bandList["Metallica"].AddRange(new List<int> { 8, 8, 9, 7, 8 });
    bandList["Pink Floyd"].AddRange(new List<int> { 10, 9, 9, 10, 10 });
    bandList["Nirvana"].AddRange(new List<int> { 7, 8, 7, 6, 7 });
    bandList["Radiohead"].AddRange(new List<int> { 9, 10, 8, 7, 9 });
    bandList["U2"].AddRange(new List<int> { 8, 7, 9, 8, 8 });
    bandList["AC/DC"].AddRange(new List<int> { 9, 9, 8, 8, 9 });
    bandList["Guns N' Roses"].AddRange(new List<int> { 7, 8, 7, 7, 6 });
    bandList["Red Hot Chili Peppers"].AddRange(new List<int> { 9, 9, 8, 9, 8 });
    bandList["Coldplay"].AddRange(new List<int> { 8, 8, 7, 7, 9 });
    bandList["Green Day"].AddRange(new List<int> { 7, 6, 7, 6, 8 });
}

defaultBandList();

void backToMainMenu()
{
    Console.WriteLine("digite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("voltando para o menu principal...");
    Thread.Sleep(1000);
    OptionsMenu();
}

void showWelcomeMessage()
{
    Console.WriteLine(
        @" 
███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░  ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
████╗░████║██║░░░██║██╔════╝██║██╔══██╗  ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝  ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗  ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝  ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░  ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝
"
    );
}
;

void showOptionTittle(string tittle)
{
    string separator = string.Empty.PadLeft(tittle.Length, '-');

    Console.WriteLine($"{separator}");
    Console.WriteLine(tittle);
    Console.WriteLine($"{separator}\n");
}
;

void registerBand()
{
    Console.Clear();
    showOptionTittle("registro de bandas");
    Console.Write("digite o nome da banda que quer registrar: ");

    string bandName = Console.ReadLine()!;
    bandList.Add(bandName, new List<int>());

    Console.Clear();
    Console.WriteLine($"a banda {bandName} foi registrada");
    backToMainMenu();
}

void showBandList()
{
    Console.Clear();
    showOptionTittle(@"bandas cadastradas");
    Console.WriteLine("aqui está a lista de todas as bandas cadastradas\n");
    foreach (string band in bandList.Keys)
    {
        Console.WriteLine(band);
    }
    backToMainMenu();
}

void rateBand()
{
    Console.Clear();
    showOptionTittle("Avaliar bandas");
    Console.Write("digite a banda que deseja avaliar:");
    string bandName = Console.ReadLine()!;

    if (bandList.ContainsKey(bandName))
    {
        Console.WriteLine("Qual a nota deseja atribuir a banda?");
        int bandRate = int.Parse(Console.ReadLine()!);
        bandList[bandName].Add(bandRate);
        Console.WriteLine($"\nvocê atribuiu nota {bandRate} a banda {bandName}");
        backToMainMenu();
    }
    else
    {
        Console.WriteLine($"a banda {bandName} não foi encontrada");
        Console.Write("digite qualquer tecla para voltar ao menu");
        backToMainMenu();
    }
}

void showBandRateaverage()
{
    showOptionTittle("Classificação das bandas");

    foreach (string band in bandList.Keys)
    {
        if (bandList[band].Count > 0)
        {
            int bandRateSum = bandList[band].Sum();
            float bandAverage = (float)bandRateSum / bandList[band].Count;
            Console.WriteLine($"Banda: {band} Média: {bandAverage}");
        }
        else
        {
            Console.WriteLine($"Banda: {band} não tem avaliações.");
        }
    }

    backToMainMenu();
}
void OptionsMenu()
{
    Console.Clear();
    showWelcomeMessage();
    Console.WriteLine("Bem vindo ao MusicScreen!");
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 parar listar as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("digite -1 para sair");

    Console.WriteLine("\nDigite a sua opção: ");

    string chosedOption = Console.ReadLine()!;

    switch (int.Parse(chosedOption))
    {
        case 1:
            registerBand();
            break;
        case 2:
            showBandList();
            break;
        case 3:
            rateBand();
            break;
        case 4:
            showBandRateaverage();
            break;
        case -1:
            Console.Clear();
            Console.WriteLine("Te vejo na próxima!!");
            Thread.Sleep(2000);
            Console.Clear();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

;

OptionsMenu();
