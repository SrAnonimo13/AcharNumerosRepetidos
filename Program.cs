using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AcharNumerosRepetidosCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque o nome do arquivo: ");
            string nomeDoArquivo = Console.ReadLine();

            List<int> numerosRepetidos = AcharNumerosRepetidos(File.ReadAllText(nomeDoArquivo).Split(',').OrderBy(x => x).ToArray());

            Console.WriteLine("Os numeros repetidos são: ");
            foreach(int numero in numerosRepetidos)
            {
                Console.Write(numero + " ");                
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        static List<int> AcharNumerosRepetidos(string[] lista)
        {
            List<int> repetidos = new List<int>();
            for(int i = 0; i < lista.Length; i++)
            {
                try{
                    if(lista[i] == lista[i + 1] && repetidos.IndexOf(Int32.Parse(lista[i])) == -1){
                        repetidos.Add(Int32.Parse(lista[i]));
                    }
                } catch (IndexOutOfRangeException) {}
            }
            return repetidos;
        }
    }
}
