using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Partten.Observer;
using SuperMemory.Model.Biz.Common.PileForwardOrderControl;

namespace SuperMemory.Model.Biz.Common.PileForwardPlayer
{
    public class CPileForwardPlayerBase : CObeservableBase, IPileForwardOrderOwnerController
    {
        public void updatePiles(string pileTypeId)
        {
            this.piles = CModelMgr.Inst.Db.Pile.loadPilesEntByTypeId(pileTypeId);
            this.updatePilesPrimOrderLimit();

            this.updatePilesOther();
        }




        internal bool hasPiles()
        {
            if (null == this.piles)
            {
                return false;
            }
            if (0 == this.piles.Count)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 更新序号上下限
        /// </summary>
        /// 
        #region 更新序号上下限
        virtual protected void updatePilesPrimOrderLimit()
        {

        }

        protected int getPilesMinPrimOrder()
        {
            int iRet = 10000;
            foreach (CPile pile in this.piles)
            {
                if (pile.PrimOrder < iRet)
                {
                    iRet = pile.PrimOrder;
                }
            }

            return iRet;
        }

        protected int getPilesMaxPrimOrder()
        {
            int iRet = -1;
            foreach (CPile pile in this.piles)
            {
                if (pile.PrimOrder > iRet)
                {
                    iRet = pile.PrimOrder;
                }
            }

            return iRet;
        }

        #endregion


        virtual protected void updatePilesOther()
        {
            //throw new Exception("The method or operation is not implemented.");
        }


        #region IPileForwardOrderOwnerController 成员

        int IPileForwardOrderOwnerController.getFirstPileOrder()
        {
            return this.getConcreteFirstPileOrder();
        }

        virtual protected int getConcreteFirstPileOrder()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        int IPileForwardOrderOwnerController.getLastPileOrder()
        {
            return this.getConcreteLastPileOrder();
        }

        virtual protected int getConcreteLastPileOrder()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        CPile IPileForwardOrderOwnerController.getPileByOrder(int pileOrder)
        {
            foreach (CPile pile in this.piles)
            {
                if (pile.PrimOrder == pileOrder)
                {
                    return pile;
                }
            }

            return null;
        }


        void IPileForwardOrderOwnerController.removePile(CPile pile)
        {
            this.concrectRemovePile(pile);
        }

        virtual protected void concrectRemovePile(CPile pile)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void IPileForwardOrderOwnerController.resetPiles()
        {
            this.concrectResetPiles();
        }

        virtual protected void concrectResetPiles()
        {
            throw new Exception("The method or operation is not implemented.");
        }


        #endregion


        protected List<CPile> piles;
        List<CPile> IPileForwardOrderOwnerController.Piles
        {
            get { return this.piles; }
        }

        private CPileType curPileType;
        public CPileType CurPileType
        {
            get { return curPileType; }
            set
            {
                curPileType = value;
                this.updatePiles(this.curPileType.PileTypeId);
            }
        }


    }
}
