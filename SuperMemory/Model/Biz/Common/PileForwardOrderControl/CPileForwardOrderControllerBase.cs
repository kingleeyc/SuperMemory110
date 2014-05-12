using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear;

namespace SuperMemory.Model.Biz.Common.PileForwardOrderControl
{
    public class CPileForwardOrderControllerBase
    {
        public CPileForwardOrderControllerBase(IPileForwardOrderOwnerController ownerController)
        {
            this.ownerController = ownerController;            
        }

        

        protected CPile getCurOrderPile()
        {
            return this.ownerController.getPileByOrder(this.curPileOrder);
        }


        protected int firstPileOrder()
        {
            return this.ownerController.getFirstPileOrder();
        }

        protected int lastPileOrder()
        {
            return this.ownerController.getLastPileOrder();
        }

        protected int curPileOrder;
        protected IPileForwardOrderOwnerController ownerController;
    }
}
