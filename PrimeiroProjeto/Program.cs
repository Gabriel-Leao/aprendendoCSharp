using static System.Console;

var registeredBands = new Dictionary<string, List<float>>();
registeredBands.Add("Beatles", new List<float> { 10, 9, 9 });
registeredBands.Add("Led Zeppelin", new List<float>());

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
            ReviwBand();
            break;
        case 4:
            ShowBandAverage();
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
    ShowOptionTitle("Rigistro de banda");
    Write("Digite o nome da banda: ");
    var bandName = ReadLine()!;
    registeredBands.Add(bandName, new List<float>());
    WriteLine($"\nA banda {bandName}, foi registrada com sucesso!");
    Thread.Sleep(2000);
    Clear();
    ShowMenuOptions();
}

void ListBands()
{
    Clear();
    ShowOptionTitle("Bandas registradas");
    for (var i = 0; i < registeredBands.Keys.Count; i++)
    {
        WriteLine($"{ i + 1 } - {registeredBands.Keys.ElementAt(i)}");
    }
    WriteLine("\nDigite qualquer tecla para voltar a tela inicial");
    ReadKey();
    Clear();
    ShowMenuOptions();
}

void ShowOptionTitle(string title)
{
    WriteLine("".PadLeft(title.Length, '='));
    WriteLine(title);
    WriteLine("".PadLeft(title.Length, '=') + "\n");
}

void ReviwBand()
{
    Clear();
    ShowOptionTitle("Avaliar banda");
    Write("Digite a banda que deseja avaliar: ");
    var bandName = ReadLine()!;

    if (registeredBands.ContainsKey(bandName))
    {
        Write("Digite uma nota de 0 a 10: ");
        var grade = int.Parse(ReadLine()!);
        registeredBands[bandName].Add(grade);
        WriteLine($"A nota, {grade}, foi registrada com sucesso a banda {bandName}");
        Thread.Sleep(3000);
        Clear();
        ShowMenuOptions();
    }
    else
    {
        WriteLine($"\nA banda {bandName}, não foi encontrada!");
        WriteLine("Digite qualquer tecla para voltar a tela inicial");
        ReadKey();
        Clear();
        ShowMenuOptions();
    }
}

void ShowBandAverage()
{
    Clear();
    float average = 0;
    ShowOptionTitle("Media da banda");
    Write("Digite a banda que deseja ver a média: ");
    var bandName = ReadLine()!;


    if (registeredBands.ContainsKey(bandName))
    {
        if (registeredBands[bandName].Count > 0)
        {
            WriteLine($"\nA média da banda { bandName }, é { Math.Round(registeredBands[bandName].Average(), 1) }");
            WriteLine("Digite qualquer tecla para voltar a tela inicial");
            ReadKey();
            Clear();
            ShowMenuOptions();
        }
        else
        {
            WriteLine($"\nA banda {bandName}, não tem nenhuma nota cadastrada!");
            WriteLine("Digite qualquer tecla para voltar a tela inicial");
            ReadKey();
            Clear();
            ShowMenuOptions();
        }
    }
    else
    {
        WriteLine($"\nA banda {bandName}, não foi encontrada!");
        WriteLine("Digite qualquer tecla para voltar a tela inicial");
        ReadKey();
        Clear();
        ShowMenuOptions();
    }
}
