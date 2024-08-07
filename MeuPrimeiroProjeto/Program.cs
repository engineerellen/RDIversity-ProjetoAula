using MeuPrimeiroProjeto.Aula1;
using System.Text;



//Exercicio - aula 1
ExecutarTesteTemperatura();


/*
 tipos primitivos
*/
ExecutarTiposPrimitivos();


/*tipo data*/
ExecutarTesteData();


/*String*/

ExecutarTesteString();



static void ExecutarTesteTemperatura()
{
    Console.WriteLine("Insira a temperatura: ");
    Exercicio1 exercicio1 = new Exercicio1();
    string retorno = string.Empty;

    var temp = Console.ReadLine();

    if (string.IsNullOrEmpty(temp))
    {
        Console.WriteLine("A temperatura é obrigatória!");
        return;
    }


    if (!temp.Contains("ºC") && !temp.Contains("ºF") && !temp.Contains("K"))
        Console.WriteLine("Temperatura inválida!");
    else
    {
        int temperatura = 0;
        var arrC = temp.Contains("ºC") ? temp.Split("ºC") : null;

        int? temperaturaCelsius = arrC != null && int.TryParse(arrC[0], out temperatura) ? temperatura : null;

        var arrF = temp.Contains("ºF") ? temp.Split("ºF") : null;
        int? temperaturaF = arrF != null && int.TryParse(arrF[0], out temperatura) ? temperatura : null;

        var arrK = temp.Contains("K") ? temp.Split("K") : null;
        int? temperaturaK = arrK != null && int.TryParse(arrK[0], out temperatura) ? temperatura : null;

        if (temperaturaCelsius != null)
            retorno = exercicio1.CalcularTemperatura((int)temperaturaCelsius, "C");

        if (temperaturaF != null)
            retorno = exercicio1.CalcularTemperatura((int)temperaturaF, "F");

        if (temperaturaK != null)
            retorno = exercicio1.CalcularTemperatura((int)temperaturaK, "K");
        Console.WriteLine(retorno);

    }
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

/*
 * Comentário de texto com mais de uma linha
 * ...
 * ....
 * 
 */


