using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program6
    {
        static void Main(string[] args)
        {
            // StringBuilder para creacion de muchos objetos- optimizar
            StringBuilder cadena =new StringBuilder();
            for(int i = 0; i < 40000; i++)
            {
                cadena.Append("hola");
                cadena.Append(i);
                cadena.Append("adios");
                cadena.Append(i);
                cadena.Append("hola2");
            
            }
            Console.WriteLine("termino");

            Console.ReadLine();

        }

    }
}
