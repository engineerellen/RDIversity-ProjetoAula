using System.Collections;

namespace EstruturaDados.HashDictionary
{
    internal class HashTableTest
    {
        internal static void TestHashTable()
        {
            string[] arrDiasSemana = new string[] { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo" };
            string[] arMesesAno = new string[] { "Janeiro", "Feveriro", "Marco", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            string[] arrSignosZodiaco = new string[] { "Capricornio", "Aquerio", "Peixes", "Aries", "Touro", "Gêmeos", "Cancer", "Leão", "Virgem", "Libra", "Escorpião", "Sagitário" };
            string[] arrPecadosCapitais = new string[] { "Avareza", "Gula", "Inveja", "Ira", "Luxúria", "Preguiça", "Soberba" };

            Hashtable hashTest = new Hashtable();

            hashTest.Add("week", arrDiasSemana);
            hashTest.Add("meses", arMesesAno);
            hashTest.Add("signo", arrSignosZodiaco);
            hashTest.Add("pecado", arrPecadosCapitais);


            // iterando usando a instrução foreach
            // O iterador gera um objeto DictionaryEntry contendo o par key/value
            foreach (DictionaryEntry element in hashTest)
            {
                //obtém os valores da HashTable usando Key e Value
                string nome = (string)element.Key;
                string[] lista = (string[])element.Value;

                Console.WriteLine(String.Format("Nome:{0} ", nome));

                foreach (var item in lista)
                    Console.WriteLine($"Lista: {item}");

                //exibe os valores da HashTable
                Console.WriteLine("--------------------------");
            }
        }
    }
}