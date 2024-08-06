
//Console.WriteLine("Minha primeira aula");


using MeuPrimeiroProjeto;

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
