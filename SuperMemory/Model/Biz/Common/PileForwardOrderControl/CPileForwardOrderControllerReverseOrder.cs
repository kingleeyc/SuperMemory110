using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear;

namespace SuperMemory.Model.Biz.Common.PileForwardOrderControl
{
    class CPileForwardOrderControllerReverseOrder : CPileForwardOrderControllerBase,IPileForwardOrderController
    {
        public CPileForwardOrderControllerReverseOrder(IPileForwardOrderOwnerController ownerController)
            :base(ownerController)
        {
        }
        #region IPileForwardOrderController 成员

        void IPileForwardOrderController.reset()
        {
            this.curPileOrder = this.lastPileOrder() + 1;
        }

        SuperMemory.Entities.CPile IPileForwardOrderController.nextPile()
        {
            this.curPileOrder--;
            this.orderCheckEnd();

            return this.getCurOrderPile();
        }

        private void orderCheckEnd()
        {
            if(this.curPileOrder < this.firstPileOrder())
            {
                this.curPileOrder = this.lastPileOrder();
            }
        }

        #endregion
    }
}
