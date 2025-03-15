using System.ComponentModel.DataAnnotations;

namespace Parcial1_DPWA.Models
{
    public class Faculties : BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Description { get; set; }
        public int CantidadCarreras { get; set; }
        public bool IsActive { get; set; }
        #region  Constructor
        public Faculties()
        {
            IsActive = true;
            Created = DateTime.Now;

        }
        public Faculties(string name, string correo, string description, int cantidadmaterias)
        {
            Name = name;
            Correo = correo;
            Description = description;
            CantidadCarreras = cantidadmaterias;
        }
        #endregion Constructor
        #region  Funcion

        public void ToggleStatus()
        {
            IsActive = !IsActive; // Cambia el estado actual (true/false)
        }
        #endregion Funcion
    }

}
