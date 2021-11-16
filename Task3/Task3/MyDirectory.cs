using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class MyDirectory
    {
        public string road;
        public string name;
        public List<MyFile> listD;


        public MyDirectory(string road, string name, List<MyFile> listD)
        {
            this.road = road;
            this.name = name;
            this.listD = listD;
        }

        public string Road
        {
            get { return road; }
            set { road = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public List<MyFile> ListD
        {
            get { return listD; }
            set { listD = value; }
        }
    }
}