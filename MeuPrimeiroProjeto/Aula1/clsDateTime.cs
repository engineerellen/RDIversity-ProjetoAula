namespace MeuPrimeiroProjeto.Aula1
{
    internal class clsDateTime
    {
        internal void imprimirDatas()
        {
            DateTime diaDeHoje = new DateTime(2024, 8, 6, 19, 54, 0);

            DateTime diaHoraExata = DateTime.Now;

            Console.WriteLine(diaHoraExata);


            string data = diaHoraExata.ToString("MM ‘/’ dd yyyy");
            Console.WriteLine(data);

            data = diaHoraExata.ToString("dd.MM.yyyy");
            Console.WriteLine(data);

            data = diaHoraExata.ToString("MM.dd.yyyy HH: mm");
            Console.WriteLine(data);

            data = diaHoraExata.ToString("dddd @ hh: mm tt", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(data);

            data = diaHoraExata.ToString("d");
            Console.WriteLine(data);

            data = diaHoraExata.ToString("D");
            Console.WriteLine(data);

            data = diaHoraExata.ToString("F");
            Console.WriteLine(data);

            data = diaHoraExata.ToString("y");
            Console.WriteLine(data);

        }
    }
}