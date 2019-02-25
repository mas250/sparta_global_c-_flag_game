using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flag_game
{
    public class Flag
    {
        string name;
        string path;

        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }


        public Flag()
        {

        }
        public Flag(string n, string p)
        {
            string name = n;
            string path = p;
        }

    }
}
