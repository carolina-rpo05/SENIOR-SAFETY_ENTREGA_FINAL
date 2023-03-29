using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{   
    [Table ("Generos")]

    public class Genero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<DatosPersonales> DatosPersonales { get; set; }
    }
}
