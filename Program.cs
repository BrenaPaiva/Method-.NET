using ExemploExplorando.Models;
using System.Globalization;




////////////////////////////////LEITURA DE ARQUIVO EM TEXTO e demonstração de erro com try catch

try{
string[] linhas = File.ReadAllLines("Arquivos/arquivo_arquivoLeeitura.txt");

foreach(string linha in linhas)
{
    Console.WriteLine(linha);
}
} catch (FieldAccessException ex)
{
    Console.WriteLine($"Erro na leitura do arquivo. Arquivo não encontrado: {ex.Message}");
}
 catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
}

Console.WriteLine("Chegou até aqui");
















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