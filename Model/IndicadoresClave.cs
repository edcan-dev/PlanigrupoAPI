namespace PlanigrupoModel
{
    public class IndicadoresClave
    {
        public long Id{ get; set; }
        public Datos Dato { get; set; }
        public Inquilino Inquilino { get; set; }

        public IndicadoresClave(long id, Datos dato, Inquilino inquilino)
        {
            Id = id;
            Dato = dato;
            Inquilino = inquilino;
        }
    }
}