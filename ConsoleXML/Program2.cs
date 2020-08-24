using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program2
    {
        static void Main(string[] args)
        {
            XmlReader lector = new XmlTextReader("persona.xml");

            while (lector.Read())
            {
                if (lector.NodeType == XmlNodeType.Text) {
                Console.WriteLine(lector.Value);
                }
            }
          
            Console.ReadLine();

            /*
             *CONCEPTOS: validar si un xml es correcto
             * - DTD: no construidos en xml
             * - XML SCHEMA: mas modernos y orientados a lenguaje xml
             */
        }
    }
}
