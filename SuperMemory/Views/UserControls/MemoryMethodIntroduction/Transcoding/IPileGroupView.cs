using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding
{
    public interface IPileGroupView
    {
        void fill1PileData(CPile pileData,int idx);

        void cleanState();
    }
}
