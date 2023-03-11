using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeTareas
{
    class Tareas
    {

        public Tareas(string nombre, int tiempo)
        {

            this.Nombre = nombre;
            this.Tiempo = tiempo;
        }

        private string? Nombre { get; set; }
        private int Tiempo { get; set; }
    }
}
