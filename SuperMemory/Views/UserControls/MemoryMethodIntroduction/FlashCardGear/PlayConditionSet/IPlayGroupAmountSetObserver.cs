using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public interface IPlayGroupAmountSetObserver
    {
        void onPlayGroupAmountChanged(int curAmount);
    }
}
