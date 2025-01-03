// Melodify
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listasDasBandas = new List<string> { "U2", "The Beatles", "calipson" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 08, 6 });
bandasRegistradas.Add("Beatles", new List<int>());
void ExibirLogo()
{


    Console.WriteLine(@" 



███╗░░░███╗███████╗██╗░░░░░░█████╗░██████╗░██╗███████╗██╗░░░██╗
████╗░████║██╔════╝██║░░░░░██╔══██╗██╔══██╗██║██╔════╝╚██╗░██╔╝
██╔████╔██║█████╗░░██║░░░░░██║░░██║██║░░██║██║█████╗░░░╚████╔╝░
██║╚██╔╝██║██╔══╝░░██║░░░░░██║░░██║██║░░██║██║██╔══╝░░░░╚██╔╝░░
██║░╚═╝░██║███████╗███████╗╚█████╔╝██████╔╝██║██║░░░░░░░░██║░░░
╚═╝░░░░░╚═╝╚══════╝╚══════╝░╚════╝░╚═════╝░╚═╝╚═╝░░░░░░░░╚═╝░░░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
//registra todas as bandas
void RegistrarBandas()
{

    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o Nome da banda que deseja registrar : ");

    string nomeDaBanda = Console.ReadLine()!;

    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda}foi registrada com Sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
//Exibe todas as bandas Registradas
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as Bandas");
    // for (int i = 0; i < listasDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Bandas: {listasDasBandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Bandas: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
// Conta a quantidade de Letras e acrescenta na mesma quantidade um caracter 
void ExibirTituloDaOpcao(string titulo)
{
    int qntdLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qntdLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
void AvaliarBanda()
{
    //Digitar qual banda  deseja avaliar
    //Se a banda existir no dicionário >> atribui uma nota
    // senão, volta para o menor principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota a {nomeDaBanda} merece: ");
        int notaBanda = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(notaBanda);
        Console.WriteLine($"\nA nota foi  registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA Banda {nomeDaBanda}  não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}


ExibirOpcoesDoMenu();
ExibirLogo();
