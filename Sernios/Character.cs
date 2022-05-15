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

        public static string ToString()
        {
            return String.Format("{0:D}; {1:D}; {2}; {3}; {4}; {5}; {6}\n" +
                "{7}", Name,Class,Ancestor,Plague,VITALITY,METABOLSIM,INTELLIGENCE,Lore);
        }
    }
}
