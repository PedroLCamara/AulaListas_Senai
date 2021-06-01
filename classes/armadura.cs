namespace AulaListas.classes
{
    public class armadura
    {
        public string nome;
        public int raridade;
        public int level;
        public string passiva;
        public string ativa;
        public armadura(string Nome, int Raridade, int Level, string Passiva, string Ativa){
            nome = Nome;
            raridade = Raridade;
            level = Level;
            passiva = Passiva;
            ativa = Ativa;
        }
    }
}