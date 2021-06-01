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
            
            armaduras.RemoveAt(3);
            armaduras.RemoveAll(armadura => armadura.raridade == 3);

            Console.WriteLine();
            Console.WriteLine("==========================================");

            List <armadura> atualizarArmaduras = new List<armadura>();
            armadura c = new armadura("Peitoral dracônico", 5, 100, "Habilidade de voo", "Atirar bolas de fogo");
            atualizarArmaduras.Add(c);
            armaduras.Add(new armadura("Sapatos do clérigo", 5, 100, "Cura de 1% da vida perdida por segundo", "Cura de 50% da vida máxima"));

            armaduras.Insert(1, atualizarArmaduras.Find(armadura => armadura.nome == "Peitoral dracônico"));

            armaduras.Add(atualizarArmaduras.Find(armadura => armadura.nome == "Sapatos do clérigo"));

            foreach (armadura x in armaduras)
            {
                Console.WriteLine();
                Console.WriteLine($@"
                Nome----{x.nome}
                Raridade----{x.raridade}
                Level----{x.level}
                Passiva----{x.passiva}
                Ativas----{x.ativa}");
            }
        }
    }
}
