using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Common
{
    public interface I2PilesMatchVerifier
    {
        CPile PileLeft
        {
            get;
            set;
        }
        CPile PileRight
        {
            get;
            set;
        }

        I2PilesMatchVerifyResultObserver ResultObserver
        {
            set;
        }
    }
}
