using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сryptographer
{
    internal class DecryptContainer
    {
        public List<DecryptionProcess> processorList;
        public DecryptContainer(string key)
        {
            processorList = new List<DecryptionProcess>();
            foreach (char c in key)
            {
                switch (c)
                {
                    case 'I':
                        processorList.Add(new IncrementDecrypt());
                        break;
                    case 'D':
                        processorList.Add(new DecrementDecrypt());
                        break;
                    case 'Z':
                        processorList.Add(new ZeroDecrypt());
                        break;
                }
            }
        }
    }
}
