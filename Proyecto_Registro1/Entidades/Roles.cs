using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto_Registro1.Entidades
{
    public class Roles
    {
        [Key]
        public int Rolid { get; set; }
        
        public string Descripcion { get; set; }

        public DateTime FechaCreacion { get; set; }
        public Roles()
        {
            Rolid = 0;
            Descripcion = string.Empty;
            FechaCreacion = DateTime.Now;
        }

        internal static Roles Buscar(int value)
        {
            throw new NotImplementedException();
        }
    }
}
