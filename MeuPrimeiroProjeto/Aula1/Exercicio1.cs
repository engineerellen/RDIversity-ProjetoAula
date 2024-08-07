using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.Aula1
{
    internal class Exercicio1
    {
        internal string CalcularTemperatura(double temp, string unidade)
        {
            var temper = ConvertToCelsius(temp, unidade);

            if (temper <= 0)
                return "Congelando";

            if (temper > 0 && temper < 15)
                return "Frio";

            if (temper > 15 && temper < 21)
                return "Fresquinho";

            if (temper > 21 && temper < 28)
                return "Calor";

            if (temper > 28)
                return "Derretendo";

            return "temperatura inválida!";
        }

        private double ConvertToCelsius(double temp, string unidade)
        {
            switch (unidade)
            {
                case "C":
                    return temp;
                case "F":

                    return (temp - 32) * 5 / 9;

                case "K":
                    return temp - 273.15;

                default:
                    return 0;
            }
        }

    }
}
