
namespace PlanigrupoModel {
    public class Propiedad
    {
        public long Id {  get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string NumeroTelefonico { get; set; }
        public string SitioWeb { get; set; }
        public string InicioOperaciones { get; set; }
        public string AreaComercial { get; set; }
        public string EspaciosEstablecimiento { get; set; }
        public string AcercaDe {  get; set; }
        public string MapaURL { get; set; }
        public IndicadoresClave IndicadoresClave { get; set; }

        public Propiedad(long id, string nombre, string ubicacion, string numeroTelefonico, string sitioWeb, string inicioOperaciones, string areaComercial, string espaciosEstablecimiento, string acercaDe, string mapaURL, IndicadoresClave indicadoresClave)
        {
            Id = id;
            Nombre = nombre;
            Ubicacion = ubicacion;
            NumeroTelefonico = numeroTelefonico;
            SitioWeb = sitioWeb;
            InicioOperaciones = inicioOperaciones;
            AreaComercial = areaComercial;
            EspaciosEstablecimiento = espaciosEstablecimiento;
            AcercaDe = acercaDe;
            MapaURL = mapaURL;
            IndicadoresClave = indicadoresClave;
        }
    }
}
