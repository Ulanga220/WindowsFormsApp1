using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Programador
    {

        public string nombre { get; set; }

        
            public static List<Programador> ObtenerP()
        {
            List<Programador> ListaP = new List<Programador>();

                ListaP.Add(new Programador { nombre = "Juan Perez" });
                ListaP.Add(new Programador { nombre = "Lorena Lopez" });
                ListaP.Add(new Programador { nombre = "Juana Cramer" });
                ListaP.Add(new Programador { nombre = "Lorena Lopez" });
                ListaP.Add(new Programador { nombre = "Felipe Cuzzella" });


            return ListaP;



        }







    }
}
