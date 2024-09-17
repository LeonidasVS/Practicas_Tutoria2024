using System.Collections.Generic;
using System.Linq;
namespace LinQ
{
    internal class Program
    {
        class producto()
        {
            public string Producto { get; set; }
            public float Costo { get; set; }

        }

        class Estudiante
        {
            public string Estudiant3 { get; set; }
            public int Calificacion { get; set; }
        }

        static void Main(string[] args)
        {
            #region LinQ
            //List<producto> productos = new List<producto>
            //{
            //    new producto{Producto="Laptop", Costo=45.6f},
            //    new producto{Producto="Telefono", Costo=123.45f},
            //    new producto{Producto="PC",Costo=678.39f}

            //};

            //var listado = from lis in productos select lis;

            //foreach (var i in listado)
            //{
            //    Console.WriteLine($"El producto {i.Producto} tiene un precio de ${i.Costo}");
            //}
            #endregion

            #region Lamba
            List<Estudiante> estudios = new List<Estudiante> { 
                new Estudiante{Estudiant3="Joel",Calificacion=7},
                new Estudiante{Estudiant3="Maria",Calificacion=5},
                new Estudiante{Estudiant3="Ana",Calificacion=10}
            };

            //var consulaEstudiante = estudios.Where(x => x.Calificacion > 6).OrderBy(w=>w.Estudiant3);
            var consulaEstudiante = from n in estudios where n.Calificacion > 6 orderby n.Estudiant3 select n;

            foreach (var i in consulaEstudiante)
            {
                Console.WriteLine($"El estudiante {i.Estudiant3} paso con {i.Calificacion}");
            }

            #endregion

        }
    }
}
