


using System.ComponentModel.DataAnnotations;
namespace MVC6.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo requerido")]
        //[MaxLength(10,ErrorMessage ="La cantidad maxima es 10 caracteres")]
        [Display(Name = "Cedula o RUC")]
        [Length(10,13,ErrorMessage = "La cantidad de caracteres debe ser entre 10 y 13 caracteres")]
        public string Cedula_RUC { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        //[MaxLength(10,ErrorMessage ="La cantidad maxima es 10 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        //[MaxLength(10,ErrorMessage ="La cantidad maxima es 10 caracteres")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        //[MaxLength(10,ErrorMessage ="La cantidad maxima es 10 caracteres")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(10,ErrorMessage ="La cantidad maxima es 10 caracteres")]
        [Display(Name = "Celular o Convencional")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [Range(0, 100,ErrorMessage ="La cantidad de caracteres debe ser entre 1 a 3")]
        public int Edad { get; set; }


    }
}

