using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Common
{
    public class CPilesOrderAreaSet
    {
        public int iBeginOrderSet = -1;
        public int iEndOrderSet = -1;

        public int iPilePrimOrderMin;
        public int iPilePrimOrderMax;

        internal int getFirstOrder()
        {
            if (iBeginOrderSet == -1 || iBeginOrderSet < iPilePrimOrderMin)
            {
                return iPilePrimOrderMin;
            }
            else if (iBeginOrderSet > iPilePrimOrderMax)
            {
                return iPilePrimOrderMax;                 
            }

            return iBeginOrderSet;
        }

        internal int getLastOrder()
        {
            if(iEndOrderSet == -1||iEndOrderSet > iPilePrimOrderMax)
            {
                return iPilePrimOrderMax;
            }
            else if (iEndOrderSet < iPilePrimOrderMin)
            {
                return iPilePrimOrderMin;
            }
            return iEndOrderSet;
        }
    }
}
