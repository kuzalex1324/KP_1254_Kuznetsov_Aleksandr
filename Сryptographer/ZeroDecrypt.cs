using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сryptographer
{
    class ZeroDecrypt : DecryptionProcess
    {
        public override char Process(char symbol)
        {
            return symbol;
        }
    }
}
