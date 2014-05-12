using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Common
{
    public class CTrainningSet
    {
        private CPilesOrderAreaSet pilesOrderAreaSet = new CPilesOrderAreaSet();

        public CPilesOrderAreaSet PilesOrderAreaSet
        {
            get { return pilesOrderAreaSet; }
        }
    }
}
