using Exerc1.Aula1;
using MeuPrimeiroProjeto.Aula1;
using MeuPrimeiroProjeto.Aula2;
using System.Text;

//Exercicio - aula 2
ExecutarTesteTemperatura();

/*
//Aula 3 - estruturas de repeticoes 
ExecutarLoops();

//Aula 3- condicoes
TesteCondicoes();



 //tipos primitivos
ExecutarTiposPrimitivos();


//tipo data
ExecutarTesteData();

//String
ExecutarTesteString();
*/


static void ExecutarTesteTemperatura()
{
    Console.WriteLine("Insira o valor da temperatura: ");
    Temperatura objTemperatura = new Temperatura();
    string retorno = string.Empty;
    double temperatura = 0;

    var temp = Console.ReadLine();

    if (string.IsNullOrEmpty(temp))
    {
        Console.WriteLine("O valor da temperatura é obrigatório!");
        return;
    }

    Console.WriteLine("Insira a unidade da temperatura: ");

    var unidade = Console.ReadLine();

    if (string.IsNullOrEmpty(unidade))
    {
        Console.WriteLine("A unidade da temperatura é obrigatória!");
        return;
    }

    if (!unidade.Contains("C") && !unidade.Contains("F") && !unidade.Contains("K"))
    {
        Console.WriteLine("Temperatura inválida!");
        return;
    }

    if(!double.TryParse(temp, out temperatura))
    {
        Console.WriteLine("Temperatura inválida!");
        return;
    }

    retorno = objTemperatura.CalcularTemperatura(temperatura, unidade);

     Console.WriteLine(retorno);
}

static void ExecutarTiposPrimitivos()
{
    Console.WriteLine(Utility.IsNumeric(12));
    Console.WriteLine(Utility.IsNumeric(true));
    Console.WriteLine(Utility.IsNumeric('c'));
    Console.WriteLine(Utility.IsNumeric(new DateTime(2012, 1, 1)));
    Console.WriteLine(Utility.IsInteger(12.2));
    Console.WriteLine(Utility.IsInteger(123456789));
    Console.WriteLine(Utility.IsFloat(true));
    Console.WriteLine(Utility.IsFloat(12.2));
    Console.WriteLine(Utility.IsFloat(12));
    Console.WriteLine("{0} {1} {2}", 12.1, Utility.Compare(12.1, 12), 12);
}

static void ExecutarTesteData()
{
    clsDateTime dt = new clsDateTime();
    dt.imprimirDatas();
}

static void ExecutarTesteString()
{
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
}

static void TesteCondicoes()
{
    var returnComData = Condicoes.GetDiaSemana(DateTime.Today.ToString("d"));
    Console.WriteLine($"Retorno com data: {returnComData}");

    var returnComInt = Condicoes.GetDiaSemana(2);
    Console.WriteLine($"Retorno com int: {returnComInt}");
}

static void ExecutarLoops()
{
    Console.WriteLine("foreach");
    Arrays_Loops.TesteForEach();

    Console.WriteLine("for");
    Arrays_Loops.TesteFor();

    Console.WriteLine("Continue");
    Arrays_Loops.TesteContinue();

    Console.WriteLine("Break");
    Arrays_Loops.TesteBreak();

    Console.WriteLine("Do While");
    Arrays_Loops.PercorreDOWhile();

    Console.WriteLine("While");
    Arrays_Loops.PercorreWhile();
}

/*
 * Comentário de texto com mais de uma linha
 * ...
 * ....
 * 
 */