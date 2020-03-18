using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class ParentClass
    {
        protected int num;
        protected String name;
        public void SetParentClass(int n,String str)
        {
            num = n;
            name = str;
        }
        public String GetParentClass()
        {
            return (name + " " + num);
        }
    }
}
