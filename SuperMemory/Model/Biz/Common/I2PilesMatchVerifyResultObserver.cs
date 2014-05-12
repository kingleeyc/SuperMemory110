using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.Common
{
    public interface I2PilesMatchVerifyResultObserver
    {
        void onMatchRight();
        void onMatchFault();
    }
}
