using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sernios
{
    internal class Character
    {
        public static string? Name;
        public static string? Class;
        public static string? Lore;

        public static int Ancestor;
        public static int Plague;

        public static int VITALITY = 25;
        public static int METABOLSIM = 25;
        public static int INTELLIGENCE = 25;

        public static int Health = VITALITY;
        public static int Endeavor = VITALITY / 25;

        public static int Resistence = METABOLSIM;
        public static int Initiative = METABOLSIM;

        public static int Technique = INTELLIGENCE;
        public static int Parry = INTELLIGENCE;

        public static int credits = 0;
        public static int MeleeBonus = 0;

        private static void ActiveCheckbox()
        {
            switch (Plague)
            {
                case 0:
                    //Humano sem Infecção
                    VITALITY += 1;
                    INTELLIGENCE += 1;
                    METABOLSIM += 1;
                    break;
                case 1:
                    //Doença do crocodilo
                    VITALITY += 5;
                    INTELLIGENCE -= 5;
                    //Nova Habilidade: Casco Poderoso
                    break;
                case 2:
                    //Morcego
                    METABOLSIM += 2;
                    INTELLIGENCE -= 2;
                    //Nova Perícia: Voar
                    break;
                case 3:
                    //Licantropia
                    INTELLIGENCE += 3;
                    VITALITY += 2;
                    METABOLSIM -= 5;
                    //Nova Habilidade: Alcatéia 
                    break;
            }
        }
        public static string Str()
        {
            return String.Format("{0:D}; {1:D}; {2}; {3}; {4}; {5}; {6}\n" +
                "{7}", Name,Class,Ancestor,Plague,VITALITY,METABOLSIM,INTELLIGENCE,Lore);
        }
    }
}
