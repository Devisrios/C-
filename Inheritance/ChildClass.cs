using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class ChildClass:ParentClass
    {
        public void Rename(String rename)
        {
            name = rename;
        }
        static void Main(string[] args)
        {
           ChildClass p = new ChildClass();
            p.SetParentClass(10, "Shree");
            p.Rename("Devi");
            Console.WriteLine(p.GetParentClass());

        }
    }
}
