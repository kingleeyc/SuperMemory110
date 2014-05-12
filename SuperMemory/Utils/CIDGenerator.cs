using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Utils
{
    public class CIDGenerator
    {
        private CIDGenerator() { }

        private static CIDGenerator inst = new CIDGenerator();

        internal static CIDGenerator Inst
        {
            get { return CIDGenerator.inst; }
        }

        public string gen()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
    }
}
