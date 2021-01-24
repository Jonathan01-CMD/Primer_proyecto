using System;
using System.Linq;
using System.Linq.Expressions;
using Proyecto_Registro1.DAL;
using System.Collections.Generic;
using Proyecto_Registro1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Registro1.BLL
{
    class RolesBLL
    {
        public static bool Guardar(Roles role)
        {
            if (!Existe(role.Rolid))
                return Insertar(role);
            else
                return Modificar(role);
        }

        private static bool Insertar(Roles role)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Roles.Add(role);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Modificar(Roles role)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(role).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int Rolesid)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var personas = contexto.Roles.Find(Rolesid);
                if (personas != null)
                {
                    contexto.Roles.Remove(personas);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static Roles Buscar(int Rolesid)
        {
            Contexto contexto = new Contexto();
            Roles role;
            try
            {
                role = contexto.Roles.Find(Rolesid);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return role;
        }
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool existencia = false;
            try
            {
                existencia = contexto.Roles.Any(e => e.Rolid == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return existencia;
        }
        public static List<Roles> GetList(Expression<Func<Roles, bool>> criterios)
        {
            List<Roles> lista = new List<Roles>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Roles.Where(criterios).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
