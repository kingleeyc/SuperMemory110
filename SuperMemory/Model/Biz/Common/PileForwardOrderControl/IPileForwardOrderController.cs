using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Common.PileForwardOrderControl
{
    interface IPileForwardOrderController
    {
        void reset();
        CPile nextPile();
    }
}
