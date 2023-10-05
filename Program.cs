using Microsoft.AspNetCore.Mvc.RazorPages;
using PlanigrupoModel;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/api", () =>
{
    Propiedad propiedad = new Propiedad(
        1,
        "Paseo Hipódromo",
        "Naucalpan, Estado de México",
        "5559258058",
        "https://plazapaseohipodromo.com.mx/",
        "2017",
        "7590",
        "551",
        "4,700 m2 de terreno. Más de 8,000 m2 de área rentable en 3 niveles. Zona de entretenimiento y restaurantes. Centro comercial de 3 niveles. Pre-rentado en un 90% con marcas premium líderes internacionales como cinemex, petco, Mi Gusto Es y Oficinas corporativas de planigrupo.",
        "https://planigrupo.com.mx/wp-content/uploads/2018/08/Paseo-Hipodromo.pdf",
        new IndicadoresClave(
            1,
            new Datos(
                1,
                4761,
                9066,
                7590,
                "Si",
                "Centro Comunitario",
                19,
                551
                ),
            new Inquilino(
                1,
                "Cinemex Platino",
                "La Trattoria, BBVA, Donaire, Dentis+a, Oxxo",
                "Petco, Mi Gusto Es, Anytime Fitness",
                "Cinemex Platino"
                )
            )
        );

    JsonSerializerOptions jso = new JsonSerializerOptions();
    jso.WriteIndented = true;
    jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

    var propiedadJSON = JsonSerializer.Serialize(propiedad, jso);
    Console.WriteLine(propiedadJSON);
    return propiedadJSON;
});

app.Run();
