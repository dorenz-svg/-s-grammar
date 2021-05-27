using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
namespace Сs_grammar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arrstring = textBox1.Text.Replace("\r", "").Split('\n');
            formater(arrstring);
            List<Rule> list = Infrastructure.FillList(arrstring);
            List<string> result = Infrastructure.Search(list, int.Parse(textBox3.Text));
        }
        private void formater(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].Replace(" ", "");
                str[i] = str[i].Replace("-", " ");
                str[i] = str[i].Replace("|", " ");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
