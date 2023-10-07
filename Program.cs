using System.Globalization;
using System.Reflection;
using Microsoft.VisualBasic;

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
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("voltando para o menu principal...");
    Thread.Sleep(1000);
    OptionsMenu();
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
    Console.WriteLine("digite qualquer tecla para voltar ao menu principal");

    //metódo pra voltar para o menu principal
    Console.ReadKey();
    Console.Clear();
    OptionsMenu();
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
            Console.WriteLine("você escolheu a opção " + chosedOption);
            break;
        case 4:
            Console.WriteLine("você escolheu a opção " + chosedOption);
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
