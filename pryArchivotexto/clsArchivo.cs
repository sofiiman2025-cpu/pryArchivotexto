using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArchivotexto
{
    internal class clsArchivo
    {

        public string NombreArchivo = "Palabras.txt";

        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true); //abrir

            AD.WriteLine("Hola"); //grabar
            AD.WriteLine("¿Cómo estás?");

            AD.Close(); //cerrar
            AD.Dispose();
        }

        public void Grabar(string valor)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true); //abrir

            AD.WriteLine(valor); //grabar

            AD.Close(); //cerrar
            AD.Dispose();
        }

        public void Listar(ListBox lst)
        {
            string Datoleido = "";

            StreamReader AD = new StreamReader(NombreArchivo); //abrir

           Datoleido = AD.ReadToEnd(); // leer

            while (Datoleido != null)
            {
                lst.Items.Add(Datoleido);
                Datoleido = AD.ReadToEnd();
            }

            AD.Close(); //cerrar
            AD.Dispose();
        }
    }
}
