namespace EstruturaDados.HashDictionary
{
    internal class DictionaryTest
    {
        internal static void TestDictionary()
        {
            string[] arrDiasSemana = new string[] { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo" };
            string[] arMesesAno = new string[] { "Janeiro", "Feveriro", "Marco", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            string[] arrSignosZodiaco = new string[] { "Capricornio", "Aquerio", "Peixes", "Aries", "Touro", "Gêmeos", "Cancer", "Leão", "Virgem", "Libra", "Escorpião", "Sagitário" };
            string[] arrPecadosCapitais = new string[] { "Avareza", "Gula", "Inveja", "Ira", "Luxúria", "Preguiça", "Soberba" };

            Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();


            dictionary.Add("weeksDay", arrDiasSemana);
            dictionary.Add("months", arMesesAno);
            dictionary.Add("signos", arrSignosZodiaco);
            dictionary.Add("pecados", arrPecadosCapitais);

            foreach (KeyValuePair<string, string[]> element in dictionary)
            {
                foreach (var item in element.Value)
                    Console.WriteLine("Nome(Key):- {0} and Lista(Value):- {1}",
                                    element.Key, item);


                Console.WriteLine("-------------------");
            }
        }
    }
}