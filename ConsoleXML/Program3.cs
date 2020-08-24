using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program3
    {
        //revisar, no salen todos
        static void Main(string[] args)
        {
            XmlDocument documento = new XmlDocument();
            XmlElement elementoRaiz = documento.CreateElement("personas");
            documento.AppendChild(elementoRaiz);

            XmlElement elemento = documento.CreateElement("persona");
            
            XmlElement nombre = documento.CreateElement("nombre");
            nombre.InnerText = "pedro";
            elemento.AppendChild(nombre);
            XmlElement apellidos = documento.CreateElement("apellidos");
            apellidos.InnerText = "garcia";
            elemento.AppendChild(apellidos);
            XmlElement edad = documento.CreateElement("edad");
            edad.InnerText = "20";
            elemento.AppendChild(edad);

            elementoRaiz.AppendChild(elemento);


            XmlElement elemento2 = documento.CreateElement("persona");
            
            XmlElement nombre2 = documento.CreateElement("nombre");
            nombre2.InnerText = "laura";
            elemento2.AppendChild(nombre2);
            XmlElement apellidos2 = documento.CreateElement("apellidos");
            apellidos2.InnerText = "alvarez";
            elemento2.AppendChild(apellidos2);
            XmlElement edad2 = documento.CreateElement("edad");
            edad2.InnerText = "10";
            elemento2.AppendChild(edad2);

            elementoRaiz.AppendChild(elemento2);


            XmlElement elemento3 = documento.CreateElement("persona");

            XmlElement nombre3 = documento.CreateElement("nombre");
            nombre3.InnerText = "Leo";
            elemento3.AppendChild(nombre3);
            XmlElement apellidos3 = documento.CreateElement("apellidos");
            apellidos3.InnerText = "lopez";
            elemento3.AppendChild(apellidos3);
             XmlElement edad3 = documento.CreateElement("edad");
            edad3.InnerText = "31";
            elemento3.AppendChild(edad3);

            elementoRaiz.AppendChild(elemento3);


            documento.AppendChild(elementoRaiz);
            XmlWriter escritor = new XmlTextWriter("persona2.xml", null);
            documento.Save(escritor);

            Console.ReadLine();

        }

        }
    }
