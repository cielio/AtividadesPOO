using System;
using System.Collections.Generic;

namespace Exercicio_3.Moldels
{
    public class Mago : Personagem
    {
        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) 
            : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
        }
        public List<string> Magias{ get; set; } = new  List<string>();
        public override void LevelUp()
        {
            Level +=1;
            Vida += 100+(Level*2);
            Mana += 6;
            Inteligencia += 6;
            Forca += 2;
        }

        public int Atack(){
            var numRandom = new Random().Next(0,300);
            return (Inteligencia * Level) + numRandom;
        }
    }
}