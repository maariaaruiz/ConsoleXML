using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program5
    {
        static void Main(string[] args)
        {
           
            List<Persona> listaPersonas = new List<Persona>();
            XmlReader lector = new XmlTextReader("../../PersonaNueva.xml");

            while (lector.Read())
            {
                if (lector.NodeType == XmlNodeType.Element)
                {
                    if (lector.Name.Equals("persona"))
                    {
                        Persona p1 = new Persona();

                        lector.Read();
                        lector.Read();
                        lector.Read();
                        p1.Nombre = lector.Value;
                        lector.Read();
                        lector.Read();
                        lector.Read();
                        lector.Read();
                        p1.Apellidos = lector.Value;
                        lector.Read();
                        lector.Read();
                        lector.Read();
                        lector.Read();

                        p1.Edad = Convert.ToInt32(lector.Value);
                        listaPersonas.Add(p1);

                    }
                }
            }




            foreach (Persona persona in listaPersonas)
            {
                Console.WriteLine(persona.Nombre +" "+persona.Apellidos+" "+persona.Edad);
            }

           
            Console.ReadLine();

        }

        }
    }
