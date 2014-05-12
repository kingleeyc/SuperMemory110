using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning
{
    public interface IChoicePilesGroupView
    {
        void set1ChoisePile(int index, SuperMemory.Entities.CPile pile);
    }
}
