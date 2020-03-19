using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRACTICA_REPOSITORIO.Models
{

    [MetadataType(typeof(ClientesMetadata))]
    public partial class Cliente
    { }

    public class ClientesMetadata
    {

         
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe introducir el nombre de la categoria")]
        [Display(Name = "Nombre")]
        public string RazonSocial { get; set; }
        [DataType(DataType.MultilineText)]
        public string PosicionGeodesica { get; set; }
        [DataType(DataType.MultilineText)]
        public string Correo { get; set; }
        public string Telefono { get; set; }
    
    }
}