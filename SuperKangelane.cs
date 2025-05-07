using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kangelane1.Kangelased;

namespace Kangelane1
{
    internal class SuperKangelane
    {
        public class SuperKangelane : Kangelane
        {
            private double osavus; // skill

            public SuperKangelane(string nimi, string asukoht)
                : base(nimi.Replace("*", ""), asukoht)
            {
                Random rnd = new Random();
                osavus = Math.Round(1.0 + rnd.NextDouble() * 4.0, 2); // [1.0, 5.0)
            }

            public double Osavus
            {
                get { return osavus; }
            }

            public override int Paasta(int ohus)
            {
                double protsent = 95 + osavus;
                return (int)Math.Round(ohus * (protsent / 100));
            }

            public override string Vormiriietus()
            {
                return "Superkangelase kostüüm / Superhero costume";
            }

            public override string Tervitus()
            {
                return $"Ma olen superkangelane {Nimi}! / I am superhero {Nimi}!";
            }

            public override string MissiooniStaatus()
            {
                return "Superkangelane on juba missioonil / Superhero is on a mission";
            }

            public override string ToString()
            {
                return base.ToString() + $" (Superkangelane, osavus: {osavus}) / (Superhero, skill: {osavus})";
            }
        }
    }

}

