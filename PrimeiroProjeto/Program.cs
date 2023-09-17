using static System.Console;

var bandsList = new List<string> {"Beatles", "Led Zeppelin"};

ShowMenuOptions();
return;

void ShowMenuOptions()
{
    ShowLogo(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    WriteLine("\n[1] para registrar uma banda");
    WriteLine("[2] para mostrar todas as bandas");
    WriteLine("[3] para avaliar uma banda");
    WriteLine("[4] para exibir a média de uma banda");
    WriteLine("[0] para sair");

    Write("\nDigite a sua opção: ");
    var option =  int.Parse(ReadLine()!);

    switch (option)
    {
        case 0:
            WriteLine("\nAté mais :)");
            break;
        case 1:
            RegisterBand();
            break;
        case 2:
            ListBands();
            break;
        case 3:
            WriteLine($"\nVocê digitou a opção: {option}");
            break;
        case 4:
            WriteLine($"\nVocê digitou a opção: {option}");
            break;
        default:
            WriteLine("\nPor favor, digite apenas números entre 0-4");
            break;
    }
}

void ShowLogo(string message)
{
    WriteLine(message);
}

void RegisterBand()
{
    Clear();
    WriteLine("Rigistro de banda");
    Write("Digite o nome da banda: ");
    var bandName = ReadLine()!;
    bandsList.Add(bandName);
    WriteLine($"\nA banda {bandName}, foi registrada com sucesso!");
    Thread.Sleep(2000);
    Clear();
    ShowMenuOptions();
}

void ListBands()
{
    Clear();
    WriteLine("===================");
    WriteLine("Bandas registradas");
    WriteLine("===================\n");
    for (var i = 0; i < bandsList.Count; i++)
    {
        WriteLine($"{i + 1} - {bandsList[i]}");
    }
    // foreach (var band in bandsList)
    // {
    //     WriteLine(band);
    // }
    WriteLine("\nDigite qualquer coisa para voltar a tela inicial");
    ReadKey();
    Clear();
    ShowMenuOptions();
}
