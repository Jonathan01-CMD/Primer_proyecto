using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Registro1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Registro1.DAL
{
    class Contexto : DbContext 
    {
        public DbSet<Roles> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Gestionroles.Db");
        }
    }
}
