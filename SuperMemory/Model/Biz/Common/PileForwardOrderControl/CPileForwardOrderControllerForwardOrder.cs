using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear;


namespace SuperMemory.Model.Biz.Common.PileForwardOrderControl
{
    class CPileForwardOrderControllerForwardOrder : CPileForwardOrderControllerBase,IPileForwardOrderController
    {
        public CPileForwardOrderControllerForwardOrder(IPileForwardOrderOwnerController ownerController)
            :base(ownerController)
        {
        }
        #region IPileForwardOrderController 成员

        void IPileForwardOrderController.reset()
        {
            this.curPileOrder = this.firstPileOrder() - 1;
        }

        SuperMemory.Entities.CPile IPileForwardOrderController.nextPile()
        {
            this.curPileOrder++;
            this.orderCheckEnd();

            return this.getCurOrderPile();
        }

        private void orderCheckEnd()
        {
            if(this.curPileOrder > this.lastPileOrder())
            {
                this.curPileOrder = this.firstPileOrder();
            }
        }

        #endregion
    }
}
