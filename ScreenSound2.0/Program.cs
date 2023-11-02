using ScreenSound2._0.Models;

var queen = new Band("Queen");
var registeredBands = new Dictionary<string, List<int>>
{
    { "Linkin Park", new List<int> { 10, 8, 6 } },
    { "The Beatles", new List<int>() }
};

ShowMenuOptions();
return;

void ShowLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ShowMenuOptions()
{
    ShowLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    var option = int.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            RegisterAlbum();
            break;
        case 3:
            ShowRegisteredBands();
            break;
        case 4:
            RateOneBand();
            break;
        case 5:
            ShowDetails();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    ShowOptionTitle("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    var bandName = Console.ReadLine()!;
    registeredBands.Add(bandName, new List<int>());
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ShowMenuOptions();
}

void ShowRegisteredBands()
{
    Console.Clear();
    ShowOptionTitle("Exibindo todas as bandas registradas na nossa aplicação");

    foreach (var band in registeredBands.Keys)
    {
        Console.WriteLine($"Banda: {band}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOptions();

}

void ShowOptionTitle(string title)
{
    var lettersQty = title.Length;
    var asterisks = string.Empty.PadLeft(lettersQty, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}

void RateOneBand()
{
    Console.Clear();
    ShowOptionTitle("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    var bandName = Console.ReadLine()!;
    if (registeredBands.TryGetValue(bandName, out var value))
    {
        Console.Write($"Qual a nota que a banda {bandName} merece: ");
        var grade = int.Parse(Console.ReadLine()!);
        value.Add(grade);
        Console.WriteLine($"\nA nota {grade} foi registrada com sucesso para a banda {bandName}");
        Thread.Sleep(2000);
        Console.Clear();
        ShowMenuOptions();
    }
    else
    {
        Console.WriteLine($"\nA banda {bandName} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ShowMenuOptions();
    }

}

void ShowDetails()
{
    Console.Clear();
    ShowOptionTitle("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    var bandName = Console.ReadLine()!;
    if (registeredBands.TryGetValue(bandName, out var band))
    {
        Console.WriteLine($"\nA média da banda {bandName} é {band.Average()}.");
        // ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ShowMenuOptions();

    }
    else
    {
        Console.WriteLine($"\nA banda {bandName} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ShowMenuOptions();
    }
}

void RegisterAlbum()
{
    Console.Clear();
    ShowOptionTitle("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    var bandName = Console.ReadLine()!;
    Console.Write("Agora digite o título do álbum: ");
    var albumTitle = Console.ReadLine()!;
    // ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
    Console.WriteLine($"O álbum {albumTitle} de {bandName} foi registrado com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ShowMenuOptions();
}