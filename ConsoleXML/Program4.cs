using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program4
    {
        static void Main(string[] args)
        {

            XmlReader lector = new XmlTextReader("../../PersonaNueva.xml");
            int total = 0;
            while (lector.Read())
            {
                if (lector.NodeType == XmlNodeType.Element)
                {
                    if (lector.Name.Equals( "edad")) {
                        lector.Read();
                        total += Convert.ToInt32(lector.Value);
                      

                    }
                }
            }
            Console.WriteLine(total);
            Console.ReadLine();

        }

        }
    }
