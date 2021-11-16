using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class MyFile
    {
        public string name;
        public string text;

        public MyFile(string name, string text)
        {
            this.name = name;
            this.text = text;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }


    }
}
