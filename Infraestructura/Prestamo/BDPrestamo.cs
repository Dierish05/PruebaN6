using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infraestructura.Prestamo
{
    public class BDPrestamo
    {
        public static List<Calendario> listaprestamos = new List<Calendario>();
        public static List<Calendario> tmp = new List<Calendario>();

        #region Catalogo 

        public void Insertar(Calendario c)
        {
            listaprestamos.Add(c);
        }


        public void Eliminar(Calendario c)
        {
            listaprestamos.Remove(c);
        }

        public void Update(Calendario np, int id)
        {
            listaprestamos.Insert(id, np);

        }

        public Calendario[] GetAll()
        {
            if (listaprestamos == null)
            {
                throw new ArgumentException("No se han agregado datos aun.");
            }

            return listaprestamos.ToArray();
        }


        #endregion
    }
}
