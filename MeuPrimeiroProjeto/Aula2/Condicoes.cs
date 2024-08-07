namespace MeuPrimeiroProjeto.Aula2
{
    internal class Condicoes
    {
        internal static string GetDiaSemana(int DiaSemana)
            => (DiaSemana) switch
            {
                (1) => "Segunda!",
                (2) => "Terça!",
                _ => "Todos os dias!"
            };
        public static string GetDiaSemana(string data)
            => (data) switch
            {
                ("07/08/2024") => "É hoje!",
                ("08/08/2024") => "É amanhã!",
                _ => "Todo os dias!"
            };

        /// <summary>
        /// 6 - Switch case com mais de uma opcao, com propriedades de classe GetDiasUteis
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        static string GetDiasUteis(clsDiasSemana dia) => dia switch
        {
            //if(dia1 == "Segunda" && dia2 == "Quarta"){...}

            var (dia1, dia2) when dia1 == EnumDiaSemana.Segunda && dia2 == EnumDiaSemana.Quarta => "faço balé",
            var (dia1, dia2) when dia1 == EnumDiaSemana.Terca && dia2 == EnumDiaSemana.Quinta => "academia",
            var (dia1, dia2) when dia1 == EnumDiaSemana.Quarta && dia2 == EnumDiaSemana.Sexta => "Vou pro bar",
            var (_, _) => "Dia não especificado",
            _ => "Dia inexistente"
        };

        /// <summary>
        /// Switch case Com uma condição RetornarDiasDeAula
        /// </summary>
        /// <param name="dia1"></param>
        /// <returns></returns>
        public static string RetornarDiasDeAula(EnumDiaSemana dia)
    => (dia) switch
    {
        (EnumDiaSemana.Segunda) => "Início da semana",
        (EnumDiaSemana.Terca) => "Semana caminhando",
        (EnumDiaSemana.Quarta) => "Metade da semana",
        //default
        (_) => "Dia da semana inválido!"
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
       EnumDiaSemana.Sabado & EnumDiaSemana.Domingo => "Final de semana",
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

                case EnumDiaSemana.Sabado:
                case EnumDiaSemana.Domingo:
                    retorno = "final de semana!";
                    break;

                default:
                    retorno = "Dia da semana inválido!";
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
                return "Iniciou a semana";

            else if (dia == EnumDiaSemana.Terca)
                return "Já estamos no caminho";

            else if (dia == EnumDiaSemana.Quarta)
                return "Metade da semana já";

            else if (dia == EnumDiaSemana.Quinta)
                return "final de semana chegando";

            else if (dia == EnumDiaSemana.Sexta)
                return "sextou!";

            else if (dia == EnumDiaSemana.NaoExiste)
                return "não existe!";

            else
                return "Final de semana!";
        }
    }
}