using System;
using AulaListas.classes;
using System.Collections.Generic;

namespace AulaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List <armadura> armaduras = new List<armadura>();

            armaduras.Add(new armadura("Capacete imperial", 5, 100, "Deixa mais estiloso", "Cega os inimigos com tanto estilo por 5s"));
            armaduras.Add(new armadura("Peitoral bárbaro", 3, 100, "Mais 15% de força, menos 5% de mobilidade", "Aumenta a força em 50% por troca de vida"));
            armadura a = new armadura("Calça mágica", 6, 70, "Imunidade a feitiços de imobilização", "Imunidade a todos os feitiços por 3s");
            armaduras.Add(a);
            armadura b = new armadura("Sapatos élficos", 3, 30, "Cura de 3% do dano recebido a cada 2s", "Cura de 20% da vida máxima");
            armaduras.Add(b);

            foreach (armadura p in armaduras)
            {
                Console.WriteLine();
                Console.WriteLine($@"
                Nome----{p.nome}
                Raridade----{p.raridade}
                Level----{p.level}
                Passiva----{p.passiva}
                Ativas----{p.ativa}");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");

            armadura trocar = armaduras.Find(armadura => armadura.nome == "Peitoral bárbaro");
            trocar.passiva= "Mais 15% de força, menos 25% de mobilidade";
            trocar.ativa= "Aumenta a força em 40% por troca de vida";

            armaduras.RemoveAt(1);
            armaduras.Insert(1, trocar);

            foreach (armadura p in armaduras)
            {
                Console.WriteLine();
                Console.WriteLine($@"
                Nome----{p.nome}
                Raridade----{p.raridade}
                Level----{p.level}
                Passiva----{p.passiva}
                Ativas----{p.ativa}");
            }
        }
    }
}
