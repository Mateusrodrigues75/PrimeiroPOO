using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Peter Parker";
            objetoPersonagem1.idade = 22;
            objetoPersonagem1.armadura = "Spider";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Gwen Stacy";
            objetoPersonagem2.idade = 23;
            objetoPersonagem2.armadura = "Spider";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");
        }
    }
}
