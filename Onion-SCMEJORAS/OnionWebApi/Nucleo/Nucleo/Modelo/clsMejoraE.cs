namespace Nucleo.Modelo
{
    public class clsMejoraE
    {
        public string CodMejora { get; set; }
        public string Codsistema { get; set; }
        public string Siglas { get; set; }
        public string Descripcion { get; set; }
        public clsDetalleMejoraE Detalle { get; set; }
        public clsVersionE Version { get; set; }
    }
}
