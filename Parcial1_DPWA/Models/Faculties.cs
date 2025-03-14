using System.ComponentModel.DataAnnotations;

namespace Parcial1_DPWA.Models
{
    public class Faculties 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Correo { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        #region  Constructor
        public Faculties(string name, string correo, string description)
        {
            Name = name;
            Correo = correo;
            Description = description;
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
