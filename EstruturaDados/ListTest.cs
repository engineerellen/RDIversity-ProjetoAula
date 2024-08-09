

namespace EstruturaDados
{
    internal class ListTest
    {
        internal static List<string> TestList()
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
                Console.WriteLine(item);

            return list;
        }

        internal static List<string> AddList(string item, List<string> list)
        {
            list.Add(item);

            return list;
        }
    }
}