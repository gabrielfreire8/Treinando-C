// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<String> listaDasBandas = new List<string>();

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("LinkinPark", new List<int> { 10, 8, 4 });
bandasRegistradas.Add("Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case 5:
            Console.WriteLine("Tchau tchau");
            break;
        default:
            Console.WriteLine("Opcão inválida");
            break;


    }
    }

void RegistrarBanda()
{
    Console.Clear();
    exibirTituloDaOpcao("Registro das bandas");
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
    }

double ExibirMedia()
{
    Console.Clear();
    exibirTituloDaOpcao("Média da banda");

    Console.Write("Digite a banda que você quer saber a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];

        if (notasDaBanda.Count > 0) 
        {
            double media = notasDaBanda.Average();
            Console.WriteLine($"A média da banda {nomeDaBanda} é {media:F2}");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
            return media;
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} ainda não tem nenhuma avaliação");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
            return 0;
        }
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
        return 0;
    }
}


void MostrarBandasRegistradas()
{
    Console.Clear();
    exibirTituloDaOpcao("Exibindo todas as bandas registradas");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }
    foreach (string banda in bandasRegistradas.Keys)
    {
        System.Console.WriteLine($"Banda: {banda}");
    }

    System.Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();


}

void exibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    System.Console.WriteLine(astericos);
    System.Console.WriteLine(titulo);
    System.Console.WriteLine(astericos + "\n");
}

void AvaliarUmaBanda()
{


    Console.Clear();
    exibirTituloDaOpcao("Avaliar banda");
    System.Console.Write("Digite o nome da banda que deseja avaliar");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        System.Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        System.Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        System.Console.WriteLine($" \nA banda {nomeDaBanda} não foi encontrado");
        System.Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
}








ExibirOpcoesDoMenu();