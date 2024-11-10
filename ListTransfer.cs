using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class ListTransfer
    {
        private static List<string> list;

        public static List<string> List { get => list; set => list = value; }

        public ListTransfer(List<string> stringlist)
        {
            List = stringlist;
        }

        public ListTransfer()
        {
            
        }

        public void setList(List<string> passedlist)
        {List = passedlist;}

        public List<string> getList()
        {return List;}
    }
}
