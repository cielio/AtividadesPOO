using System;
using System.Collections.Generic;

namespace Exercicio_3.Moldels
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) 
            : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
        }

        public List<string> Habilidades{ get; set; } = new  List<string>();
        public override void LevelUp()
        {
            Level +=1;
            Vida += 200+(Level*3);
            Mana += 2;
            Inteligencia += 2;
            Forca += 6;
        }

        public int Atack(){
            var numRandom = new Random().Next(0,300);
            return (Forca * Level) + numRandom;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}