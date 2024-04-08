using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseLeeVerMas
    {
        string _leerMas;

        public string LeerMas1 { get => _leerMas; set => _leerMas = value; }

        public void LeerMas()
        {
            string filePath = "VerMas.txt";

            // Verifica si el archivo existe
            if (File.Exists(filePath))
            {
                try
                {
                    // Lee todo el contenido del archivo
                    _leerMas = File.ReadAllText(filePath);
                    // Imprime el texto en la consola
                    Console.WriteLine(_leerMas);
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error al leer el archivo: " + e.Message);
                }
            }
            else
            {
                try
                {
                    // Crea el archivo y escribe un mensaje predeterminado
                    string mensajePredeterminado = "I Cuatrimestre\nProyecto Programacion II\n Hecho por: Sebastian Coto Arias\nNombre del proyecto: La Zarzuela SA";
                    File.WriteAllText(filePath, mensajePredeterminado);
                    Console.WriteLine("Se ha creado el archivo VerMas.txt con el mensaje predeterminado.");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error al crear el archivo: " + e.Message);
                }
            }

        }
    }
}
