using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
    internal class Program
    {
        static void LearnList()
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            List<int> l = new List<int>();
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                l.Add(r.Next(100));
            }
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
        }

        static void LearnArray()
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(100);
            }
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }

        static Dictionary<string, string> lexicon = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //LearnList();
            //LearnArray();
            while (true)
            {
                Console.WriteLine("1. Add; 2. Remove; 3. Update; 4. Search; 5. Show Dictionary");
                int select = 0;
                select = int.Parse(Console.ReadLine());
                if (select == 0) { Console.Write("Please select other option"); break; }
                else
                {
                    if (select == 1) AddWord();
                    else if (select == 2) RemoveWord();
                    else if (select == 3) UpdateWord();
                    else if (select == 4) SearchWord();
                    else if (select == 5) Display();
                    else Console.WriteLine("Please select other option");
                }
            }
        }

        private static void Display()
        {
            foreach(KeyValuePair<string, string> item in lexicon)
            {
                Console.WriteLine("Vietnamese = {0}, English = {1}", item.Key, item.Value);                
            }
        }

        private static void SearchWord()
        {
            Console.WriteLine("Keyword? ");
            string keyWord = Console.ReadLine();
            while (!lexicon.ContainsKey(keyWord)) Console.WriteLine("Not found!");
            Console.WriteLine(lexicon[keyWord]);
        }

        private static void UpdateWord()
        {
            Console.WriteLine("Update? ");
            string vnUpdateWord = Console.ReadLine();
            if(vnUpdateWord == null || !lexicon.ContainsKey(vnUpdateWord)) { Console.WriteLine("Update? "); }
            else
            {
                Console.WriteLine("English of updating word? ");
                string enUpdateWord = Console.ReadLine();
                lexicon.Remove(vnUpdateWord);
                lexicon.Add(vnUpdateWord, enUpdateWord);
            }
        }

        private static void RemoveWord()
        {
            Console.WriteLine("Remove? ");
            string removeWord = Console.ReadLine();
            while (removeWord == null || !lexicon.ContainsKey(removeWord)) { Console.WriteLine("Remove? "); }
            lexicon.Remove(removeWord);
            Console.WriteLine("Remove successfully!");
        }

        private static void AddWord()
        {
            Console.WriteLine("Vietnamese: ");
            String vn = Console.ReadLine();
            if (lexicon.ContainsKey(vn))
            {
                Console.WriteLine("This word have already existed!");
            }
            else
            {
                Console.WriteLine("English: ");
                String en = Console.ReadLine();
                lexicon.Add(vn, en);
                lexicon.Add("doanh nhan", "entrepreneur");
                lexicon.Add("trung bay","exposure");
                Console.WriteLine("Success!");
            }
        }
    }
}
