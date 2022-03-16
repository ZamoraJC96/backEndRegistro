//Modelo
using System.ComponentModel.DataAnnotations;

namespace backEndRegistro
{
    public class Registro
    {
        public int Id { get; set; }
        [StringLength(25)]
        public string Nombre { get; set; } = string.Empty;
        [StringLength(25)]
        public string Apellido { get; set; } = string.Empty;
        public int Edad { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        [StringLength(50)]
        public string LugarDeNacimiento { get; set; } = string.Empty;
        public int IdDepartamento { get; set; }
        public Departamentos? Departamento { get; set; }
    }
}
