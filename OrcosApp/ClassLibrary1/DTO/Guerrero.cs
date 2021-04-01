using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcosModel.DTO
{
    public enum Tipo
    {
        Orco,Uruk
    }
    public enum Rango
    {
        Guerrero,Capitan,Caudillo,Mano de Sauron
    }
    public class Guerrero
    {
        private string nombre;
        private Tipo tipo;
        private int nivel;
        private Rango rango;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public Tipo Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }

        public Rango Rango
        {
            get
            {
                return rango;
            }

            set
            {
                rango = value;
            }
        }
        public override string ToString()
        {
            return Nombre + " " + Tipo + " " + Rango;
        }
    }
}
