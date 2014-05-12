using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning
{
    public interface ITimingControllerObserver
    {
        void onCountdownZero();
    }
}
