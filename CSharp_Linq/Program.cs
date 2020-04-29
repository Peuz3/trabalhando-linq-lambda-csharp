using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a lista de frutas
            List<string> listFrutas = new List<string>() { "banana", "laranja", "manga", "abacate", "goiaba", "cajá" };

            //Aplicações dos filtros
            var resultado = listFrutas.Select(x => x.ToUpper()).OrderBy(x => x);

            foreach (string resultadoFiltrado in resultado)
            {
                Console.WriteLine(resultadoFiltrado);
            }

            Console.WriteLine();
            Console.WriteLine("Convertendo um array de string para int");


            string[] valores = { "1", "405", "560", "11", "17", "856", "50" };

            //Utilizando o Select para conversão de String para o Int de forma ordenada
            int[] valoresInt = valores.Select(x => int.Parse(x)).OrderBy(x => x).ToArray();

            foreach (int valoresConvertidos in valoresInt)
            {
                Console.WriteLine(valoresConvertidos);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Trabalhando com Where");

            string[] nomes = { "João", "Pablo", "Marcia", "", null, null, "Bela", "Martha", null, null, "Lino" };
            //Remove o null do vetor
            var resultadoWhere = nomes.Where(x => x != null);

            //Remove o null e o espaços vazios
            var resultadoWhere2 = nomes.Where(x => !string.IsNullOrEmpty(x));

            foreach (string resultadoWhereFiltrado in resultadoWhere)
            {
                Console.WriteLine(resultadoWhereFiltrado);
            }

            Console.WriteLine();

            foreach (string resultadoWhereFiltrado2 in resultadoWhere2)
            {
                Console.WriteLine(resultadoWhereFiltrado2);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = from numero in numeros
                         where numero > 6
                         select numero;

            foreach (int numero in result)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Trabalhando com Count");

            string[] candidatos = { "Belo", "Mara", "Belo", "Mara", "Mara", "Mara", "Mara", "Mara", "Mara", "Belo", "Belo" };

            var resultadoBelo = candidatos.Count(x => x == ("Belo"));
            var resultadoMara = candidatos.Count(x => x != ("Belo"));

            Console.WriteLine($"Belo recebeu: {resultadoBelo} votos e Mara recebeu: {resultadoMara} votos");


            Console.ReadLine();
        }
    }
}
