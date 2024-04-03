namespace Nucleo.Modelo
{
    public class clsSectorE
    {
        public int CodSector { get; set; }
        public string Descripcion { get; set; }

        public clsCircuitoE Circuitos { get; set; }

        public clsFuncionarioE Funcionarios { get; set; }
    }
}
