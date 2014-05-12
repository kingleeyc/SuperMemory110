using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Common
{
    public interface ITrainningResultView
    {
        void updateCrrtCount(int crrtCount);
        void updateErrCount(int errCount);
    }
}
