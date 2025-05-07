using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kangelane1.Kangelased;

namespace Kangelane1
{
    internal class Program
    {

namespace KangelasteAgentuur
    {
        class Program
        {
            static List<Kangelane> kangelased = new List<Kangelane>();

            static void LoeKangelasedFailist(string failinimi)
            {
                foreach (var rida in File.ReadAllLines(failinimi))
                {
                    string[] osad = rida.Split(" / ");
                    string nimi = osad[0].Trim();
                    string asukoht = osad[1].Trim();

                    if (nimi.Contains("*"))
                    {
                        // Если имя содержит "*", создаем супергероя
                        kangelased.Add(new SuperKangelane(nimi, asukoht));
                    }
                    else
                    {
                        // Иначе создаем обычного героя
                        kangelased.Add(new Kangelane(nimi, asukoht));
                    }
                }
            }

            static void Main(string[] args)
            {
                LoeKangelasedFailist("andmed.txt");

                // Выводим информацию о героях
                foreach (var kangelane in kangelased)
                {
                    Console.WriteLine(kangelane.ToString());
                    Console.WriteLine($"Päästetud: {kangelane.Paasta(1000)} inimest");
                    Console.WriteLine(kangelane.Vormiriietus());
                    Console.WriteLine(kangelane.Tervitus());
                    Console.WriteLine(kangelane.MissiooniStaatus());
                    Console.WriteLine();
                }
            }
        }
    }


