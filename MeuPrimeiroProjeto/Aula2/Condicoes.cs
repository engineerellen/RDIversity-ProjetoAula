using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.Aula2
{
    internal class Condicoes
    {
        /// <summary>
        /// 6 - Switch case com mais de uma opcao, com propriedades de classe GetDiasUteis
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        static string GetDiasUteis(clsDiasSemana dia) => dia switch
        {
            var (dia1, dia2) when dia1 == EnumDiaSemana.Segunda && dia2 == EnumDiaSemana.Quarta => "faço balé",
            var (dia1, dia2) when dia1 == EnumDiaSemana.Terca && dia2 == EnumDiaSemana.Quinta => "academia",
            var (dia1, dia2) when dia1 == EnumDiaSemana.Quarta && dia2 == EnumDiaSemana.Sexta => "Vou pro bar",
            var (_, _) => "Dia não especificado",
            _ => "Dia inexistente"
        };

        /// <summary>
        /// 5 - Switch case Com duas condições RetornarDiasDeAula
        /// </summary>
        /// <param name="dia1"></param>
        /// <param name="dia2"></param>
        /// <returns></returns>
        public static string RetornarDiasDeAula(EnumDiaSemana dia1, EnumDiaSemana dia2)
    => (dia1, dia2) switch
    {
        (EnumDiaSemana.Segunda, EnumDiaSemana.Quarta) => "Faço balé",
        (EnumDiaSemana.Terca, EnumDiaSemana.Quinta) => "Academia",
        (EnumDiaSemana.Quarta, EnumDiaSemana.Sexta) => "Vou pro bar",
        //default
        (_, _) => "Dias não especificados"

        //if(dia1 == "Segunda" && dia2 == "Quarta"){...}
    };



        /// <summary>
        /// 4 - SwitchCase2
        /// </summary>
        /// <param name="diaSemana"></param>
        /// <returns></returns>
        public static string SwitchCase2(EnumDiaSemana diaSemana) =>
   diaSemana switch
   {
       EnumDiaSemana.Segunda => "Inicio da Semana",
       EnumDiaSemana.Terca => "Semana Caminhando",
       EnumDiaSemana.Quarta => "Metade da Semana",
       EnumDiaSemana.Quinta => "Final de semana chegando",
       EnumDiaSemana.Sexta => "Sextou",
       _ => throw new ArgumentException(message: "Dias não uteis", paramName: nameof(diaSemana)),
   };

        /// <summary>
        /// 3 - switchCaseClasse - switch case com parametro de classe
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="preco"></param>
        /// <returns></returns>
        public static decimal switchCaseClasse(clsDiasSemana dia, decimal preco) => dia switch
        {
            { DiaSemanaProperty: EnumDiaSemana.Segunda } => preco * 0.06M,
            { DiaSemanaProperty: EnumDiaSemana.Quarta } => preco * 0.05M,
            _ => 0M
        };

        /// <summary>
        /// 2 - Teste Switch Case no C#
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        static string showSwitchCase(EnumDiaSemana dia)
        {
            string retorno = string.Empty; // "";
            switch (dia)
            {
                case EnumDiaSemana.Segunda:
                    retorno = "Iniciou a Semana";
                    break;
                //return "string"
                case EnumDiaSemana.Terca:

                    retorno = "Semana caminhando";
                    break;
                case EnumDiaSemana.Quarta:
                    retorno = "Metade da semana";
                    break;
                case EnumDiaSemana.Quinta:
                    retorno = "final de semana chegando!";
                    break;
                case EnumDiaSemana.Sexta:
                    retorno = "sextou!";
                    break;
                default:
                    retorno = "final de semana!";
                    break;
            }
            return retorno;
        }

        /// <summary>
        ///  1 - Teste IF ELSE
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        static string ExemploIF(EnumDiaSemana dia)
        {
            if (dia == EnumDiaSemana.Segunda)
            {
                return "Iniciou a semana";
            }
            else if (dia == EnumDiaSemana.Terca)
            {
                return "Já estamos no caminho";
            }
            else if (dia == EnumDiaSemana.Quarta)
            {
                return "Metade da semana já";
            }
            else if (dia == EnumDiaSemana.Quinta)
            {
                return "final de semana chegando";
            }
            else if (dia == EnumDiaSemana.Sexta)
            {
                return "sextou!";
            }
            else
            {
                return "Final de semana!";
            }

        }
    }
    public class clsDiasSemana
    {
        //propriedade enumerador
        public EnumDiaSemana DiaSemanaProperty { get; set; }

        public EnumDiaSemana Dia1 { get; set; }
        public EnumDiaSemana Dia2 { get; set; }

        public clsDiasSemana()
        {
        }

        /*public clsDiasSemana(DiaUteisSemana dia1, DiaUteisSemana dia2)
        {
            Dia1 = dia1;
            Dia2 = dia2;
        }*/

        //ou
        public clsDiasSemana(EnumDiaSemana dia1, EnumDiaSemana dia2) => (Dia1, Dia2) = (dia1, dia2);

        public void Deconstruct(out EnumDiaSemana dia1, out EnumDiaSemana dia2) =>
            (dia1, dia2) = (Dia1, Dia2);
    }

    public enum EnumDiaSemana
    {
        Segunda = 1,
        Terca = 2,
        Quarta = 3,
        Quinta = 4,
        Sexta = 5,
        Sabado = 6,
        Domingo = 7,
        NaoExiste = 8
    }
}
