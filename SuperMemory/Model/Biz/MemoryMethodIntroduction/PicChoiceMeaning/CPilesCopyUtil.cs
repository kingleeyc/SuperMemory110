using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning
{
    class CPilesCopyUtil
    {
        public void copyPiles(List<CPile> src, List<CPile> dest)
        {
            dest.Clear();
            CPile[] arrPiles = new CPile[src.Count];
            src.CopyTo(arrPiles);
            dest.AddRange(arrPiles);
        }
    }
}
