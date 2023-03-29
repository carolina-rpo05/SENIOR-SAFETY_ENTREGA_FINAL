namespace Modelos
{
    public class DatosPersonales
    {
        
       
        public int Id { get; set; }
        public string NumeroDocumento { get; set; }
        public bool TipoDocumento { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string DireccionDeResidencia { get; set; }
        public bool Genero { get; set; }
        public string TelefonoContacto { get; set; }
        public bool NivelEscolaridad { get; set; }
        public string EPS { get; set; }
        public bool Regimen { get; set; }
        public string CorreoElectronico { get; set; }
        public string ContactoEnCasoDeEmergencia { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
    }
}