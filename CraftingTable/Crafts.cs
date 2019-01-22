using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTable
{
    class Crafts
    {
        private string _сraft;
        public string Craftes
        {
            get { return _сraft; }
            set { _сraft = value; }
        }
      
        public void SortString()
        {
            char[] timeString = _сraft.ToCharArray();
            Array.Sort(timeString);

            string str = new string(timeString);
            _сraft = str;
        }

        public static Crafts operator +(Crafts obj1, Crafts obj2)
        {
            Crafts shovel = new Crafts();
            shovel._сraft = obj1._сraft + obj2._сraft;
            return shovel;
        }

    

        public static bool operator ==(Crafts obj1, string str)
        {
            return obj1._сraft == str;
        }
        public static bool operator !=(Crafts obj1, string str)
        {
            return obj1._сraft != str;
        }

        public static bool operator ==(Crafts obj1, Crafts obj2 )
        {
            return obj1._сraft == obj2._сraft;
        }
        public static bool operator !=(Crafts obj1, Crafts obj2)
        {
            return obj1._сraft != obj2._сraft;
        }
    }
}
