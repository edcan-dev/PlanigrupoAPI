namespace PlanigrupoModel
{
    public class Datos
    {
        public long Id;
        public long SuperficieTotal {  get; set; }
        public long Construccion { get; set; }
        public long Comercial { get; set; }
        public string AreaDeJuegos { get; set; }
        public string Tipo {  get; set; }
        public long Tiendas { get; set; }
        public long EspaciosEstablecimiento { get; set; }

        public Datos(long id, long superficieTotal, long construccion, long comercial, string areaDeJuegos, string tipo, long tiendas, long espaciosEstablecimiento)
        {
            Id = id;
            SuperficieTotal = superficieTotal;
            Construccion = construccion;
            Comercial = comercial;
            AreaDeJuegos = areaDeJuegos;
            Tipo = tipo;
            Tiendas = tiendas;
            EspaciosEstablecimiento = espaciosEstablecimiento;
        }
    }
}