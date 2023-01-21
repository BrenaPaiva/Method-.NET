using ExemploExplorando.Models;
using System.Globalization;




Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("GO", "Goiás");
estados.Add("RJ", "Rio de Janeiro");

foreach(var item in estados )
{
    Console.WriteLine($"Chave: {item.Key} value{item.Value}");
}
Console.WriteLine("-------------------------------");

estados.Remove("RJ");
estados["GO"] = "Valor de Goiás alterado";

foreach(var item in estados )
{
    Console.WriteLine($"Chave: {item.Key}, {item.Value}");
}

string chave = "DA";
Console.WriteLine($"Chave: {chave}");

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else{
    Console.WriteLine($"Valor não existe: {chave}");
}















// Stack<int> pilha = new Stack<int>();
// pilha.Push(6);
// pilha.Push(7);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }
//  //remove e retorna o topo do obeto da bilha

// Console.WriteLine($" Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);
// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }



















//FILA
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(8);
// fila.Enqueue(7);
// fila.Enqueue(9);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o primeiro elemento: {fila.Dequeue()} ");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }












// new ExemploExcecao().Method1();





















////////////////////////////////LEITURA DE ARQUIVO EM TEXTO e demonstração de erro com try catch

// try{
// string[] linhas = File.ReadAllLines("Arquivos/arquivo_arquivoLeeitura.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// } catch (FieldAccessException ex)
// {
//     Console.WriteLine($"Erro na leitura do arquivo. Arquivo não encontrado: {ex.Message}");
// }
//  catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
// }

// Console.WriteLine("Chegou até aqui");
















// string e = "15-";
// int f = 0;

// int.TryParse(e, out f);

// Console.WriteLine(e);
// Console.WriteLine("Convertido com sucesso!");













// DateTime data = DateTime.Now;

// Console.WriteLine(data);

// //Formatando minha data do jeito que eu quero
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// //Formatando data e hora
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// //Connvertendo algo em data
// DateTime date = DateTime.Parse("17/06/2022 18:00");

// Console.WriteLine(date);



//Convertendo algo em data Parte 2
// string dataString = "17-06-2015 18:00";
// bool sucesso = DateTime.TryParseExact(dataString, // o idedal é utilizar o tryparseExact para que o programa nao seja encerrado por causa do erro
//                         "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime data);
// Console.WriteLine(dataString);

// if(sucesso){
//     Console.WriteLine($"Conversão com sucesso {data}");
// }
// else{
//     Console.WriteLine($"Esta data não é válida {dataString}");
// }

















// using System.Globalization; //Convertendo o valor da minha moeda no que eu quero

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); 

// //Valor em Monetario wem moeda C#
// decimal valorMonetario = 123M;

// Console.WriteLine($"{valorMonetario:C}"); //Em momento nenhum eu especifiquei o tipo da minha moeda, o C# pega o valor em que o sistema do Computador é atribuído

// //Representando casas decimais
// Console.WriteLine(valorMonetario.ToString("C8"));

// //Representando porcentagem
// double porcentagem = .123;
// Console.WriteLine(porcentagem.ToString("P"));

// //Formatando minha variavel de número para dígitos

// int numero = 123456;
// Console.WriteLine(numero.ToString("###-##-#"));








// Pessoa p1 = new Pessoa("Brena", "Gustavo");
// Pessoa p2 = new Pessoa("Paiva", "Siqueira");


// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();