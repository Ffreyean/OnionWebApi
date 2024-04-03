namespace Nucleo.Modelo
{
    public class clsActividadE
    {
        public string CodActividad { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEnvio { get; set; }
        public DateTime FechaLimite { get; set; }
        public int NumGis { get; set; }
        public DateTime FechaCrea { get; set; }
        public string URL_Paquete { get; set; }

        public clsMejoraE MejoraE { get; set; }
        public clsSistemasE SistemaE { get; set; }
        public clsVersionE VersionE { get; set; }
        public clsTipoActividadE TipoActividadE { get; set; }
        public clsFuncionarioE FuncionarioE { get; set; }
    }
}
