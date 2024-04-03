namespace Nucleo.Modelo
{
    public class clsActividadDetalleE
    {
        public string ID { get; set; }
        public string CodActividad { get; set; }
        public DateTime FechaAplicado { get; set; }
        public string Observaciones { get; set; }
        public clsEstadoActividadE EstadoActividadE { get; set; }
        public clsCircuitoE CircuitoE { get; set; }
        public clsSectorE SectorE { get; set; }
        public clsFuncionarioE FuncionarioE { get; set; }
    }

}
