using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Views.UserControls.Common
{
    public interface IPileOrderAreaSetObserver
    {
        void onOrderBeginChanged(int curOrderBegin);

        void onOrderEndChanged(int curOrderEnd);
    }
}
