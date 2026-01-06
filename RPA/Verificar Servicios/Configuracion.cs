using System.IO;
using System;
using System.Text.Json;

namespace VerificarServicios
{
    public class Configuracion
    {
        public string Usuario{get;set;}
        public string Contrasena{get;set;}
        
        public Configuracion (string baseFolder){
            string rutaArchivoConfiguracion=Path.Combine(baseFolder,"Configuración.json");
            Console.WriteLine(rutaArchivoConfiguracion);
            
            string configuracionJson=File.ReadAllText(rutaArchivoConfiguracion);
            JsonSerializerOptions opciones=new JsonSerializerOptions(){PropertyNameCaseInsensitive=true};
            Configuracion configuracion=JsonSerializer.Deserialize <Configuracion>(configuracionJson,opciones);
            Usuario=configuracion.Usuario;
            Contrasena=configuracion.Contrasena;
        }
        public Configuracion(){}
    }
}