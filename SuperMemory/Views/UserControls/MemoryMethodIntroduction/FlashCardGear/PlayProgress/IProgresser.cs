using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayProgress
{
    public interface IProgresser
    {
        void updateProgress(int value);
    }
}
