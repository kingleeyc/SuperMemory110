using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public interface IPlayerPrioritySetObserver
    {
        void onPlayerPriorityChanged(int curPlayerPriority);
    }
}
