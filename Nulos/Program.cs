using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sin asignacion de valor --> Carro miCarro;
            Carro miCarro = new Carro();// <-- con asignacion de valor
            miCarro.Marca = "Volkswagen";
            miCarro.Kilometraje = 100000;

            Console.WriteLine("Marca: " + miCarro.Marca);
            Console.WriteLine("Km: " + miCarro.Kilometraje);
            if (miCarro.DueñoCarro != null)
            {
                Console.WriteLine("Dueño: " + miCarro.DueñoCarro.Nombre);
            }
            else
            {
                Console.WriteLine("El vehiculo no tiene propietario\n");
            }

            Console.ReadLine();
        }
    }
}
