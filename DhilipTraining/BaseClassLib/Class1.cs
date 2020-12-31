using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassLib
{
    public class BaseClass
    {
        public virtual void BaseFunc()//Only methods that are virtual can be modified in the derived class.
        {
            Console.WriteLine("Base class Function is implememted here");
        }
    }
}
