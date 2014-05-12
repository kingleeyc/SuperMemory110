using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Common.PileForwardOrderControl
{
    public interface IPileForwardOrderOwnerController
    {
        int getFirstPileOrder();
        int getLastPileOrder();
        List<CPile> Piles
        {
            get;
        }

        CPile getPileByOrder(int pileOrder);

        void removePile(CPile pile);

        void resetPiles();
    }
}
