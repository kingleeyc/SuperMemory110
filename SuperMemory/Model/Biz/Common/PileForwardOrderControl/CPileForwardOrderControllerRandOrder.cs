using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear;


namespace SuperMemory.Model.Biz.Common.PileForwardOrderControl
{
    class CPileForwardOrderControllerRandOrder : CPileForwardOrderControllerBase,IPileForwardOrderController
    {
        public CPileForwardOrderControllerRandOrder(IPileForwardOrderOwnerController ownerController)
            :base(ownerController)
        {
        }
        #region IPileForwardOrderController 成员

        void IPileForwardOrderController.reset()
        {
            this.rand = new Random();
        }

        SuperMemory.Entities.CPile IPileForwardOrderController.nextPile()
        {
            this.curPileOrder = this.rand.Next(this.firstPileOrder(),this.lastPileOrder()+ 1);

            return this.getCurOrderPile();
        }

        #endregion

        private Random rand;
    }
}
