using OrcosModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcosModel.DAL
{
   public class GuerrerosDAL
    {
       
            private static List<Guerrero> guerreros = new List<Guerrero>();

            public void Save(Guerrero g)
            {
                guerreros.Add(g);
            }
            public List<Guerrero> GetAll()
            {
                return guerreros;
            }

            //public Guerrero FindByParteNombre(string parteNombre) //Buscar por nombre contains

            //{
            //      //Find solo busca 1 sino null
            //}

           
        }
    
}
