using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear
{
    public interface IPilesGroupView
    {
        void setPile(CPile pile, int index);

        void switch2Step(int step);
    }
}
