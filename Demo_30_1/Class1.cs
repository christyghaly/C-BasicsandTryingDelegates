using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_30_1
{
   public class Class1
    {
        public void Execute()
        {
            Program prg = new Program();
            FadA del = prg.Dummy;
            del(12);

        }
    }
}
