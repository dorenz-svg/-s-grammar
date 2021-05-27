using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Infrastructure
    {
        public static List<Rule> FillList(string[] arr)
        {
            List<Rule> res = new List<Rule>();
            for (int i = 0; i < arr.Length; i++)
            {
                res.Add(new Rule { Name = arr[i].Split(' ').First(), Rules = AddRules(arr[i].Split(' ')) });
            }
            return res;
        }
        private static List<string> AddRules(string[] str)
        {
            List<string> res = new List<string>();
            for (int i = 1; i < str.Length; i++)
            {
                res.Add(str[i]);
            }
            return res;
        }
        public static List<string> Search(List<Rule> rules, in int N)
        {
            List<string> result = new List<string>() { rules[0].Name };
            List<string> words = new List<string>();
            for (int i = 0; i < N; i++)
            {
                List<string> temp = new List<string>();
                for (int j = 0; j < result.Count; j++)
                {
                    for (int k = 0; k < result[j].Length; k++)
                    {
                        if (Char.IsUpper(result[j][k]))
                            AddChilder(rules, result[j],k,temp);
                    }
                }
                foreach (var item in result)
                {
                    if(item.IsLower())
                        words.Add(item);
                }
                result = temp;
            }
            foreach (var item in result)
            {
                if (item.IsLower())
                    words.Add(item);
            }
            return words.Distinct().ToList();
        }        
        private static void AddChilder(List<Rule> rules, string word,int index,List<string> res)
        {
            char letter = word[index];
            word = word.Remove(index, 1);
            var temp = rules.First(x => x.Name == letter.ToString());
            for (int i = 0; i < temp.Rules.Count; i++)
            {
                res.Add(word.Insert(index, temp.Rules[i]));
            }
        }
    }
}
