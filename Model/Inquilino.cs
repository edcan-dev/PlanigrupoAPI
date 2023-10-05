namespace PlanigrupoModel
{
    public class Inquilino
    {
        public long Id { get; set; }
        public string Anclas { get; set; }
        public string ArrendatariosImportantes { get; set; }
        public string SubAnclas { get; set; }
        public string ComplejoCine { get; set; }

        public Inquilino(long id, string anclas, string arrendatariosImportantes, string subAnclas, string complejoCines)
        {
            Id = id;
            Anclas = anclas;
            ArrendatariosImportantes = arrendatariosImportantes;
            SubAnclas = subAnclas;
            ComplejoCine = complejoCines;
        }
    }

}

    