using System.Globalization;
using System.Reflection;
using Microsoft.VisualBasic;

List<string> bandList = new List<string> { "Metallica", "Beatles", "Pink Floyd", "Guns n' roses", "Red Hot Chilli Papers", "Nirvana" };

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

void registerBand()
{
    Console.Clear();
    Console.WriteLine("registro de bandas\n");
    Console.Write("digite o nome da banda que quer registrar: ");

    string bandName = Console.ReadLine()!;
    bandList.Add(bandName);

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
    Console.WriteLine("aqui está a lista de todas as bandas cadastradas\n");
    foreach (string band in bandList)
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
    showWelcomeMessage();
    Console.WriteLine("Bem vindo ao MusicScreen!");
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 parar listar as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("digite -1 para sair");

    Console.WriteLine("\nDigite a sua opção: ");
    string chosedOption = Console.ReadLine()!;

    int parsedChosedOption = int.Parse(chosedOption);

    switch (parsedChosedOption)
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
            Console.WriteLine("Saindo da aplicação!");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
;

OptionsMenu();

// outro método pra mostrar a banda de lista. 

/*
for (int = 0; i < bandList.Count; i++){
console.WriteLine($"banda {bandList[i]}");    
}
*/