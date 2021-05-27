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
            List <Rule>res= new List<Rule>();
            for (int i = 0; i < arr.Length; i++)
            {
                res.Add(new Rule { Name = arr[i].Split(' ').First(), Rules=AddRules(arr[i].Split(' ')) });
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
        public static List<string> Search(List<Rule> rules)
        {
            return null;
        }
    }
}
