using System;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomePessoa = "Livia";
            string objetoLeilao = "Barbie";
            double valor = 52.56;

            var l = new Leilao(nomePessoa, objetoLeilao, valor);

            string classeTostring = l.ToString();

            //Console.WriteLine(l);
            //Console.WriteLine(classeTostring);

            //sobrescrita do metodo tostring()
            Console.WriteLine(l.ToString());
        }
    }
}
