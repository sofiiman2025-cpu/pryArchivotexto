using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryArchivotexto
{
    internal class clsArchivo
    {
        public void Grabar()
        {
            StreamWriter AD = new StreamWriter("Palabras.txt"); //abrir
            AD.WriteLine("Hola"); //grabar
            AD.WriteLine("¿Cómo estás?");
            AD.Close(); //cerrar
            AD.Dispose();
        }


    }
}
