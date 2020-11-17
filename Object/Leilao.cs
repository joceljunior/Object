using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class Leilao
    {
        private string Nome { get; set; }
        private string Artigo { get; set; }
        private double Lance { get; set; }

        public Leilao(string nome, string artigo, double lance)
        {
            Nome = nome;
            Artigo = artigo;
            Lance = lance;
        }

        //sobescrita do metodo equals
        public override bool Equals(object obj)
        {
            Leilao outroLeilao = (Leilao)obj; // recebendo objeto
            //Leilao outroLeilao2 = obj as Leilao; // recebendo objeto de outros tipos

            return
                Artigo == outroLeilao.Artigo &&
                Lance == outroLeilao.Lance

        }
        public bool ComparaLance(string nome, string artigo, double lance)
        {
            Leilao outroLeilao = new Leilao(nome, artigo, lance);

            if (this.Equals(outroLeilao))
            {

            }
        }

        //sobreescrita do metodo tostring()
        public override string ToString()
        {
            return "Novo metodo ToString";
        }
    }
}
