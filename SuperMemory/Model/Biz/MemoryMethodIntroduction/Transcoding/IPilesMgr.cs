using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Common;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding
{
    interface IPilesMgr
    {
        bool hasPiles();
        void updatePiles(string pileTypeId);
        void genRandOrderPrimPiles();
        void beginTrainning();
        CPile nextPileInRandOrderPrimPiles();
        bool isAllPilesPass();


        int NCurPileIndex
        {
            set;
            get;
        }
        List<CPile> PrimPiles
        {
            get;
        }
        List<CPile> RandOrderPrimPiles
        {
            get;
        }

        ITranscodingBiz TranscodingBiz
        {
            set;
        }

    }
}
