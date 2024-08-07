
using MeuPrimeiroProjeto;
using System.Text;

/*
 tipos primitivos
*/
//Console.WriteLine(Utility.IsNumeric(12));
//Console.WriteLine(Utility.IsNumeric(true));
//Console.WriteLine(Utility.IsNumeric('c'));
//Console.WriteLine(Utility.IsNumeric(new DateTime(2012, 1, 1)));
//Console.WriteLine(Utility.IsInteger(12.2));
//Console.WriteLine(Utility.IsInteger(123456789));
//Console.WriteLine(Utility.IsFloat(true));
//Console.WriteLine(Utility.IsFloat(12.2));
//Console.WriteLine(Utility.IsFloat(12));
//Console.WriteLine("{0} {1} {2}", 12.1, Utility.Compare(12.1, 12), 12);


/*tipo data*/
//Data dt = new Data();
//dt.imprimirDatas();

/*String*/

//string vazia
string copoVazio = "";
Console.WriteLine($"copoVazio: {copoVazio}");

//string com espaço
string copoEspaco = " ";
Console.WriteLine($"copoEspaco: {copoEspaco}");

//string nula
string copoNulo = null;
Console.WriteLine($"copoNulo: {copoNulo}");


string concatMais = "Vamos" + " " + "concatenar +!";
Console.WriteLine(concatMais);

string concat = string.Concat("vamos", " ", "concatenar Concat()");
Console.WriteLine(concat);

string concatJoin = string.Join("vamos", " ", "concatenar Join()");
Console.WriteLine(concatJoin);

StringBuilder sb = new StringBuilder();
sb.Append("Vamos ");
sb.AppendLine("Concatenar ");
sb.Append("StringBuiler");

Console.WriteLine(sb.ToString());


int ab = 2;
string concatFormat = string.Format("Vamos {0} concatenar StringFormat {1}", ab, 44);
Console.WriteLine(concatFormat);


string concatDolar = $"vamos concatenar $ {ab}";
Console.WriteLine(concatDolar);

/*
 * Comentário de texto com mais de uma linha
 * ...
 * ....
 * 
 */


