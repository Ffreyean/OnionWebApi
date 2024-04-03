namespace Nucleo.Modelo
{
    public class clsReporteSeguimientoActividadesE
    {
        public string CodActividad { get; set; }
        public string FechaCrea { get; set; }
        public string NumGis { get; set; }
        public string CodMejora { get; set; }
        public string DescripcionActividad { get; set; }
        public string FechaEnvio { get; set; }
        public string FechaLimite { get; set; }
        public string IDusuCrea { get; set; }
        public string TipoActividad { get; set; }


        // ======== detalle ========
        public string Sector { get; set; }
        public string Circuito { get; set; }
        public string FechaAplicado { get; set; }
        public string Observaciones { get; set; }
        public string IDusuAplicado { get; set; }
        public string Estado { get; set; }
    }
}
