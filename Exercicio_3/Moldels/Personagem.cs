namespace Exercicio_3.Moldels
{
    public class Personagem
    {
        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
            QuntPersonagens++;
        }

        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public float Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }
        public static int QuntPersonagens { get; set; }
        public virtual void LevelUp(){}

        public override string ToString()
        {
            return $"Nome: {Nome}, Vida: {Vida}. Mana: {Mana}, Xp: {Xp}\n" +
                   $"Inteligencia {Inteligencia}, Força: {Forca}, Lv: {Level}";
        }
    }
}