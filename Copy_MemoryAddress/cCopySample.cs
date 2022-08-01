using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_MemoryAddress
{
    class cCopySample : ICloneable  // object Clone() 필요로하는 Deep Copy용 Interface
    {
        // 값(Shallow Copy)
        public int iCopy;  
        public char charCopy;
        // 참조(Deep Copy)
        public int[] arrCopy = new int[5];
        public cField claCopy = new cField(); 


        // Shallow Copy
        public object ShallowCopy()
        {
            return this.MemberwiseClone();  // 단순 복사본을 만듭니다
        }


        //Deep Copy. 하나씩 선언하고 일일히 복사 해야함
        public object Clone()
        {
            cCopySample DeepCopy = this.MemberwiseClone() as cCopySample;  

            //Array
            DeepCopy.arrCopy = new int[5];

            for(int i =0; i<5; i++)
            {
                DeepCopy.arrCopy[i] = this.arrCopy[i];   
            }

            //Class
            DeepCopy.claCopy = new cField();

            DeepCopy.claCopy.iValue = this.claCopy.iValue;

            return DeepCopy;
        }
    }
}
