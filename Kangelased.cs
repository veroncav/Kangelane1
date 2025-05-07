using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelane1
{
    internal class Kangelased
    {
        public class Kangelane 
        {
            private string nimi; 
            private string asukoht; 

            public Kangelane(string nimi, string asukoht)
            {
                this.nimi = nimi;
                this.asukoht = asukoht;
            }

            public string Nimi
            {
                get { return nimi; }
                set { nimi = value; }
            }

            public string Asukoht
            {
                get { return asukoht; }
                set { asukoht = value; }
            }

            public virtual int Paasta(int ohus) // Save
            {
                return (int)Math.Round(ohus * 0.95);
            }

            public virtual string Vormiriietus() // Uniform
            {
                return "Tavaline kangelase riietus / Regular hero costume";
            }

            public virtual string Tervitus() 
            {
                return $"Tere! Mina olen {nimi}. / Hello! I am {nimi}.";
            }

            public virtual string MissiooniStaatus() 
            {
                return "Kangelane on saadaval / Hero is available";
            }

            public override string ToString()
            {
                return $"Kangelane: {nimi}, Asukoht: {asukoht} / Hero: {nimi}, Location: {asukoht}";
            }
        }
    }

}

