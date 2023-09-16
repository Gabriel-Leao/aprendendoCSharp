using static System.Console;

void ShowMessage(string message)
{
    WriteLine(message);
}

void ShowMenuOptions()
{
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
            WriteLine($"\nVocê digitou a opção: {option}");
            break;
        case 2:
            WriteLine($"\nVocê digitou a opção: {option}");
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

ShowMessage(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

ShowMenuOptions();
