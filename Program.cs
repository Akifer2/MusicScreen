using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

// band dictionary

Dictionary<string, List<int>> bandList = new Dictionary<string, List<int>>();

void defaultBandList()
{
    bandList.Add("Linkin Park", new List<int>());
    bandList.Add("Queen", new List<int>());
    bandList.Add("The Beatles", new List<int>());
    bandList.Add("Led Zeppelin", new List<int>());
    bandList.Add("Metallica", new List<int>());
    bandList.Add("Pink Floyd", new List<int>());
    bandList.Add("Nirvana", new List<int>());
    bandList.Add("Radiohead", new List<int>());
    bandList.Add("U2", new List<int>());
    bandList.Add("AC/DC", new List<int>());
    bandList.Add("Guns N' Roses", new List<int>());
    bandList.Add("Red Hot Chili Peppers", new List<int>());
    bandList.Add("Coldplay", new List<int>());
    bandList.Add("Green Day", new List<int>());
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
