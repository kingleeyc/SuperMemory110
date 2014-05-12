using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Model.Utils;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding
{
    class CPilesMgr : IPilesMgr
    {
        #region IPilesMgr 成员

        void IPilesMgr.updatePiles(string pileTypeId)
        {
            this.primPiles = CModelMgr.Inst.Db.Pile.loadPilesEntByTypeId(pileTypeId);
        }

        void IPilesMgr.beginTrainning()
        {
            this.nCurPileIndex = this.transcodingBiz.TrainningSet.PilesOrderAreaSet.iPilePrimOrderMin - 1;
        }

        bool IPilesMgr.hasPiles()
        {
            if (null == this.primPiles)
            {
                return false;
            }
            if (0 == this.primPiles.Count)
            {
                return false;
            }
            return true;
        }

        void IPilesMgr.genRandOrderPrimPiles()
        {
            this.randOrderPrimPiles = CUtilFunctions.Inst.genRandOrderPilesList(this.primPiles);
        }



        CPile IPilesMgr.nextPileInRandOrderPrimPiles()
        {
            if(this.nCurPileIndex == this.randOrderPrimPiles.Count)
            {
                return null;
                 
            }
            CPile ret = this.randOrderPrimPiles.ToArray()[this.nCurPileIndex];
             
            this.nCurPileIndex++;

            return ret;
        }

        bool IPilesMgr.isAllPilesPass()
        {
            int iEndOrder;
            if(this.randOrderPrimPiles.Count < this.transcodingBiz.TrainningSet.PilesOrderAreaSet.iPilePrimOrderMax)
            {
                iEndOrder = this.randOrderPrimPiles.Count - 1;
            }else
            {
                iEndOrder = this.transcodingBiz.TrainningSet.PilesOrderAreaSet.iPilePrimOrderMax - 1;
            }
            if (this.nCurPileIndex > iEndOrder)
            {
                return true;
            }
            return false;
        }

        #region 字段属性们
        List<CPile> IPilesMgr.PrimPiles
        {
            get {
                return this.primPiles;            
            }
        }
        private List<CPile> primPiles;

        List<CPile> IPilesMgr.RandOrderPrimPiles
        {
            get
            {
                return randOrderPrimPiles;
            }
        }
        private List<CPile> randOrderPrimPiles;

        int IPilesMgr.NCurPileIndex
        {
            set
            {
                nCurPileIndex = value;
            }
            get
            {
                return nCurPileIndex;
            }
        }
        private int nCurPileIndex = 0;

        ITranscodingBiz IPilesMgr.TranscodingBiz
        {
            set { this.transcodingBiz = value; }
        }
        private ITranscodingBiz transcodingBiz;
        #endregion
        #endregion

    }
}
