using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Common.PileForwardOrderControl
{
    public class CPileForwardOrderControllerRandOrderNotLoop : CPileForwardOrderControllerBase, IPileForwardOrderController
    {

        public CPileForwardOrderControllerRandOrderNotLoop(IPileForwardOrderOwnerController ownerController)
            :base(ownerController)
        {
        }
        #region IPileForwardOrderController 成员

        void IPileForwardOrderController.reset()
        {
            this.rand = new Random();
            this.ownerController.resetPiles();
        }

        SuperMemory.Entities.CPile IPileForwardOrderController.nextPile()
        {
            int nextPileIndx = this.rand.Next(this.ownerController.Piles.Count - 1);
            CPile ret = this.ownerController.Piles[nextPileIndx];
            this.ownerController.removePile(ret);
            return ret;
        }

        #endregion
        private Random rand;

    }
}
