using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public interface IPileOrderAreaSetObserver
    {
        void onOrderBeginChanged(int curOrderBegin);

        void onOrderEndChanged(int curOrderEnd);
    }
}
