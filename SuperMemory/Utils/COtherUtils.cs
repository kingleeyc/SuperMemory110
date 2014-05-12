using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Utils
{
    public class COtherUtils
    {
        private static COtherUtils inst = new COtherUtils();

        public static COtherUtils Inst
        {
            get { return COtherUtils.inst; }
        }

        private COtherUtils() { }

    }
}
