using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_MemoryAddress
{
    class cCopySample
    {
        // 값(Shallow Copy)
        public int iCopy;  
        public char charCopy;

        // 참조(Deep Copy)
        public int[] arrCopy = new int[5];
        public cField claCopy = new cField(); 

    }
}
