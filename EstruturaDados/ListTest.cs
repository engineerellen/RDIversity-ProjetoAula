

namespace EstruturaDados
{
    internal class ListTest
    {
        internal static void TestList()
        {
            var list = new List<string>();

            list.Add("Galinha Pintadinha");
            list.Add("Galo Carijó");
            list.Add("Borboletinha");
            list.Add("Barata");
            list.Add("Pintinho amarelinho");
            list.Add("Mariana");

            Console.WriteLine("Turma da galinha pintadinha: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
