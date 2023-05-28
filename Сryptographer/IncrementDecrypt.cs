using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сryptographer
{
    class IncrementDecrypt : DecryptionProcess
    {
        public override char Process(char symbol)
        {
            return (char)(Convert.ToInt32(symbol-1));
        }
    }
}
