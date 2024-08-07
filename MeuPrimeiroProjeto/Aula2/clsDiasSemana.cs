namespace MeuPrimeiroProjeto.Aula2
{
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
}